namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void ProductOptionDelegate(ProductOptionQuery query);

    /// <summary>
    /// Product property names like "Size", "Color", and "Material" that the customers can select.
    /// Variants are selected based on permutations of these options.
    /// 255 characters limit each.
    /// </summary>
    public class ProductOptionQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="ProductOptionQuery" /> is used to build queries. Typically
        /// <see cref="ProductOptionQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public ProductOptionQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// Globally unique identifier.
        /// </summary>
        public ProductOptionQuery id() {
            Query.Append("id ");

            return this;
        }

        /// <summary>
        /// The product option’s name.
        /// </summary>
        public ProductOptionQuery name() {
            Query.Append("name ");

            return this;
        }

        /// <summary>
        /// The corresponding value to the product option name.
        /// </summary>
        public ProductOptionQuery values() {
            Query.Append("values ");

            return this;
        }
    }
    }
