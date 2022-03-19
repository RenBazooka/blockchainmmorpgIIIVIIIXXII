namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void AvailableShippingRatesDelegate(AvailableShippingRatesQuery query);

    /// <summary>
    /// A collection of available shipping rates for a checkout.
    /// </summary>
    public class AvailableShippingRatesQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="AvailableShippingRatesQuery" /> is used to build queries. Typically
        /// <see cref="AvailableShippingRatesQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public AvailableShippingRatesQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// Whether or not the shipping rates are ready.
        /// The `shippingRates` field is `null` when this value is `false`.
        /// This field should be polled until its value becomes `true`.
        /// </summary>
        public AvailableShippingRatesQuery ready() {
            Query.Append("ready ");

            return this;
        }

        /// <summary>
        /// The fetched shipping rates. `null` until the `ready` field is `true`.
        /// </summary>
        public AvailableShippingRatesQuery shippingRates(ShippingRateDelegate buildQuery) {
            Query.Append("shippingRates ");

            Query.Append("{");
            buildQuery(new ShippingRateQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
