namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void PricingPercentageValueDelegate(PricingPercentageValueQuery query);

    /// <summary>
    /// The value of the percentage pricing object.
    /// </summary>
    public class PricingPercentageValueQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="PricingPercentageValueQuery" /> is used to build queries. Typically
        /// <see cref="PricingPercentageValueQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public PricingPercentageValueQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// The percentage value of the object.
        /// </summary>
        public PricingPercentageValueQuery percentage() {
            Query.Append("percentage ");

            return this;
        }
    }
    }
