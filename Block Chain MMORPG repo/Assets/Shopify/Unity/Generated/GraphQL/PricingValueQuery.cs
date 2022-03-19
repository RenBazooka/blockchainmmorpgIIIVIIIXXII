namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void PricingValueDelegate(PricingValueQuery query);

    /// <summary>
    /// The price value (fixed or percentage) for a discount application.
    /// </summary>
    public class PricingValueQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="PricingValueQuery" /> is used to build queries. Typically
        /// <see cref="PricingValueQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public PricingValueQuery(StringBuilder query) {
            Query = query;

            Query.Append("__typename ");
        }

        /// <summary>
        /// will allow you to write queries on MoneyV2.
        /// </summary>
        public PricingValueQuery onMoneyV2(MoneyV2Delegate buildQuery) {
            Query.Append("...on MoneyV2{");
            buildQuery(new MoneyV2Query(Query));
            Query.Append("}");
            return this;
        }

        /// <summary>
        /// will allow you to write queries on PricingPercentageValue.
        /// </summary>
        public PricingValueQuery onPricingPercentageValue(PricingPercentageValueDelegate buildQuery) {
            Query.Append("...on PricingPercentageValue{");
            buildQuery(new PricingPercentageValueQuery(Query));
            Query.Append("}");
            return this;
        }
    }
    }
