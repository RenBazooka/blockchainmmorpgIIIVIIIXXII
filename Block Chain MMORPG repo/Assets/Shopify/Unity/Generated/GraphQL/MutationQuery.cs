namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void MutationDelegate(MutationQuery query);

    /// <summary>
    /// <see cref="MutationQuery" /> is the root mutation builder. All Storefront API mutation queries are built off of <see cref="MutationQuery" />.
    /// </summary>
    public class MutationQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="MutationQuery" /> constructor accepts no parameters but it will create a root
        /// mutation builder.
        /// </summary>
        public MutationQuery() {
            Query = new StringBuilder("mutation{");
        }

        /// \deprecated Use `checkoutAttributesUpdateV2` instead
        /// <summary>
        /// Updates the attributes of a checkout.
        /// </summary>
        /// <param name="checkoutId">
        /// The ID of the checkout.
        /// </param>
        /// <param name="input">
        /// The fields used to update a checkout's attributes.
        /// </param>
        public MutationQuery checkoutAttributesUpdate(CheckoutAttributesUpdatePayloadDelegate buildQuery,string checkoutId,CheckoutAttributesUpdateInput input,string alias = null) {
            Log.DeprecatedQueryField("Mutation", "checkoutAttributesUpdate", "Use `checkoutAttributesUpdateV2` instead");

            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("checkoutAttributesUpdate___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("checkoutAttributesUpdate ");

            Arguments args = new Arguments();

            args.Add("checkoutId", checkoutId);

            args.Add("input", input);

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new CheckoutAttributesUpdatePayloadQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Updates the attributes of a checkout.
        /// </summary>
        /// <param name="checkoutId">
        /// The ID of the checkout.
        /// </param>
        /// <param name="input">
        /// The checkout attributes to update.
        /// </param>
        public MutationQuery checkoutAttributesUpdateV2(CheckoutAttributesUpdateV2payloadDelegate buildQuery,string checkoutId,CheckoutAttributesUpdateV2input input,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("checkoutAttributesUpdateV2___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("checkoutAttributesUpdateV2 ");

            Arguments args = new Arguments();

            args.Add("checkoutId", checkoutId);

            args.Add("input", input);

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new CheckoutAttributesUpdateV2payloadQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Completes a checkout without providing payment information. You can use this mutation for free items or items whose purchase price is covered by a gift card.
        /// </summary>
        /// <param name="checkoutId">
        /// The ID of the checkout.
        /// </param>
        public MutationQuery checkoutCompleteFree(CheckoutCompleteFreePayloadDelegate buildQuery,string checkoutId,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("checkoutCompleteFree___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("checkoutCompleteFree ");

            Arguments args = new Arguments();

            args.Add("checkoutId", checkoutId);

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new CheckoutCompleteFreePayloadQuery(Query));
            Query.Append("}");

            return this;
        }

        /// \deprecated Use `checkoutCompleteWithCreditCardV2` instead
        /// <summary>
        /// Completes a checkout using a credit card token from Shopify's Vault.
        /// </summary>
        /// <param name="checkoutId">
        /// The ID of the checkout.
        /// </param>
        /// <param name="payment">
        /// The credit card info to apply as a payment.
        /// </param>
        public MutationQuery checkoutCompleteWithCreditCard(CheckoutCompleteWithCreditCardPayloadDelegate buildQuery,string checkoutId,CreditCardPaymentInput payment,string alias = null) {
            Log.DeprecatedQueryField("Mutation", "checkoutCompleteWithCreditCard", "Use `checkoutCompleteWithCreditCardV2` instead");

            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("checkoutCompleteWithCreditCard___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("checkoutCompleteWithCreditCard ");

            Arguments args = new Arguments();

            args.Add("checkoutId", checkoutId);

            args.Add("payment", payment);

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new CheckoutCompleteWithCreditCardPayloadQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Completes a checkout using a credit card token from Shopify's card vault. Before you can complete checkouts using CheckoutCompleteWithCreditCardV2, you need to  [_request payment processing_](https://help.shopify.com/api/guides/sales-channel-sdk/getting-started#request-payment-processing).
        /// </summary>
        /// <param name="checkoutId">
        /// The ID of the checkout.
        /// </param>
        /// <param name="payment">
        /// The credit card info to apply as a payment.
        /// </param>
        public MutationQuery checkoutCompleteWithCreditCardV2(CheckoutCompleteWithCreditCardV2payloadDelegate buildQuery,string checkoutId,CreditCardPaymentInputV2 payment,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("checkoutCompleteWithCreditCardV2___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("checkoutCompleteWithCreditCardV2 ");

            Arguments args = new Arguments();

            args.Add("checkoutId", checkoutId);

            args.Add("payment", payment);

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new CheckoutCompleteWithCreditCardV2payloadQuery(Query));
            Query.Append("}");

            return this;
        }

        /// \deprecated Use `checkoutCompleteWithTokenizedPaymentV2` instead
        /// <summary>
        /// Completes a checkout with a tokenized payment.
        /// </summary>
        /// <param name="checkoutId">
        /// The ID of the checkout.
        /// </param>
        /// <param name="payment">
        /// The info to apply as a tokenized payment.
        /// </param>
        public MutationQuery checkoutCompleteWithTokenizedPayment(CheckoutCompleteWithTokenizedPaymentPayloadDelegate buildQuery,string checkoutId,TokenizedPaymentInput payment,string alias = null) {
            Log.DeprecatedQueryField("Mutation", "checkoutCompleteWithTokenizedPayment", "Use `checkoutCompleteWithTokenizedPaymentV2` instead");

            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("checkoutCompleteWithTokenizedPayment___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("checkoutCompleteWithTokenizedPayment ");

            Arguments args = new Arguments();

            args.Add("checkoutId", checkoutId);

            args.Add("payment", payment);

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new CheckoutCompleteWithTokenizedPaymentPayloadQuery(Query));
            Query.Append("}");

            return this;
        }

        /// \deprecated Use `checkoutCompleteWithTokenizedPaymentV3` instead
        /// <summary>
        /// Completes a checkout with a tokenized payment.
        /// </summary>
        /// <param name="checkoutId">
        /// The ID of the checkout.
        /// </param>
        /// <param name="payment">
        /// The info to apply as a tokenized payment.
        /// </param>
        public MutationQuery checkoutCompleteWithTokenizedPaymentV2(CheckoutCompleteWithTokenizedPaymentV2payloadDelegate buildQuery,string checkoutId,TokenizedPaymentInputV2 payment,string alias = null) {
            Log.DeprecatedQueryField("Mutation", "checkoutCompleteWithTokenizedPaymentV2", "Use `checkoutCompleteWithTokenizedPaymentV3` instead");

            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("checkoutCompleteWithTokenizedPaymentV2___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("checkoutCompleteWithTokenizedPaymentV2 ");

            Arguments args = new Arguments();

            args.Add("checkoutId", checkoutId);

            args.Add("payment", payment);

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new CheckoutCompleteWithTokenizedPaymentV2payloadQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Creates a new checkout.
        /// </summary>
        /// <param name="input">
        /// The fields used to create a checkout.
        /// </param>
        public MutationQuery checkoutCreate(CheckoutCreatePayloadDelegate buildQuery,CheckoutCreateInput input,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("checkoutCreate___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("checkoutCreate ");

            Arguments args = new Arguments();

            args.Add("input", input);

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new CheckoutCreatePayloadQuery(Query));
            Query.Append("}");

            return this;
        }

        /// \deprecated Use `checkoutCustomerAssociateV2` instead
        /// <summary>
        /// Associates a customer to the checkout.
        /// </summary>
        /// <param name="checkoutId">
        /// The ID of the checkout.
        /// </param>
        /// <param name="customerAccessToken">
        /// The customer access token of the customer to associate.
        /// </param>
        public MutationQuery checkoutCustomerAssociate(CheckoutCustomerAssociatePayloadDelegate buildQuery,string checkoutId,string customerAccessToken,string alias = null) {
            Log.DeprecatedQueryField("Mutation", "checkoutCustomerAssociate", "Use `checkoutCustomerAssociateV2` instead");

            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("checkoutCustomerAssociate___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("checkoutCustomerAssociate ");

            Arguments args = new Arguments();

            args.Add("checkoutId", checkoutId);

            args.Add("customerAccessToken", customerAccessToken);

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new CheckoutCustomerAssociatePayloadQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Associates a customer to the checkout.
        /// </summary>
        /// <param name="checkoutId">
        /// The ID of the checkout.
        /// </param>
        /// <param name="customerAccessToken">
        /// The customer access token of the customer to associate.
        /// </param>
        public MutationQuery checkoutCustomerAssociateV2(CheckoutCustomerAssociateV2payloadDelegate buildQuery,string checkoutId,string customerAccessToken,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("checkoutCustomerAssociateV2___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("checkoutCustomerAssociateV2 ");

            Arguments args = new Arguments();

            args.Add("checkoutId", checkoutId);

            args.Add("customerAccessToken", customerAccessToken);

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new CheckoutCustomerAssociateV2payloadQuery(Query));
            Query.Append("}");

            return this;
        }

        /// \deprecated Use `checkoutCustomerDisassociateV2` instead
        /// <summary>
        /// Disassociates the current checkout customer from the checkout.
        /// </summary>
        /// <param name="checkoutId">
        /// The ID of the checkout.
        /// </param>
        public MutationQuery checkoutCustomerDisassociate(CheckoutCustomerDisassociatePayloadDelegate buildQuery,string checkoutId,string alias = null) {
            Log.DeprecatedQueryField("Mutation", "checkoutCustomerDisassociate", "Use `checkoutCustomerDisassociateV2` instead");

            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("checkoutCustomerDisassociate___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("checkoutCustomerDisassociate ");

            Arguments args = new Arguments();

            args.Add("checkoutId", checkoutId);

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new CheckoutCustomerDisassociatePayloadQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Disassociates the current checkout customer from the checkout.
        /// </summary>
        /// <param name="checkoutId">
        /// The ID of the checkout.
        /// </param>
        public MutationQuery checkoutCustomerDisassociateV2(CheckoutCustomerDisassociateV2payloadDelegate buildQuery,string checkoutId,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("checkoutCustomerDisassociateV2___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("checkoutCustomerDisassociateV2 ");

            Arguments args = new Arguments();

            args.Add("checkoutId", checkoutId);

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new CheckoutCustomerDisassociateV2payloadQuery(Query));
            Query.Append("}");

            return this;
        }

        /// \deprecated Use `checkoutDiscountCodeApplyV2` instead
        /// <summary>
        /// Applies a discount to an existing checkout using a discount code.
        /// </summary>
        /// <param name="discountCode">
        /// The discount code to apply to the checkout.
        /// </param>
        /// <param name="checkoutId">
        /// The ID of the checkout.
        /// </param>
        public MutationQuery checkoutDiscountCodeApply(CheckoutDiscountCodeApplyPayloadDelegate buildQuery,string discountCode,string checkoutId,string alias = null) {
            Log.DeprecatedQueryField("Mutation", "checkoutDiscountCodeApply", "Use `checkoutDiscountCodeApplyV2` instead");

            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("checkoutDiscountCodeApply___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("checkoutDiscountCodeApply ");

            Arguments args = new Arguments();

            args.Add("discountCode", discountCode);

            args.Add("checkoutId", checkoutId);

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new CheckoutDiscountCodeApplyPayloadQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Applies a discount to an existing checkout using a discount code.
        /// </summary>
        /// <param name="discountCode">
        /// The discount code to apply to the checkout.
        /// </param>
        /// <param name="checkoutId">
        /// The ID of the checkout.
        /// </param>
        public MutationQuery checkoutDiscountCodeApplyV2(CheckoutDiscountCodeApplyV2payloadDelegate buildQuery,string discountCode,string checkoutId,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("checkoutDiscountCodeApplyV2___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("checkoutDiscountCodeApplyV2 ");

            Arguments args = new Arguments();

            args.Add("discountCode", discountCode);

            args.Add("checkoutId", checkoutId);

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new CheckoutDiscountCodeApplyV2payloadQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Removes the applied discount from an existing checkout.
        /// </summary>
        /// <param name="checkoutId">
        /// The ID of the checkout.
        /// </param>
        public MutationQuery checkoutDiscountCodeRemove(CheckoutDiscountCodeRemovePayloadDelegate buildQuery,string checkoutId,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("checkoutDiscountCodeRemove___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("checkoutDiscountCodeRemove ");

            Arguments args = new Arguments();

            args.Add("checkoutId", checkoutId);

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new CheckoutDiscountCodeRemovePayloadQuery(Query));
            Query.Append("}");

            return this;
        }

        /// \deprecated Use `checkoutEmailUpdateV2` instead
        /// <summary>
        /// Updates the email on an existing checkout.
        /// </summary>
        /// <param name="checkoutId">
        /// The ID of the checkout.
        /// </param>
        /// <param name="email">
        /// The email to update the checkout with.
        /// </param>
        public MutationQuery checkoutEmailUpdate(CheckoutEmailUpdatePayloadDelegate buildQuery,string checkoutId,string email,string alias = null) {
            Log.DeprecatedQueryField("Mutation", "checkoutEmailUpdate", "Use `checkoutEmailUpdateV2` instead");

            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("checkoutEmailUpdate___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("checkoutEmailUpdate ");

            Arguments args = new Arguments();

            args.Add("checkoutId", checkoutId);

            args.Add("email", email);

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new CheckoutEmailUpdatePayloadQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Updates the email on an existing checkout.
        /// </summary>
        /// <param name="checkoutId">
        /// The ID of the checkout.
        /// </param>
        /// <param name="email">
        /// The email to update the checkout with.
        /// </param>
        public MutationQuery checkoutEmailUpdateV2(CheckoutEmailUpdateV2payloadDelegate buildQuery,string checkoutId,string email,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("checkoutEmailUpdateV2___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("checkoutEmailUpdateV2 ");

            Arguments args = new Arguments();

            args.Add("checkoutId", checkoutId);

            args.Add("email", email);

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new CheckoutEmailUpdateV2payloadQuery(Query));
            Query.Append("}");

            return this;
        }

        /// \deprecated Use `checkoutGiftCardsAppend` instead
        /// <summary>
        /// Applies a gift card to an existing checkout using a gift card code. This will replace all currently applied gift cards.
        /// </summary>
        /// <param name="giftCardCode">
        /// The code of the gift card to apply on the checkout.
        /// </param>
        /// <param name="checkoutId">
        /// The ID of the checkout.
        /// </param>
        public MutationQuery checkoutGiftCardApply(CheckoutGiftCardApplyPayloadDelegate buildQuery,string giftCardCode,string checkoutId,string alias = null) {
            Log.DeprecatedQueryField("Mutation", "checkoutGiftCardApply", "Use `checkoutGiftCardsAppend` instead");

            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("checkoutGiftCardApply___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("checkoutGiftCardApply ");

            Arguments args = new Arguments();

            args.Add("giftCardCode", giftCardCode);

            args.Add("checkoutId", checkoutId);

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new CheckoutGiftCardApplyPayloadQuery(Query));
            Query.Append("}");

            return this;
        }

        /// \deprecated Use `checkoutGiftCardRemoveV2` instead
        /// <summary>
        /// Removes an applied gift card from the checkout.
        /// </summary>
        /// <param name="appliedGiftCardId">
        /// The ID of the Applied Gift Card to remove from the Checkout.
        /// </param>
        /// <param name="checkoutId">
        /// The ID of the checkout.
        /// </param>
        public MutationQuery checkoutGiftCardRemove(CheckoutGiftCardRemovePayloadDelegate buildQuery,string appliedGiftCardId,string checkoutId,string alias = null) {
            Log.DeprecatedQueryField("Mutation", "checkoutGiftCardRemove", "Use `checkoutGiftCardRemoveV2` instead");

            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("checkoutGiftCardRemove___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("checkoutGiftCardRemove ");

            Arguments args = new Arguments();

            args.Add("appliedGiftCardId", appliedGiftCardId);

            args.Add("checkoutId", checkoutId);

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new CheckoutGiftCardRemovePayloadQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Removes an applied gift card from the checkout.
        /// </summary>
        /// <param name="appliedGiftCardId">
        /// The ID of the Applied Gift Card to remove from the Checkout.
        /// </param>
        /// <param name="checkoutId">
        /// The ID of the checkout.
        /// </param>
        public MutationQuery checkoutGiftCardRemoveV2(CheckoutGiftCardRemoveV2payloadDelegate buildQuery,string appliedGiftCardId,string checkoutId,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("checkoutGiftCardRemoveV2___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("checkoutGiftCardRemoveV2 ");

            Arguments args = new Arguments();

            args.Add("appliedGiftCardId", appliedGiftCardId);

            args.Add("checkoutId", checkoutId);

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new CheckoutGiftCardRemoveV2payloadQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Appends gift cards to an existing checkout.
        /// </summary>
        /// <param name="giftCardCodes">
        /// A list of gift card codes to append to the checkout.
        /// </param>
        /// <param name="checkoutId">
        /// The ID of the checkout.
        /// </param>
        public MutationQuery checkoutGiftCardsAppend(CheckoutGiftCardsAppendPayloadDelegate buildQuery,List<string> giftCardCodes,string checkoutId,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("checkoutGiftCardsAppend___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("checkoutGiftCardsAppend ");

            Arguments args = new Arguments();

            args.Add("giftCardCodes", giftCardCodes);

            args.Add("checkoutId", checkoutId);

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new CheckoutGiftCardsAppendPayloadQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Adds a list of line items to a checkout.
        /// </summary>
        /// <param name="lineItems">
        /// A list of line item objects to add to the checkout.
        /// </param>
        /// <param name="checkoutId">
        /// The ID of the checkout.
        /// </param>
        public MutationQuery checkoutLineItemsAdd(CheckoutLineItemsAddPayloadDelegate buildQuery,List<CheckoutLineItemInput> lineItems,string checkoutId,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("checkoutLineItemsAdd___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("checkoutLineItemsAdd ");

            Arguments args = new Arguments();

            args.Add("lineItems", lineItems);

            args.Add("checkoutId", checkoutId);

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new CheckoutLineItemsAddPayloadQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Removes line items from an existing checkout.
        /// </summary>
        /// <param name="checkoutId">
        /// The checkout on which to remove line items.
        /// </param>
        /// <param name="lineItemIds">
        /// Line item ids to remove.
        /// </param>
        public MutationQuery checkoutLineItemsRemove(CheckoutLineItemsRemovePayloadDelegate buildQuery,string checkoutId,List<string> lineItemIds,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("checkoutLineItemsRemove___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("checkoutLineItemsRemove ");

            Arguments args = new Arguments();

            args.Add("checkoutId", checkoutId);

            args.Add("lineItemIds", lineItemIds);

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new CheckoutLineItemsRemovePayloadQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Sets a list of line items to a checkout.
        /// </summary>
        /// <param name="lineItems">
        /// A list of line item objects to set on the checkout.
        /// </param>
        /// <param name="checkoutId">
        /// The ID of the checkout.
        /// </param>
        public MutationQuery checkoutLineItemsReplace(CheckoutLineItemsReplacePayloadDelegate buildQuery,List<CheckoutLineItemInput> lineItems,string checkoutId,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("checkoutLineItemsReplace___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("checkoutLineItemsReplace ");

            Arguments args = new Arguments();

            args.Add("lineItems", lineItems);

            args.Add("checkoutId", checkoutId);

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new CheckoutLineItemsReplacePayloadQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Updates line items on a checkout.
        /// </summary>
        /// <param name="checkoutId">
        /// The checkout on which to update line items.
        /// </param>
        /// <param name="lineItems">
        /// Line items to update.
        /// </param>
        public MutationQuery checkoutLineItemsUpdate(CheckoutLineItemsUpdatePayloadDelegate buildQuery,string checkoutId,List<CheckoutLineItemUpdateInput> lineItems,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("checkoutLineItemsUpdate___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("checkoutLineItemsUpdate ");

            Arguments args = new Arguments();

            args.Add("checkoutId", checkoutId);

            args.Add("lineItems", lineItems);

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new CheckoutLineItemsUpdatePayloadQuery(Query));
            Query.Append("}");

            return this;
        }

        /// \deprecated Use `checkoutShippingAddressUpdateV2` instead
        /// <summary>
        /// Updates the shipping address of an existing checkout.
        /// </summary>
        /// <param name="shippingAddress">
        /// The shipping address to where the line items will be shipped.
        /// </param>
        /// <param name="checkoutId">
        /// The ID of the checkout.
        /// </param>
        public MutationQuery checkoutShippingAddressUpdate(CheckoutShippingAddressUpdatePayloadDelegate buildQuery,MailingAddressInput shippingAddress,string checkoutId,string alias = null) {
            Log.DeprecatedQueryField("Mutation", "checkoutShippingAddressUpdate", "Use `checkoutShippingAddressUpdateV2` instead");

            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("checkoutShippingAddressUpdate___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("checkoutShippingAddressUpdate ");

            Arguments args = new Arguments();

            args.Add("shippingAddress", shippingAddress);

            args.Add("checkoutId", checkoutId);

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new CheckoutShippingAddressUpdatePayloadQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Updates the shipping address of an existing checkout.
        /// </summary>
        /// <param name="shippingAddress">
        /// The shipping address to where the line items will be shipped.
        /// </param>
        /// <param name="checkoutId">
        /// The ID of the checkout.
        /// </param>
        public MutationQuery checkoutShippingAddressUpdateV2(CheckoutShippingAddressUpdateV2payloadDelegate buildQuery,MailingAddressInput shippingAddress,string checkoutId,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("checkoutShippingAddressUpdateV2___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("checkoutShippingAddressUpdateV2 ");

            Arguments args = new Arguments();

            args.Add("shippingAddress", shippingAddress);

            args.Add("checkoutId", checkoutId);

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new CheckoutShippingAddressUpdateV2payloadQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Updates the shipping lines on an existing checkout.
        /// </summary>
        /// <param name="checkoutId">
        /// The ID of the checkout.
        /// </param>
        /// <param name="shippingRateHandle">
        /// A unique identifier to a Checkout’s shipping provider, price, and title combination, enabling the customer to select the availableShippingRates.
        /// </param>
        public MutationQuery checkoutShippingLineUpdate(CheckoutShippingLineUpdatePayloadDelegate buildQuery,string checkoutId,string shippingRateHandle,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("checkoutShippingLineUpdate___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("checkoutShippingLineUpdate ");

            Arguments args = new Arguments();

            args.Add("checkoutId", checkoutId);

            args.Add("shippingRateHandle", shippingRateHandle);

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new CheckoutShippingLineUpdatePayloadQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Creates a customer access token.
        /// The customer access token is required to modify the customer object in any way.
        /// </summary>
        /// <param name="input">
        /// The fields used to create a customer access token.
        /// </param>
        public MutationQuery customerAccessTokenCreate(CustomerAccessTokenCreatePayloadDelegate buildQuery,CustomerAccessTokenCreateInput input,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("customerAccessTokenCreate___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("customerAccessTokenCreate ");

            Arguments args = new Arguments();

            args.Add("input", input);

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new CustomerAccessTokenCreatePayloadQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Permanently destroys a customer access token.
        /// </summary>
        /// <param name="customerAccessToken">
        /// The access token used to identify the customer.
        /// </param>
        public MutationQuery customerAccessTokenDelete(CustomerAccessTokenDeletePayloadDelegate buildQuery,string customerAccessToken,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("customerAccessTokenDelete___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("customerAccessTokenDelete ");

            Arguments args = new Arguments();

            args.Add("customerAccessToken", customerAccessToken);

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new CustomerAccessTokenDeletePayloadQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Renews a customer access token.
        /// 
        /// Access token renewal must happen *before* a token expires.
        /// If a token has already expired, a new one should be created instead via `customerAccessTokenCreate`.
        /// </summary>
        /// <param name="customerAccessToken">
        /// The access token used to identify the customer.
        /// </param>
        public MutationQuery customerAccessTokenRenew(CustomerAccessTokenRenewPayloadDelegate buildQuery,string customerAccessToken,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("customerAccessTokenRenew___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("customerAccessTokenRenew ");

            Arguments args = new Arguments();

            args.Add("customerAccessToken", customerAccessToken);

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new CustomerAccessTokenRenewPayloadQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Activates a customer.
        /// </summary>
        /// <param name="id">
        /// Specifies the customer to activate.
        /// </param>
        /// <param name="input">
        /// The fields used to activate a customer.
        /// </param>
        public MutationQuery customerActivate(CustomerActivatePayloadDelegate buildQuery,string id,CustomerActivateInput input,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("customerActivate___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("customerActivate ");

            Arguments args = new Arguments();

            args.Add("id", id);

            args.Add("input", input);

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new CustomerActivatePayloadQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Creates a new address for a customer.
        /// </summary>
        /// <param name="customerAccessToken">
        /// The access token used to identify the customer.
        /// </param>
        /// <param name="address">
        /// The customer mailing address to create.
        /// </param>
        public MutationQuery customerAddressCreate(CustomerAddressCreatePayloadDelegate buildQuery,string customerAccessToken,MailingAddressInput address,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("customerAddressCreate___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("customerAddressCreate ");

            Arguments args = new Arguments();

            args.Add("customerAccessToken", customerAccessToken);

            args.Add("address", address);

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new CustomerAddressCreatePayloadQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Permanently deletes the address of an existing customer.
        /// </summary>
        /// <param name="id">
        /// Specifies the address to delete.
        /// </param>
        /// <param name="customerAccessToken">
        /// The access token used to identify the customer.
        /// </param>
        public MutationQuery customerAddressDelete(CustomerAddressDeletePayloadDelegate buildQuery,string id,string customerAccessToken,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("customerAddressDelete___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("customerAddressDelete ");

            Arguments args = new Arguments();

            args.Add("id", id);

            args.Add("customerAccessToken", customerAccessToken);

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new CustomerAddressDeletePayloadQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Updates the address of an existing customer.
        /// </summary>
        /// <param name="customerAccessToken">
        /// The access token used to identify the customer.
        /// </param>
        /// <param name="id">
        /// Specifies the customer address to update.
        /// </param>
        /// <param name="address">
        /// The customer’s mailing address.
        /// </param>
        public MutationQuery customerAddressUpdate(CustomerAddressUpdatePayloadDelegate buildQuery,string customerAccessToken,string id,MailingAddressInput address,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("customerAddressUpdate___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("customerAddressUpdate ");

            Arguments args = new Arguments();

            args.Add("customerAccessToken", customerAccessToken);

            args.Add("id", id);

            args.Add("address", address);

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new CustomerAddressUpdatePayloadQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Creates a new customer.
        /// </summary>
        /// <param name="input">
        /// The fields used to create a new customer.
        /// </param>
        public MutationQuery customerCreate(CustomerCreatePayloadDelegate buildQuery,CustomerCreateInput input,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("customerCreate___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("customerCreate ");

            Arguments args = new Arguments();

            args.Add("input", input);

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new CustomerCreatePayloadQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Updates the default address of an existing customer.
        /// </summary>
        /// <param name="customerAccessToken">
        /// The access token used to identify the customer.
        /// </param>
        /// <param name="addressId">
        /// ID of the address to set as the new default for the customer.
        /// </param>
        public MutationQuery customerDefaultAddressUpdate(CustomerDefaultAddressUpdatePayloadDelegate buildQuery,string customerAccessToken,string addressId,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("customerDefaultAddressUpdate___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("customerDefaultAddressUpdate ");

            Arguments args = new Arguments();

            args.Add("customerAccessToken", customerAccessToken);

            args.Add("addressId", addressId);

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new CustomerDefaultAddressUpdatePayloadQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Sends a reset password email to the customer, as the first step in the reset password process.
        /// </summary>
        /// <param name="email">
        /// The email address of the customer to recover.
        /// </param>
        public MutationQuery customerRecover(CustomerRecoverPayloadDelegate buildQuery,string email,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("customerRecover___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("customerRecover ");

            Arguments args = new Arguments();

            args.Add("email", email);

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new CustomerRecoverPayloadQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Resets a customer’s password with a token received from `CustomerRecover`.
        /// </summary>
        /// <param name="id">
        /// Specifies the customer to reset.
        /// </param>
        /// <param name="input">
        /// The fields used to reset a customer’s password.
        /// </param>
        public MutationQuery customerReset(CustomerResetPayloadDelegate buildQuery,string id,CustomerResetInput input,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("customerReset___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("customerReset ");

            Arguments args = new Arguments();

            args.Add("id", id);

            args.Add("input", input);

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new CustomerResetPayloadQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Resets a customer’s password with the reset password url received from `CustomerRecover`.
        /// </summary>
        /// <param name="resetUrl">
        /// The customer's reset password url.
        /// </param>
        /// <param name="password">
        /// New password that will be set as part of the reset password process.
        /// </param>
        public MutationQuery customerResetByUrl(CustomerResetByUrlPayloadDelegate buildQuery,string resetUrl,string password,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("customerResetByUrl___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("customerResetByUrl ");

            Arguments args = new Arguments();

            args.Add("resetUrl", resetUrl);

            args.Add("password", password);

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new CustomerResetByUrlPayloadQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Updates an existing customer.
        /// </summary>
        /// <param name="customerAccessToken">
        /// The access token used to identify the customer.
        /// </param>
        /// <param name="customer">
        /// The customer object input.
        /// </param>
        public MutationQuery customerUpdate(CustomerUpdatePayloadDelegate buildQuery,string customerAccessToken,CustomerUpdateInput customer,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("customerUpdate___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("customerUpdate ");

            Arguments args = new Arguments();

            args.Add("customerAccessToken", customerAccessToken);

            args.Add("customer", customer);

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new CustomerUpdatePayloadQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Will return a GraphQL query.
        /// </summary>
        public override string ToString() {
            return Query.ToString() + "}";
        }
    }
    }
