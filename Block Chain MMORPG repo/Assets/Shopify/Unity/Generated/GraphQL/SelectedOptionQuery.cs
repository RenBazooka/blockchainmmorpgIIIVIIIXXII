namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void SelectedOptionDelegate(SelectedOptionQuery query);

    /// <summary>
    /// Properties used by customers to select a product variant.
    /// Products can have multiple options, like different sizes or colors.
    /// </summary>
    public class SelectedOptionQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="SelectedOptionQuery" /> is used to build queries. Typically
        /// <see cref="SelectedOptionQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public SelectedOptionQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// The product option’s name.
        /// </summary>
        public SelectedOptionQuery name() {
            Query.Append("name ");

            return this;
        }

        /// <summary>
        /// The product option’s value.
        /// </summary>
        public SelectedOptionQuery value() {
            Query.Append("value ");

            return this;
        }
    }
    }
