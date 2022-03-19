namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// The schema’s entry-point for mutations. This acts as the public, top-level API from which all mutation queries must start.
    /// </summary>
    public class Mutation : AbstractResponse, ICloneable {
        /// <summary>
        /// <see ref="Mutation" /> Accepts deserialized json data.
        /// <see ref="Mutation" /> Will further parse passed in data.
        /// </summary>
        /// <param name="dataJSON">Deserialized JSON data for Mutation</param>
        public Mutation(Dictionary<string, object> dataJSON) {
            DataJSON = dataJSON;
            Data = new Dictionary<string,object>();

            foreach (string key in dataJSON.Keys) {
                string fieldName = key;
                Regex regexAlias = new Regex("^(.+)___.+$");
                Match match = regexAlias.Match(key);

                if (match.Success) {
                    fieldName = match.Groups[1].Value;
                }

                switch(fieldName) {
                    case "checkoutAttributesUpdate":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new CheckoutAttributesUpdatePayload((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "checkoutAttributesUpdateV2":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new CheckoutAttributesUpdateV2payload((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "checkoutCompleteFree":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new CheckoutCompleteFreePayload((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "checkoutCompleteWithCreditCard":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new CheckoutCompleteWithCreditCardPayload((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "checkoutCompleteWithCreditCardV2":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new CheckoutCompleteWithCreditCardV2payload((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "checkoutCompleteWithTokenizedPayment":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new CheckoutCompleteWithTokenizedPaymentPayload((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "checkoutCompleteWithTokenizedPaymentV2":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new CheckoutCompleteWithTokenizedPaymentV2payload((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "checkoutCreate":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new CheckoutCreatePayload((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "checkoutCustomerAssociate":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new CheckoutCustomerAssociatePayload((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "checkoutCustomerAssociateV2":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new CheckoutCustomerAssociateV2payload((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "checkoutCustomerDisassociate":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new CheckoutCustomerDisassociatePayload((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "checkoutCustomerDisassociateV2":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new CheckoutCustomerDisassociateV2payload((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "checkoutDiscountCodeApply":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new CheckoutDiscountCodeApplyPayload((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "checkoutDiscountCodeApplyV2":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new CheckoutDiscountCodeApplyV2payload((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "checkoutDiscountCodeRemove":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new CheckoutDiscountCodeRemovePayload((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "checkoutEmailUpdate":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new CheckoutEmailUpdatePayload((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "checkoutEmailUpdateV2":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new CheckoutEmailUpdateV2payload((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "checkoutGiftCardApply":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new CheckoutGiftCardApplyPayload((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "checkoutGiftCardRemove":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new CheckoutGiftCardRemovePayload((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "checkoutGiftCardRemoveV2":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new CheckoutGiftCardRemoveV2payload((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "checkoutGiftCardsAppend":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new CheckoutGiftCardsAppendPayload((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "checkoutLineItemsAdd":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new CheckoutLineItemsAddPayload((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "checkoutLineItemsRemove":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new CheckoutLineItemsRemovePayload((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "checkoutLineItemsReplace":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new CheckoutLineItemsReplacePayload((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "checkoutLineItemsUpdate":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new CheckoutLineItemsUpdatePayload((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "checkoutShippingAddressUpdate":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new CheckoutShippingAddressUpdatePayload((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "checkoutShippingAddressUpdateV2":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new CheckoutShippingAddressUpdateV2payload((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "checkoutShippingLineUpdate":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new CheckoutShippingLineUpdatePayload((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "customerAccessTokenCreate":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new CustomerAccessTokenCreatePayload((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "customerAccessTokenDelete":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new CustomerAccessTokenDeletePayload((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "customerAccessTokenRenew":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new CustomerAccessTokenRenewPayload((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "customerActivate":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new CustomerActivatePayload((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "customerAddressCreate":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new CustomerAddressCreatePayload((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "customerAddressDelete":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new CustomerAddressDeletePayload((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "customerAddressUpdate":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new CustomerAddressUpdatePayload((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "customerCreate":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new CustomerCreatePayload((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "customerDefaultAddressUpdate":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new CustomerDefaultAddressUpdatePayload((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "customerRecover":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new CustomerRecoverPayload((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "customerReset":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new CustomerResetPayload((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "customerResetByUrl":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new CustomerResetByUrlPayload((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "customerUpdate":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new CustomerUpdatePayload((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;
                }
            }
        }

        /// \deprecated Use `checkoutAttributesUpdateV2` instead
        /// <summary>
        /// Updates the attributes of a checkout.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public CheckoutAttributesUpdatePayload checkoutAttributesUpdate(string alias = null) {
            return Get<CheckoutAttributesUpdatePayload>("checkoutAttributesUpdate", alias);
        }

        /// <summary>
        /// Updates the attributes of a checkout.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public CheckoutAttributesUpdateV2payload checkoutAttributesUpdateV2(string alias = null) {
            return Get<CheckoutAttributesUpdateV2payload>("checkoutAttributesUpdateV2", alias);
        }

        /// <summary>
        /// Completes a checkout without providing payment information. You can use this mutation for free items or items whose purchase price is covered by a gift card.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public CheckoutCompleteFreePayload checkoutCompleteFree(string alias = null) {
            return Get<CheckoutCompleteFreePayload>("checkoutCompleteFree", alias);
        }

        /// \deprecated Use `checkoutCompleteWithCreditCardV2` instead
        /// <summary>
        /// Completes a checkout using a credit card token from Shopify's Vault.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public CheckoutCompleteWithCreditCardPayload checkoutCompleteWithCreditCard(string alias = null) {
            return Get<CheckoutCompleteWithCreditCardPayload>("checkoutCompleteWithCreditCard", alias);
        }

        /// <summary>
        /// Completes a checkout using a credit card token from Shopify's card vault. Before you can complete checkouts using CheckoutCompleteWithCreditCardV2, you need to  [_request payment processing_](https://help.shopify.com/api/guides/sales-channel-sdk/getting-started#request-payment-processing).
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public CheckoutCompleteWithCreditCardV2payload checkoutCompleteWithCreditCardV2(string alias = null) {
            return Get<CheckoutCompleteWithCreditCardV2payload>("checkoutCompleteWithCreditCardV2", alias);
        }

        /// \deprecated Use `checkoutCompleteWithTokenizedPaymentV2` instead
        /// <summary>
        /// Completes a checkout with a tokenized payment.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public CheckoutCompleteWithTokenizedPaymentPayload checkoutCompleteWithTokenizedPayment(string alias = null) {
            return Get<CheckoutCompleteWithTokenizedPaymentPayload>("checkoutCompleteWithTokenizedPayment", alias);
        }

        /// \deprecated Use `checkoutCompleteWithTokenizedPaymentV3` instead
        /// <summary>
        /// Completes a checkout with a tokenized payment.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public CheckoutCompleteWithTokenizedPaymentV2payload checkoutCompleteWithTokenizedPaymentV2(string alias = null) {
            return Get<CheckoutCompleteWithTokenizedPaymentV2payload>("checkoutCompleteWithTokenizedPaymentV2", alias);
        }

        /// <summary>
        /// Creates a new checkout.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public CheckoutCreatePayload checkoutCreate(string alias = null) {
            return Get<CheckoutCreatePayload>("checkoutCreate", alias);
        }

        /// \deprecated Use `checkoutCustomerAssociateV2` instead
        /// <summary>
        /// Associates a customer to the checkout.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public CheckoutCustomerAssociatePayload checkoutCustomerAssociate(string alias = null) {
            return Get<CheckoutCustomerAssociatePayload>("checkoutCustomerAssociate", alias);
        }

        /// <summary>
        /// Associates a customer to the checkout.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public CheckoutCustomerAssociateV2payload checkoutCustomerAssociateV2(string alias = null) {
            return Get<CheckoutCustomerAssociateV2payload>("checkoutCustomerAssociateV2", alias);
        }

        /// \deprecated Use `checkoutCustomerDisassociateV2` instead
        /// <summary>
        /// Disassociates the current checkout customer from the checkout.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public CheckoutCustomerDisassociatePayload checkoutCustomerDisassociate(string alias = null) {
            return Get<CheckoutCustomerDisassociatePayload>("checkoutCustomerDisassociate", alias);
        }

        /// <summary>
        /// Disassociates the current checkout customer from the checkout.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public CheckoutCustomerDisassociateV2payload checkoutCustomerDisassociateV2(string alias = null) {
            return Get<CheckoutCustomerDisassociateV2payload>("checkoutCustomerDisassociateV2", alias);
        }

        /// \deprecated Use `checkoutDiscountCodeApplyV2` instead
        /// <summary>
        /// Applies a discount to an existing checkout using a discount code.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public CheckoutDiscountCodeApplyPayload checkoutDiscountCodeApply(string alias = null) {
            return Get<CheckoutDiscountCodeApplyPayload>("checkoutDiscountCodeApply", alias);
        }

        /// <summary>
        /// Applies a discount to an existing checkout using a discount code.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public CheckoutDiscountCodeApplyV2payload checkoutDiscountCodeApplyV2(string alias = null) {
            return Get<CheckoutDiscountCodeApplyV2payload>("checkoutDiscountCodeApplyV2", alias);
        }

        /// <summary>
        /// Removes the applied discount from an existing checkout.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public CheckoutDiscountCodeRemovePayload checkoutDiscountCodeRemove(string alias = null) {
            return Get<CheckoutDiscountCodeRemovePayload>("checkoutDiscountCodeRemove", alias);
        }

        /// \deprecated Use `checkoutEmailUpdateV2` instead
        /// <summary>
        /// Updates the email on an existing checkout.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public CheckoutEmailUpdatePayload checkoutEmailUpdate(string alias = null) {
            return Get<CheckoutEmailUpdatePayload>("checkoutEmailUpdate", alias);
        }

        /// <summary>
        /// Updates the email on an existing checkout.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public CheckoutEmailUpdateV2payload checkoutEmailUpdateV2(string alias = null) {
            return Get<CheckoutEmailUpdateV2payload>("checkoutEmailUpdateV2", alias);
        }

        /// \deprecated Use `checkoutGiftCardsAppend` instead
        /// <summary>
        /// Applies a gift card to an existing checkout using a gift card code. This will replace all currently applied gift cards.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public CheckoutGiftCardApplyPayload checkoutGiftCardApply(string alias = null) {
            return Get<CheckoutGiftCardApplyPayload>("checkoutGiftCardApply", alias);
        }

        /// \deprecated Use `checkoutGiftCardRemoveV2` instead
        /// <summary>
        /// Removes an applied gift card from the checkout.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public CheckoutGiftCardRemovePayload checkoutGiftCardRemove(string alias = null) {
            return Get<CheckoutGiftCardRemovePayload>("checkoutGiftCardRemove", alias);
        }

        /// <summary>
        /// Removes an applied gift card from the checkout.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public CheckoutGiftCardRemoveV2payload checkoutGiftCardRemoveV2(string alias = null) {
            return Get<CheckoutGiftCardRemoveV2payload>("checkoutGiftCardRemoveV2", alias);
        }

        /// <summary>
        /// Appends gift cards to an existing checkout.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public CheckoutGiftCardsAppendPayload checkoutGiftCardsAppend(string alias = null) {
            return Get<CheckoutGiftCardsAppendPayload>("checkoutGiftCardsAppend", alias);
        }

        /// <summary>
        /// Adds a list of line items to a checkout.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public CheckoutLineItemsAddPayload checkoutLineItemsAdd(string alias = null) {
            return Get<CheckoutLineItemsAddPayload>("checkoutLineItemsAdd", alias);
        }

        /// <summary>
        /// Removes line items from an existing checkout.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public CheckoutLineItemsRemovePayload checkoutLineItemsRemove(string alias = null) {
            return Get<CheckoutLineItemsRemovePayload>("checkoutLineItemsRemove", alias);
        }

        /// <summary>
        /// Sets a list of line items to a checkout.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public CheckoutLineItemsReplacePayload checkoutLineItemsReplace(string alias = null) {
            return Get<CheckoutLineItemsReplacePayload>("checkoutLineItemsReplace", alias);
        }

        /// <summary>
        /// Updates line items on a checkout.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public CheckoutLineItemsUpdatePayload checkoutLineItemsUpdate(string alias = null) {
            return Get<CheckoutLineItemsUpdatePayload>("checkoutLineItemsUpdate", alias);
        }

        /// \deprecated Use `checkoutShippingAddressUpdateV2` instead
        /// <summary>
        /// Updates the shipping address of an existing checkout.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public CheckoutShippingAddressUpdatePayload checkoutShippingAddressUpdate(string alias = null) {
            return Get<CheckoutShippingAddressUpdatePayload>("checkoutShippingAddressUpdate", alias);
        }

        /// <summary>
        /// Updates the shipping address of an existing checkout.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public CheckoutShippingAddressUpdateV2payload checkoutShippingAddressUpdateV2(string alias = null) {
            return Get<CheckoutShippingAddressUpdateV2payload>("checkoutShippingAddressUpdateV2", alias);
        }

        /// <summary>
        /// Updates the shipping lines on an existing checkout.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public CheckoutShippingLineUpdatePayload checkoutShippingLineUpdate(string alias = null) {
            return Get<CheckoutShippingLineUpdatePayload>("checkoutShippingLineUpdate", alias);
        }

        /// <summary>
        /// Creates a customer access token.
        /// The customer access token is required to modify the customer object in any way.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public CustomerAccessTokenCreatePayload customerAccessTokenCreate(string alias = null) {
            return Get<CustomerAccessTokenCreatePayload>("customerAccessTokenCreate", alias);
        }

        /// <summary>
        /// Permanently destroys a customer access token.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public CustomerAccessTokenDeletePayload customerAccessTokenDelete(string alias = null) {
            return Get<CustomerAccessTokenDeletePayload>("customerAccessTokenDelete", alias);
        }

        /// <summary>
        /// Renews a customer access token.
        /// 
        /// Access token renewal must happen *before* a token expires.
        /// If a token has already expired, a new one should be created instead via `customerAccessTokenCreate`.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public CustomerAccessTokenRenewPayload customerAccessTokenRenew(string alias = null) {
            return Get<CustomerAccessTokenRenewPayload>("customerAccessTokenRenew", alias);
        }

        /// <summary>
        /// Activates a customer.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public CustomerActivatePayload customerActivate(string alias = null) {
            return Get<CustomerActivatePayload>("customerActivate", alias);
        }

        /// <summary>
        /// Creates a new address for a customer.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public CustomerAddressCreatePayload customerAddressCreate(string alias = null) {
            return Get<CustomerAddressCreatePayload>("customerAddressCreate", alias);
        }

        /// <summary>
        /// Permanently deletes the address of an existing customer.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public CustomerAddressDeletePayload customerAddressDelete(string alias = null) {
            return Get<CustomerAddressDeletePayload>("customerAddressDelete", alias);
        }

        /// <summary>
        /// Updates the address of an existing customer.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public CustomerAddressUpdatePayload customerAddressUpdate(string alias = null) {
            return Get<CustomerAddressUpdatePayload>("customerAddressUpdate", alias);
        }

        /// <summary>
        /// Creates a new customer.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public CustomerCreatePayload customerCreate(string alias = null) {
            return Get<CustomerCreatePayload>("customerCreate", alias);
        }

        /// <summary>
        /// Updates the default address of an existing customer.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public CustomerDefaultAddressUpdatePayload customerDefaultAddressUpdate(string alias = null) {
            return Get<CustomerDefaultAddressUpdatePayload>("customerDefaultAddressUpdate", alias);
        }

        /// <summary>
        /// Sends a reset password email to the customer, as the first step in the reset password process.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public CustomerRecoverPayload customerRecover(string alias = null) {
            return Get<CustomerRecoverPayload>("customerRecover", alias);
        }

        /// <summary>
        /// Resets a customer’s password with a token received from `CustomerRecover`.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public CustomerResetPayload customerReset(string alias = null) {
            return Get<CustomerResetPayload>("customerReset", alias);
        }

        /// <summary>
        /// Resets a customer’s password with the reset password url received from `CustomerRecover`.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public CustomerResetByUrlPayload customerResetByUrl(string alias = null) {
            return Get<CustomerResetByUrlPayload>("customerResetByUrl", alias);
        }

        /// <summary>
        /// Updates an existing customer.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public CustomerUpdatePayload customerUpdate(string alias = null) {
            return Get<CustomerUpdatePayload>("customerUpdate", alias);
        }

        public object Clone() {
            return new Mutation(DataJSON);
        }

        private static List<Node> DataToNodeList(object data) {
            var objects = (List<object>)data;
            var nodes = new List<Node>();

            foreach (var obj in objects) {
                if (obj == null) continue;
                nodes.Add(UnknownNode.Create((Dictionary<string,object>) obj));
            }

            return nodes;
        }
    }
    }
