namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void ManualDiscountApplicationDelegate(ManualDiscountApplicationQuery query);

    /// <summary>
    /// Manual discount applications capture the intentions of a discount that was manually created.
    /// </summary>
    public class ManualDiscountApplicationQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="ManualDiscountApplicationQuery" /> is used to build queries. Typically
        /// <see cref="ManualDiscountApplicationQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public ManualDiscountApplicationQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// The method by which the discount's value is allocated to its entitled items.
        /// </summary>
        public ManualDiscountApplicationQuery allocationMethod() {
            Query.Append("allocationMethod ");

            return this;
        }

        /// <summary>
        /// The description of the application.
        /// </summary>
        public ManualDiscountApplicationQuery description() {
            Query.Append("description ");

            return this;
        }

        /// <summary>
        /// Which lines of targetType that the discount is allocated over.
        /// </summary>
        public ManualDiscountApplicationQuery targetSelection() {
            Query.Append("targetSelection ");

            return this;
        }

        /// <summary>
        /// The type of line that the discount is applicable towards.
        /// </summary>
        public ManualDiscountApplicationQuery targetType() {
            Query.Append("targetType ");

            return this;
        }

        /// <summary>
        /// The title of the application.
        /// </summary>
        public ManualDiscountApplicationQuery title() {
            Query.Append("title ");

            return this;
        }

        /// <summary>
        /// The value of the discount application.
        /// </summary>
        public ManualDiscountApplicationQuery value(PricingValueDelegate buildQuery) {
            Query.Append("value ");

            Query.Append("{");
            buildQuery(new PricingValueQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
