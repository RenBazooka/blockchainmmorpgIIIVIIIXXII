namespace Shopify.Unity {
    using System.Collections.Generic;
    using System.Collections;
    using System;
    using Shopify.Unity.GraphQL;
    using Shopify.Unity.SDK;

    /// <summary>
    /// Internal state class for a Cart.
    /// </summary>
    public partial class CartState {
        public CartLineItems LineItems {
            get {
                return _LineItems;
            }
        }

        public List<CheckoutUserError> UserErrors {
            get {
                return _UserErrors;
            }
        }

        public bool IsSaved {
            get {
                return IsCreated && LineItems.IsSaved;
            }
        }

        public bool IsCreated {
            get {
                return CurrentCheckout != null;
            }
        }

        public Checkout CurrentCheckout { get; private set; }

        private ShopifyClient Client;

        private CartLineItems _LineItems;
        private List<CheckoutUserError> _UserErrors = null;
        private List<String> DeletedLineItems = new List<string>();

        public CartState(ShopifyClient client) {
            Client = client;
            _LineItems = new CartLineItems();
            _LineItems.OnChange += OnLineItemChange;
        }

        public void Reset() {
            _LineItems.Reset();
            _UserErrors = null;
            DeletedLineItems.Clear();
            CurrentCheckout = null;
        }

        public decimal Subtotal() {
            return _LineItems.Subtotal;
        }

        public void SetShippingLine(string shippingRateHandle, CompletionCallback callback) {
            MutationQuery query = new MutationQuery();

            DefaultQueries.checkout.ShippingLineUpdate(query, CurrentCheckout.id(), shippingRateHandle);

            Client.Mutation(query, (Mutation response, ShopifyError error) => {
                if (error != null) {
                    callback(error);
                    return;
                }

                if (UpdateState(response.checkoutShippingLineUpdate().checkout(), response.checkoutShippingLineUpdate().checkoutUserErrors())) {
                    if (CurrentCheckout.ready()) {
                        callback(null);
                    } else {
                        PollCheckoutAndUpdate(PollCheckoutReady, callback);
                    }
                } else {
                    HandleUserError(callback);
                }
            });
        }

        public void SetEmailAddress(string email, CompletionCallback callback) {
            MutationQuery query = new MutationQuery();

            DefaultQueries.checkout.EmailUpdate(query, CurrentCheckout.id(), email);

            Client.Mutation(query, (Mutation response, ShopifyError error) => {
                if (error != null) {
                    callback(error);
                } else {
                    if (UpdateState(response.checkoutEmailUpdateV2().checkout(), response.checkoutEmailUpdateV2().checkoutUserErrors())) {
                        if (CurrentCheckout.ready()) {
                            callback(null);
                        } else {
                            PollCheckoutAndUpdate(PollCheckoutReady, callback);
                        }
                    } else {
                        HandleUserError(callback);
                    }
                }
            });
        }

        public void SetShippingAddress(MailingAddressInput mailingAddressInput, CompletionCallback callback) {
            MutationQuery query = new MutationQuery();

            DefaultQueries.checkout.ShippingAddressUpdate(query, CurrentCheckout.id(), mailingAddressInput);

            Client.Mutation(query, (Mutation response, ShopifyError error) => {
                if (error != null) {
                    callback(error);
                } else {
                    if (UpdateState(response.checkoutShippingAddressUpdateV2().checkout(), response.checkoutShippingAddressUpdateV2().checkoutUserErrors())) {
                        PollCheckoutAndUpdate(PollCheckoutAvailableShippingRatesReady, callback);
                    } else {
                        HandleUserError(callback);
                    }
                }
            });
        }

        public void SetFinalCheckoutFields(string email, ShippingFields? shippingFields, CompletionCallback callback) {
            MutationQuery query = new MutationQuery();

            DefaultQueries.checkout.EmailUpdate(query, CurrentCheckout.id(), email);

            if (shippingFields.HasValue) {
                DefaultQueries.checkout.ShippingAddressUpdate(query, CurrentCheckout.id(), shippingFields.Value.ShippingAddress);
                DefaultQueries.checkout.ShippingLineUpdate(query, CurrentCheckout.id(), shippingFields.Value.ShippingIdentifier);
            }

            Client.Mutation(query, (Mutation response, ShopifyError error) => {
                if (error != null) {
                    callback(error);
                } else {
                    var userErrors = response.checkoutShippingAddressUpdateV2().checkoutUserErrors();
                    if (shippingFields.HasValue) {
                        userErrors.AddRange(response.checkoutShippingLineUpdate().checkoutUserErrors());
                        userErrors.AddRange(response.checkoutEmailUpdateV2().checkoutUserErrors());
                    }

                    if (UpdateState(response.checkoutEmailUpdateV2().checkout(), userErrors)) {
                        PollCheckoutAndUpdate(PollCheckoutReady, callback);
                    } else {
                        HandleUserError(callback);
                    }
                }
            });
        }

        public void CheckoutSave(CompletionCallback callback) {
            if (!IsCreated) {
                CreateRemoteCheckoutFromLocalState(callback);
            } else if (!IsSaved) {
                UpdateRemoteCheckoutFromLocalState(callback);
            } else {
                callback(null);
            }
        }

        private void CreateRemoteCheckoutFromLocalState(CompletionCallback callback) {
            MutationQuery query = new MutationQuery();

            List<CheckoutLineItemInput> newLineItemInput = CartLineItems.ConvertToCheckoutLineItemInput(LineItems.All());

            DefaultQueries.checkout.Create(query, newLineItemInput);

            Client.Mutation(query, (Mutation response, ShopifyError error) => {
                if (error != null) {
                    callback(error);
                    return;
                }

                if (UpdateState(response.checkoutCreate().checkout(), response.checkoutCreate().checkoutUserErrors())) {
                    if (CurrentCheckout.ready()) {
                        callback(null);
                    } else {
                        PollCheckoutAndUpdate(PollCheckoutReady, callback);
                    }
                } else {
                    HandleUserError(callback);
                }
            });
        }

        public void CheckoutWithTokenizedPaymentV2(TokenizedPaymentInputV2 tokenizedPaymentInputV2, CompletionCallback callback) {
            Action<Payment> pollPayment = (payment) => {
                PollPaymentReady(payment.id(), (Payment newPayment, ShopifyError error) => {
                    if (error != null) {
                        callback(error);
                    } else {
                        if (UpdateState(payment.checkout())) {
                            callback(null);
                        } else {
                            HandleUserError(callback);
                        }
                    }
                });
            };

            Action checkoutWithTokenizedPaymentV2 = () => {
                MutationQuery query = new MutationQuery();
                DefaultQueries.checkout.CheckoutCompleteWithTokenizedPaymentV2(query, CurrentCheckout.id(), tokenizedPaymentInputV2);

                Client.Mutation(query, (Mutation response, ShopifyError error) => {
                    if (error != null) {
                        callback(error);
                        return;
                    } else {
                        var responseNode = response.checkoutCompleteWithTokenizedPaymentV2();
                        var payment = responseNode.payment();

                        if (UpdateState(responseNode.checkout(), responseNode.checkoutUserErrors())) {
                            if (payment.ready()) {
                                callback(null);
                            } else {
                                pollPayment(payment);
                            }
                        } else {
                            HandleUserError(callback);
                        }
                    }
                });
            };

            // Ensure we can checkout first
            if (CurrentCheckout.ready()) {
                checkoutWithTokenizedPaymentV2();
            } else {
                PollCheckoutReady((Checkout checkout, ShopifyError error) => {
                    if (error != null) {
                        callback(error);
                    } else {
                        checkoutWithTokenizedPaymentV2();
                    }
                });
            }
        }

        private void UpdateRemoteCheckoutFromLocalState(CompletionCallback callback) {
            MutationQuery query = new MutationQuery();

            // remove all line items them add them
            List<string> lineItemsToRemove = CartLineItems.ConvertToLineItemIds(LineItems.All());
            lineItemsToRemove.AddRange(DeletedLineItems);

            List<CheckoutLineItemInput> lineItemsToAdd = CartLineItems.ConvertToCheckoutLineItemInput(LineItems.All());

            DefaultQueries.checkout.LineItemsRemove(query, CurrentCheckout.id(), lineItemsToRemove);
            DefaultQueries.checkout.LineItemsAdd(query, CurrentCheckout.id(), lineItemsToAdd);

            Client.Mutation(query, (Mutation response, ShopifyError error) => {
                if (error != null) {
                    callback(error);
                    return;
                }

                DeletedLineItems.Clear();

                if (UpdateState(response.checkoutLineItemsAdd().checkout(), response.checkoutLineItemsAdd().checkoutUserErrors())) {
                    if (CurrentCheckout.ready()) {
                        callback(null);
                    } else {
                        PollCheckoutAndUpdate(PollCheckoutReady, callback);
                    }
                } else {
                    HandleUserError(callback);
                }
            });
        }

        private bool UpdateState(Checkout checkout) {
            return UpdateState(checkout, new List<CheckoutUserError>());
        }

        private bool UpdateState(Checkout checkout, List<CheckoutUserError> userErrors) {
            if (CurrentCheckout == null) {
                CurrentCheckout = checkout;
            } else {
                MergeCheckout merger = new MergeCheckout();

                CurrentCheckout = merger.Merge(CurrentCheckout, checkout);
            }

            if (userErrors.Count > 0) {
                _UserErrors = userErrors;
            } else {
                _UserErrors = null;
            }

            UpdateLineItemFromCheckout(CurrentCheckout);

            return _UserErrors == null;
        }

        private void UpdateLineItemFromCheckout(Checkout checkout) {
            if (checkout == null) {
                return;
            }

            // sometimes we may not query line items for instance when polling is being performed
            try {
                List<CheckoutLineItem> lineItems = (List<CheckoutLineItem>) checkout.lineItems();

                LineItems.UpdateLineItemsFromCheckoutLineItems(lineItems);
#pragma warning disable 0168
            } catch (NoQueryException exception) { }
#pragma warning restore 0168
        }

        private void HandleUserError(CompletionCallback callback) {
            ShopifyError error = new ShopifyError(
                ShopifyError.ErrorType.UserError,
                "There were issues with some of the fields sent. See `cart.UserErrors`"
            );

            callback(error);
        }

        private void OnLineItemChange(CartLineItems.LineItemChangeType type, CartLineItem lineItem) {
            switch(type) {
                case CartLineItems.LineItemChangeType.Remove:
                    DeletedLineItems.Add(lineItem.ID);
                break;
            }
        }

        private delegate void CheckoutPollQuery(QueryRootQuery query, string checkoutId);
        private delegate void CheckoutPoll(CheckoutPollFinishedHandler callback);
        private delegate void CheckoutPollFinishedHandler(Checkout checkout, ShopifyError error);
        private delegate void PaymentPollFinishedHandler(Payment payment, ShopifyError error);

        // Polls a Checkout, till isReady returns True.
        private void PollCheckoutNode(CheckoutPollQuery checkoutQuery, PollUpdatedHandler isReady, CheckoutPollFinishedHandler callback) {
            QueryRootQuery query = new QueryRootQuery();
            checkoutQuery(query, CurrentCheckout.id());

            Client.PollQuery(isReady, query, (response, error) => {

                if (error != null) {
                    callback(null, error);
                } else {
                    Checkout checkout = (Checkout) response.node();
                    callback(checkout, null);
                }
            });
        }

        // Polls a Payment node, till isReady returns True.
        private void PollPaymentNode(string paymentId, PollUpdatedHandler isReady, PaymentPollFinishedHandler callback) {
            QueryRootQuery query = new QueryRootQuery();
            DefaultQueries.checkout.PaymentPoll(query, paymentId);

            Client.PollQuery(isReady, query, (response, error) => {
                if (error != null) {
                    callback(null, error);
                } else {
                    Payment payment = (Payment) response.node();
                    callback(payment, null);
                }
            });
        }

        // Convenience method to poll a Checkout node till its ready property is True
        private void PollCheckoutReady(CheckoutPollFinishedHandler callback) {

            PollUpdatedHandler isReady = (updatedQueryRoot) => {
                var checkout = (Checkout) updatedQueryRoot.node();
                return checkout.ready();
            };

            PollCheckoutNode(DefaultQueries.checkout.Poll, isReady, callback);
        }

        // Convenience method to poll a Checkout node till its available shipping rates' ready property is True
        private void PollCheckoutAvailableShippingRatesReady(CheckoutPollFinishedHandler callback) {
            PollUpdatedHandler isReady = (updatedQueryRoot) => {
                var checkout = (Checkout) updatedQueryRoot.node();
                return checkout.availableShippingRates().ready();
            };

            PollCheckoutNode(DefaultQueries.checkout.AvailableShippingRatesPoll, isReady, callback);
        }

        // Convenience method to perform some polling on Checkout and update the Current Checkout when completed
        private void PollCheckoutAndUpdate(CheckoutPoll poll, CompletionCallback callback) {
            poll((Checkout checkout, ShopifyError error) => {
                if (error == null && checkout != null) {
                    UpdateState(checkout);
                }
                callback(error);
            });
        }

        // Convenience method to poll a Payment node with paymentId till its ready property is True
        private void PollPaymentReady(string paymentId, PaymentPollFinishedHandler callback) {
            PollUpdatedHandler isReady = (updatedQueryRoot) => {
                var payment = (Payment) updatedQueryRoot.node();
                return payment.ready();
            };

            PollPaymentNode(paymentId, isReady, callback);
        }
    }
}
