namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void ShippingRateDelegate(ShippingRateQuery query);

    /// <summary>
    /// A shipping rate to be applied to a checkout.
    /// </summary>
    public class ShippingRateQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="ShippingRateQuery" /> is used to build queries. Typically
        /// <see cref="ShippingRateQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public ShippingRateQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// Human-readable unique identifier for this shipping rate.
        /// </summary>
        public ShippingRateQuery handle() {
            Query.Append("handle ");

            return this;
        }

        /// \deprecated Use `priceV2` instead
        /// <summary>
        /// Price of this shipping rate.
        /// </summary>
        public ShippingRateQuery price() {
            Log.DeprecatedQueryField("ShippingRate", "price", "Use `priceV2` instead");

            Query.Append("price ");

            return this;
        }

        /// <summary>
        /// Price of this shipping rate.
        /// </summary>
        public ShippingRateQuery priceV2(MoneyV2Delegate buildQuery) {
            Query.Append("priceV2 ");

            Query.Append("{");
            buildQuery(new MoneyV2Query(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Title of this shipping rate.
        /// </summary>
        public ShippingRateQuery title() {
            Query.Append("title ");

            return this;
        }
    }
    }
