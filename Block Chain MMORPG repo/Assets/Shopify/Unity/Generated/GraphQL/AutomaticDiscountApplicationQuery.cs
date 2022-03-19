namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void AutomaticDiscountApplicationDelegate(AutomaticDiscountApplicationQuery query);

    /// <summary>
    /// Automatic discount applications capture the intentions of a discount that was automatically applied.
    /// </summary>
    public class AutomaticDiscountApplicationQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="AutomaticDiscountApplicationQuery" /> is used to build queries. Typically
        /// <see cref="AutomaticDiscountApplicationQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public AutomaticDiscountApplicationQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// The method by which the discount's value is allocated to its entitled items.
        /// </summary>
        public AutomaticDiscountApplicationQuery allocationMethod() {
            Query.Append("allocationMethod ");

            return this;
        }

        /// <summary>
        /// Which lines of targetType that the discount is allocated over.
        /// </summary>
        public AutomaticDiscountApplicationQuery targetSelection() {
            Query.Append("targetSelection ");

            return this;
        }

        /// <summary>
        /// The type of line that the discount is applicable towards.
        /// </summary>
        public AutomaticDiscountApplicationQuery targetType() {
            Query.Append("targetType ");

            return this;
        }

        /// <summary>
        /// The title of the application.
        /// </summary>
        public AutomaticDiscountApplicationQuery title() {
            Query.Append("title ");

            return this;
        }

        /// <summary>
        /// The value of the discount application.
        /// </summary>
        public AutomaticDiscountApplicationQuery value(PricingValueDelegate buildQuery) {
            Query.Append("value ");

            Query.Append("{");
            buildQuery(new PricingValueQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
