namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void FulfillmentDelegate(FulfillmentQuery query);

    /// <summary>
    /// Represents a single fulfillment in an order.
    /// </summary>
    public class FulfillmentQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="FulfillmentQuery" /> is used to build queries. Typically
        /// <see cref="FulfillmentQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public FulfillmentQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// List of the fulfillment's line items.
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
        public FulfillmentQuery fulfillmentLineItems(FulfillmentLineItemConnectionDelegate buildQuery,long? first = null,string after = null,long? last = null,string before = null,bool? reverse = null,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("fulfillmentLineItems___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("fulfillmentLineItems ");

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
            buildQuery(new FulfillmentLineItemConnectionQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// The name of the tracking company.
        /// </summary>
        public FulfillmentQuery trackingCompany() {
            Query.Append("trackingCompany ");

            return this;
        }

        /// <summary>
        /// Tracking information associated with the fulfillment,
        /// such as the tracking number and tracking URL.
        /// </summary>
        /// <param name="first">
        /// Truncate the array result to this size.
        /// </param>
        public FulfillmentQuery trackingInfo(FulfillmentTrackingInfoDelegate buildQuery,long? first = null,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("trackingInfo___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("trackingInfo ");

            Arguments args = new Arguments();

            if (first != null) {
                args.Add("first", first);
            }

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new FulfillmentTrackingInfoQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
