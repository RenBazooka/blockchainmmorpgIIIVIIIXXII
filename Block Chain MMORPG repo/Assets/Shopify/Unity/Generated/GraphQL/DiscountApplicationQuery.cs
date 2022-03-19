namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void DiscountApplicationDelegate(DiscountApplicationQuery query);

    /// <summary>
    /// Discount applications capture the intentions of a discount source at
    /// the time of application.
    /// </summary>
    public class DiscountApplicationQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="DiscountApplicationQuery" /> is used to build queries. Typically
        /// <see cref="DiscountApplicationQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public DiscountApplicationQuery(StringBuilder query) {
            Query = query;

            Query.Append("__typename ");
        }

        /// <summary>
        /// The method by which the discount's value is allocated to its entitled items.
        /// </summary>
        public DiscountApplicationQuery allocationMethod() {
            Query.Append("allocationMethod ");

            return this;
        }

        /// <summary>
        /// Which lines of targetType that the discount is allocated over.
        /// </summary>
        public DiscountApplicationQuery targetSelection() {
            Query.Append("targetSelection ");

            return this;
        }

        /// <summary>
        /// The type of line that the discount is applicable towards.
        /// </summary>
        public DiscountApplicationQuery targetType() {
            Query.Append("targetType ");

            return this;
        }

        /// <summary>
        /// The value of the discount application.
        /// </summary>
        public DiscountApplicationQuery value(PricingValueDelegate buildQuery) {
            Query.Append("value ");

            Query.Append("{");
            buildQuery(new PricingValueQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// will allow you to write queries on AutomaticDiscountApplication.
        /// </summary>
        public DiscountApplicationQuery onAutomaticDiscountApplication(AutomaticDiscountApplicationDelegate buildQuery) {
            Query.Append("...on AutomaticDiscountApplication{");
            buildQuery(new AutomaticDiscountApplicationQuery(Query));
            Query.Append("}");
            return this;
        }

        /// <summary>
        /// will allow you to write queries on DiscountCodeApplication.
        /// </summary>
        public DiscountApplicationQuery onDiscountCodeApplication(DiscountCodeApplicationDelegate buildQuery) {
            Query.Append("...on DiscountCodeApplication{");
            buildQuery(new DiscountCodeApplicationQuery(Query));
            Query.Append("}");
            return this;
        }

        /// <summary>
        /// will allow you to write queries on ManualDiscountApplication.
        /// </summary>
        public DiscountApplicationQuery onManualDiscountApplication(ManualDiscountApplicationDelegate buildQuery) {
            Query.Append("...on ManualDiscountApplication{");
            buildQuery(new ManualDiscountApplicationQuery(Query));
            Query.Append("}");
            return this;
        }

        /// <summary>
        /// will allow you to write queries on ScriptDiscountApplication.
        /// </summary>
        public DiscountApplicationQuery onScriptDiscountApplication(ScriptDiscountApplicationDelegate buildQuery) {
            Query.Append("...on ScriptDiscountApplication{");
            buildQuery(new ScriptDiscountApplicationQuery(Query));
            Query.Append("}");
            return this;
        }
    }
    }
