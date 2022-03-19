namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void OrderDelegate(OrderQuery query);

    /// <summary>
    /// An order is a customer’s completed request to purchase one or more products from a shop. An order is created when a customer completes the checkout process, during which time they provides an email address, billing address and payment information.
    /// </summary>
    public class OrderQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="OrderQuery" /> is used to build queries. Typically
        /// <see cref="OrderQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public OrderQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// The code of the currency used for the payment.
        /// </summary>
        public OrderQuery currencyCode() {
            Query.Append("currencyCode ");

            return this;
        }

        /// <summary>
        /// The locale code in which this specific order happened.
        /// </summary>
        public OrderQuery customerLocale() {
            Query.Append("customerLocale ");

            return this;
        }

        /// <summary>
        /// The unique URL that the customer can use to access the order.
        /// </summary>
        public OrderQuery customerUrl() {
            Query.Append("customerUrl ");

            return this;
        }

        /// <summary>
        /// Discounts that have been applied on the order.
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
        public OrderQuery discountApplications(DiscountApplicationConnectionDelegate buildQuery,long? first = null,string after = null,long? last = null,string before = null,bool? reverse = null,string alias = null) {
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
        /// The customer's email address.
        /// </summary>
        public OrderQuery email() {
            Query.Append("email ");

            return this;
        }

        /// <summary>
        /// Globally unique identifier.
        /// </summary>
        public OrderQuery id() {
            Query.Append("id ");

            return this;
        }

        /// <summary>
        /// List of the order’s line items.
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
        public OrderQuery lineItems(OrderLineItemConnectionDelegate buildQuery,long? first = null,string after = null,long? last = null,string before = null,bool? reverse = null,string alias = null) {
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
            buildQuery(new OrderLineItemConnectionQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Unique identifier for the order that appears on the order.
        /// For example, _#1000_ or _Store1001.
        /// </summary>
        public OrderQuery name() {
            Query.Append("name ");

            return this;
        }

        /// <summary>
        /// A unique numeric identifier for the order for use by shop owner and customer.
        /// </summary>
        public OrderQuery orderNumber() {
            Query.Append("orderNumber ");

            return this;
        }

        /// <summary>
        /// The customer's phone number for receiving SMS notifications.
        /// </summary>
        public OrderQuery phone() {
            Query.Append("phone ");

            return this;
        }

        /// <summary>
        /// The date and time when the order was imported.
        /// This value can be set to dates in the past when importing from other systems.
        /// If no value is provided, it will be auto-generated based on current date and time.
        /// </summary>
        public OrderQuery processedAt() {
            Query.Append("processedAt ");

            return this;
        }

        /// <summary>
        /// The address to where the order will be shipped.
        /// </summary>
        public OrderQuery shippingAddress(MailingAddressDelegate buildQuery) {
            Query.Append("shippingAddress ");

            Query.Append("{");
            buildQuery(new MailingAddressQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// The discounts that have been allocated onto the shipping line by discount applications.
        /// </summary>
        public OrderQuery shippingDiscountAllocations(DiscountAllocationDelegate buildQuery) {
            Query.Append("shippingDiscountAllocations ");

            Query.Append("{");
            buildQuery(new DiscountAllocationQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// The unique URL for the order's status page.
        /// </summary>
        public OrderQuery statusUrl() {
            Query.Append("statusUrl ");

            return this;
        }

        /// \deprecated Use `subtotalPriceV2` instead
        /// <summary>
        /// Price of the order before shipping and taxes.
        /// </summary>
        public OrderQuery subtotalPrice() {
            Log.DeprecatedQueryField("Order", "subtotalPrice", "Use `subtotalPriceV2` instead");

            Query.Append("subtotalPrice ");

            return this;
        }

        /// <summary>
        /// Price of the order before duties, shipping and taxes.
        /// </summary>
        public OrderQuery subtotalPriceV2(MoneyV2Delegate buildQuery) {
            Query.Append("subtotalPriceV2 ");

            Query.Append("{");
            buildQuery(new MoneyV2Query(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// List of the order’s successful fulfillments.
        /// </summary>
        /// <param name="first">
        /// Truncate the array result to this size.
        /// </param>
        public OrderQuery successfulFulfillments(FulfillmentDelegate buildQuery,long? first = null,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("successfulFulfillments___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("successfulFulfillments ");

            Arguments args = new Arguments();

            if (first != null) {
                args.Add("first", first);
            }

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new FulfillmentQuery(Query));
            Query.Append("}");

            return this;
        }

        /// \deprecated Use `totalPriceV2` instead
        /// <summary>
        /// The sum of all the prices of all the items in the order, taxes and discounts included (must be positive).
        /// </summary>
        public OrderQuery totalPrice() {
            Log.DeprecatedQueryField("Order", "totalPrice", "Use `totalPriceV2` instead");

            Query.Append("totalPrice ");

            return this;
        }

        /// <summary>
        /// The sum of all the prices of all the items in the order, duties, taxes and discounts included (must be positive).
        /// </summary>
        public OrderQuery totalPriceV2(MoneyV2Delegate buildQuery) {
            Query.Append("totalPriceV2 ");

            Query.Append("{");
            buildQuery(new MoneyV2Query(Query));
            Query.Append("}");

            return this;
        }

        /// \deprecated Use `totalRefundedV2` instead
        /// <summary>
        /// The total amount that has been refunded.
        /// </summary>
        public OrderQuery totalRefunded() {
            Log.DeprecatedQueryField("Order", "totalRefunded", "Use `totalRefundedV2` instead");

            Query.Append("totalRefunded ");

            return this;
        }

        /// <summary>
        /// The total amount that has been refunded.
        /// </summary>
        public OrderQuery totalRefundedV2(MoneyV2Delegate buildQuery) {
            Query.Append("totalRefundedV2 ");

            Query.Append("{");
            buildQuery(new MoneyV2Query(Query));
            Query.Append("}");

            return this;
        }

        /// \deprecated Use `totalShippingPriceV2` instead
        /// <summary>
        /// The total cost of shipping.
        /// </summary>
        public OrderQuery totalShippingPrice() {
            Log.DeprecatedQueryField("Order", "totalShippingPrice", "Use `totalShippingPriceV2` instead");

            Query.Append("totalShippingPrice ");

            return this;
        }

        /// <summary>
        /// The total cost of shipping.
        /// </summary>
        public OrderQuery totalShippingPriceV2(MoneyV2Delegate buildQuery) {
            Query.Append("totalShippingPriceV2 ");

            Query.Append("{");
            buildQuery(new MoneyV2Query(Query));
            Query.Append("}");

            return this;
        }

        /// \deprecated Use `totalTaxV2` instead
        /// <summary>
        /// The total cost of taxes.
        /// </summary>
        public OrderQuery totalTax() {
            Log.DeprecatedQueryField("Order", "totalTax", "Use `totalTaxV2` instead");

            Query.Append("totalTax ");

            return this;
        }

        /// <summary>
        /// The total cost of taxes.
        /// </summary>
        public OrderQuery totalTaxV2(MoneyV2Delegate buildQuery) {
            Query.Append("totalTaxV2 ");

            Query.Append("{");
            buildQuery(new MoneyV2Query(Query));
            Query.Append("}");

            return this;
        }
    }
    }
