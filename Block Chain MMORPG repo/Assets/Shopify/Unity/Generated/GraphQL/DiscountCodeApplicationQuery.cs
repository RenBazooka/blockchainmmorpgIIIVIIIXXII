namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void DiscountCodeApplicationDelegate(DiscountCodeApplicationQuery query);

    /// <summary>
    /// Discount code applications capture the intentions of a discount code at
    /// the time that it is applied.
    /// </summary>
    public class DiscountCodeApplicationQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="DiscountCodeApplicationQuery" /> is used to build queries. Typically
        /// <see cref="DiscountCodeApplicationQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public DiscountCodeApplicationQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// The method by which the discount's value is allocated to its entitled items.
        /// </summary>
        public DiscountCodeApplicationQuery allocationMethod() {
            Query.Append("allocationMethod ");

            return this;
        }

        /// <summary>
        /// Specifies whether the discount code was applied successfully.
        /// </summary>
        public DiscountCodeApplicationQuery applicable() {
            Query.Append("applicable ");

            return this;
        }

        /// <summary>
        /// The string identifying the discount code that was used at the time of application.
        /// </summary>
        public DiscountCodeApplicationQuery code() {
            Query.Append("code ");

            return this;
        }

        /// <summary>
        /// Which lines of targetType that the discount is allocated over.
        /// </summary>
        public DiscountCodeApplicationQuery targetSelection() {
            Query.Append("targetSelection ");

            return this;
        }

        /// <summary>
        /// The type of line that the discount is applicable towards.
        /// </summary>
        public DiscountCodeApplicationQuery targetType() {
            Query.Append("targetType ");

            return this;
        }

        /// <summary>
        /// The value of the discount application.
        /// </summary>
        public DiscountCodeApplicationQuery value(PricingValueDelegate buildQuery) {
            Query.Append("value ");

            Query.Append("{");
            buildQuery(new PricingValueQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
