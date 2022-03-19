namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void CheckoutDelegate(CheckoutQuery query);

    /// <summary>
    /// A container for all the information required to checkout items and pay.
    /// </summary>
    public class CheckoutQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="CheckoutQuery" /> is used to build queries. Typically
        /// <see cref="CheckoutQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public CheckoutQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// The gift cards used on the checkout.
        /// </summary>
        public CheckoutQuery appliedGiftCards(AppliedGiftCardDelegate buildQuery) {
            Query.Append("appliedGiftCards ");

            Query.Append("{");
            buildQuery(new AppliedGiftCardQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// The available shipping rates for this Checkout.
        /// Should only be used when checkout `requiresShipping` is `true` and
        /// the shipping address is valid.
        /// </summary>
        public CheckoutQuery availableShippingRates(AvailableShippingRatesDelegate buildQuery) {
            Query.Append("availableShippingRates ");

            Query.Append("{");
            buildQuery(new AvailableShippingRatesQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// The date and time when the checkout was completed.
        /// </summary>
        public CheckoutQuery completedAt() {
            Query.Append("completedAt ");

            return this;
        }

        /// <summary>
        /// The date and time when the checkout was created.
        /// </summary>
        public CheckoutQuery createdAt() {
            Query.Append("createdAt ");

            return this;
        }

        /// <summary>
        /// The currency code for the Checkout.
        /// </summary>
        public CheckoutQuery currencyCode() {
            Query.Append("currencyCode ");

            return this;
        }

        /// <summary>
        /// A list of extra information that is added to the checkout.
        /// </summary>
        public CheckoutQuery customAttributes(AttributeDelegate buildQuery) {
            Query.Append("customAttributes ");

            Query.Append("{");
            buildQuery(new AttributeQuery(Query));
            Query.Append("}");

            return this;
        }

        /// \deprecated This field will always return null. If you have an authentication token for the customer, you can use the `customer` field on the query root to retrieve it.
        /// <summary>
        /// The customer associated with the checkout.
        /// </summary>
        public CheckoutQuery customer(CustomerDelegate buildQuery) {
            Log.DeprecatedQueryField("Checkout", "customer", "This field will always return null. If you have an authentication token for the customer, you can use the `customer` field on the query root to retrieve it.");

            Query.Append("customer ");

            Query.Append("{");
            buildQuery(new CustomerQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Discounts that have been applied on the checkout.
        /// </summary>
        /// <param name="first">
        /// Returns up to the first `n` elements from the list.
        /// </param>
        /// <param name="after">
        /// Returns the elements that come after the specified cursor.
        /// </param>
        /// <param name="last">
        /// Returns up to the last `n` elements from the list.
        /// </param>
        /// <param name="before">
        /// Returns the elements that come before the specified cursor.
        /// </param>
        /// <param name="reverse">
        /// Reverse the order of the underlying list.
        /// </param>
        public CheckoutQuery discountApplications(DiscountApplicationConnectionDelegate buildQuery,long? first = null,string after = null,long? last = null,string before = null,bool? reverse = null,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("discountApplications___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("discountApplications ");

            Arguments args = new Arguments();

            if (first != null) {
                args.Add("first", first);
            }

            if (after != null) {
                args.Add("after", after);
            }

            if (last != null) {
                args.Add("last", last);
            }

            if (before != null) {
                args.Add("before", before);
            }

            if (reverse != null) {
                args.Add("reverse", reverse);
            }

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new DiscountApplicationConnectionQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// The email attached to this checkout.
        /// </summary>
        public CheckoutQuery email() {
            Query.Append("email ");

            return this;
        }

        /// <summary>
        /// Globally unique identifier.
        /// </summary>
        public CheckoutQuery id() {
            Query.Append("id ");

            return this;
        }

        /// <summary>
        /// A list of line item objects, each one containing information about an item in the checkout.
        /// </summary>
        /// <param name="first">
        /// Returns up to the first `n` elements from the list.
        /// </param>
        /// <param name="after">
        /// Returns the elements that come after the specified cursor.
        /// </param>
        /// <param name="last">
        /// Returns up to the last `n` elements from the list.
        /// </param>
        /// <param name="before">
        /// Returns the elements that come before the specified cursor.
        /// </param>
        /// <param name="reverse">
        /// Reverse the order of the underlying list.
        /// </param>
        public CheckoutQuery lineItems(CheckoutLineItemConnectionDelegate buildQuery,long? first = null,string after = null,long? last = null,string before = null,bool? reverse = null,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("lineItems___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("lineItems ");

            Arguments args = new Arguments();

            if (first != null) {
                args.Add("first", first);
            }

            if (after != null) {
                args.Add("after", after);
            }

            if (last != null) {
                args.Add("last", last);
            }

            if (before != null) {
                args.Add("before", before);
            }

            if (reverse != null) {
                args.Add("reverse", reverse);
            }

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new CheckoutLineItemConnectionQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// The sum of all the prices of all the items in the checkout. Duties, taxes, shipping and discounts excluded.
        /// </summary>
        public CheckoutQuery lineItemsSubtotalPrice(MoneyV2Delegate buildQuery) {
            Query.Append("lineItemsSubtotalPrice ");

            Query.Append("{");
            buildQuery(new MoneyV2Query(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// The note associated with the checkout.
        /// </summary>
        public CheckoutQuery note() {
            Query.Append("note ");

            return this;
        }

        /// <summary>
        /// The resulting order from a paid checkout.
        /// </summary>
        public CheckoutQuery order(OrderDelegate buildQuery) {
            Query.Append("order ");

            Query.Append("{");
            buildQuery(new OrderQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// The Order Status Page for this Checkout, null when checkout is not completed.
        /// </summary>
        public CheckoutQuery orderStatusUrl() {
            Query.Append("orderStatusUrl ");

            return this;
        }

        /// \deprecated Use `paymentDueV2` instead
        /// <summary>
        /// The amount left to be paid. This is equal to the cost of the line items, taxes and shipping minus discounts and gift cards.
        /// </summary>
        public CheckoutQuery paymentDue() {
            Log.DeprecatedQueryField("Checkout", "paymentDue", "Use `paymentDueV2` instead");

            Query.Append("paymentDue ");

            return this;
        }

        /// <summary>
        /// The amount left to be paid. This is equal to the cost of the line items, duties, taxes and shipping minus discounts and gift cards.
        /// </summary>
        public CheckoutQuery paymentDueV2(MoneyV2Delegate buildQuery) {
            Query.Append("paymentDueV2 ");

            Query.Append("{");
            buildQuery(new MoneyV2Query(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Whether or not the Checkout is ready and can be completed. Checkouts may
        /// have asynchronous operations that can take time to finish. If you want
        /// to complete a checkout or ensure all the fields are populated and up to
        /// date, polling is required until the value is true.
        /// </summary>
        public CheckoutQuery ready() {
            Query.Append("ready ");

            return this;
        }

        /// <summary>
        /// States whether or not the fulfillment requires shipping.
        /// </summary>
        public CheckoutQuery requiresShipping() {
            Query.Append("requiresShipping ");

            return this;
        }

        /// <summary>
        /// The shipping address to where the line items will be shipped.
        /// </summary>
        public CheckoutQuery shippingAddress(MailingAddressDelegate buildQuery) {
            Query.Append("shippingAddress ");

            Query.Append("{");
            buildQuery(new MailingAddressQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// The discounts that have been allocated onto the shipping line by discount applications.
        /// </summary>
        public CheckoutQuery shippingDiscountAllocations(DiscountAllocationDelegate buildQuery) {
            Query.Append("shippingDiscountAllocations ");

            Query.Append("{");
            buildQuery(new DiscountAllocationQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Once a shipping rate is selected by the customer it is transitioned to a `shipping_line` object.
        /// </summary>
        public CheckoutQuery shippingLine(ShippingRateDelegate buildQuery) {
            Query.Append("shippingLine ");

            Query.Append("{");
            buildQuery(new ShippingRateQuery(Query));
            Query.Append("}");

            return this;
        }

        /// \deprecated Use `subtotalPriceV2` instead
        /// <summary>
        /// Price of the checkout before shipping and taxes.
        /// </summary>
        public CheckoutQuery subtotalPrice() {
            Log.DeprecatedQueryField("Checkout", "subtotalPrice", "Use `subtotalPriceV2` instead");

            Query.Append("subtotalPrice ");

            return this;
        }

        /// <summary>
        /// Price of the checkout before duties, shipping and taxes.
        /// </summary>
        public CheckoutQuery subtotalPriceV2(MoneyV2Delegate buildQuery) {
            Query.Append("subtotalPriceV2 ");

            Query.Append("{");
            buildQuery(new MoneyV2Query(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Specifies if the Checkout is tax exempt.
        /// </summary>
        public CheckoutQuery taxExempt() {
            Query.Append("taxExempt ");

            return this;
        }

        /// <summary>
        /// Specifies if taxes are included in the line item and shipping line prices.
        /// </summary>
        public CheckoutQuery taxesIncluded() {
            Query.Append("taxesIncluded ");

            return this;
        }

        /// \deprecated Use `totalPriceV2` instead
        /// <summary>
        /// The sum of all the prices of all the items in the checkout, taxes and discounts included.
        /// </summary>
        public CheckoutQuery totalPrice() {
            Log.DeprecatedQueryField("Checkout", "totalPrice", "Use `totalPriceV2` instead");

            Query.Append("totalPrice ");

            return this;
        }

        /// <summary>
        /// The sum of all the prices of all the items in the checkout, duties, taxes and discounts included.
        /// </summary>
        public CheckoutQuery totalPriceV2(MoneyV2Delegate buildQuery) {
            Query.Append("totalPriceV2 ");

            Query.Append("{");
            buildQuery(new MoneyV2Query(Query));
            Query.Append("}");

            return this;
        }

        /// \deprecated Use `totalTaxV2` instead
        /// <summary>
        /// The sum of all the taxes applied to the line items and shipping lines in the checkout.
        /// </summary>
        public CheckoutQuery totalTax() {
            Log.DeprecatedQueryField("Checkout", "totalTax", "Use `totalTaxV2` instead");

            Query.Append("totalTax ");

            return this;
        }

        /// <summary>
        /// The sum of all the taxes applied to the line items and shipping lines in the checkout.
        /// </summary>
        public CheckoutQuery totalTaxV2(MoneyV2Delegate buildQuery) {
            Query.Append("totalTaxV2 ");

            Query.Append("{");
            buildQuery(new MoneyV2Query(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// The date and time when the checkout was last updated.
        /// </summary>
        public CheckoutQuery updatedAt() {
            Query.Append("updatedAt ");

            return this;
        }

        /// <summary>
        /// The url pointing to the checkout accessible from the web.
        /// </summary>
        public CheckoutQuery webUrl() {
            Query.Append("webUrl ");

            return this;
        }
    }
    }
