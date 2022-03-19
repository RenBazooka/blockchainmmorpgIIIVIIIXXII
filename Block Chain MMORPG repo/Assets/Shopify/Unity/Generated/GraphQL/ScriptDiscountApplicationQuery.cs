namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void ScriptDiscountApplicationDelegate(ScriptDiscountApplicationQuery query);

    /// <summary>
    /// Script discount applications capture the intentions of a discount that
    /// was created by a Shopify Script.
    /// </summary>
    public class ScriptDiscountApplicationQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="ScriptDiscountApplicationQuery" /> is used to build queries. Typically
        /// <see cref="ScriptDiscountApplicationQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public ScriptDiscountApplicationQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// The method by which the discount's value is allocated to its entitled items.
        /// </summary>
        public ScriptDiscountApplicationQuery allocationMethod() {
            Query.Append("allocationMethod ");

            return this;
        }

        /// \deprecated Use `title` instead
        /// <summary>
        /// The description of the application as defined by the Script.
        /// </summary>
        public ScriptDiscountApplicationQuery description() {
            Log.DeprecatedQueryField("ScriptDiscountApplication", "description", "Use `title` instead");

            Query.Append("description ");

            return this;
        }

        /// <summary>
        /// Which lines of targetType that the discount is allocated over.
        /// </summary>
        public ScriptDiscountApplicationQuery targetSelection() {
            Query.Append("targetSelection ");

            return this;
        }

        /// <summary>
        /// The type of line that the discount is applicable towards.
        /// </summary>
        public ScriptDiscountApplicationQuery targetType() {
            Query.Append("targetType ");

            return this;
        }

        /// <summary>
        /// The title of the application as defined by the Script.
        /// </summary>
        public ScriptDiscountApplicationQuery title() {
            Query.Append("title ");

            return this;
        }

        /// <summary>
        /// The value of the discount application.
        /// </summary>
        public ScriptDiscountApplicationQuery value(PricingValueDelegate buildQuery) {
            Query.Append("value ");

            Query.Append("{");
            buildQuery(new PricingValueQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
