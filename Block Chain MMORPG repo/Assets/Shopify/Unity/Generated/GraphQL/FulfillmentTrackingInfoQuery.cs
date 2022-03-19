namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void FulfillmentTrackingInfoDelegate(FulfillmentTrackingInfoQuery query);

    /// <summary>
    /// Tracking information associated with the fulfillment.
    /// </summary>
    public class FulfillmentTrackingInfoQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="FulfillmentTrackingInfoQuery" /> is used to build queries. Typically
        /// <see cref="FulfillmentTrackingInfoQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public FulfillmentTrackingInfoQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// The tracking number of the fulfillment.
        /// </summary>
        public FulfillmentTrackingInfoQuery number() {
            Query.Append("number ");

            return this;
        }

        /// <summary>
        /// The URL to track the fulfillment.
        /// </summary>
        public FulfillmentTrackingInfoQuery url() {
            Query.Append("url ");

            return this;
        }
    }
    }
