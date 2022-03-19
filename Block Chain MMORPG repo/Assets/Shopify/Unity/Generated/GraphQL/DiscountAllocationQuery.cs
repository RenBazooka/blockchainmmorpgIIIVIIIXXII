namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void DiscountAllocationDelegate(DiscountAllocationQuery query);

    /// <summary>
    /// An amount discounting the line that has been allocated by a discount.
    /// </summary>
    public class DiscountAllocationQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="DiscountAllocationQuery" /> is used to build queries. Typically
        /// <see cref="DiscountAllocationQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public DiscountAllocationQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// Amount of discount allocated.
        /// </summary>
        public DiscountAllocationQuery allocatedAmount(MoneyV2Delegate buildQuery) {
            Query.Append("allocatedAmount ");

            Query.Append("{");
            buildQuery(new MoneyV2Query(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// The discount this allocated amount originated from.
        /// </summary>
        public DiscountAllocationQuery discountApplication(DiscountApplicationDelegate buildQuery) {
            Query.Append("discountApplication ");

            Query.Append("{");
            buildQuery(new DiscountApplicationQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
