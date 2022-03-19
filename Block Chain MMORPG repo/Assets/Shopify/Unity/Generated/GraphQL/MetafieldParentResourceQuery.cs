namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void MetafieldParentResourceDelegate(MetafieldParentResourceQuery query);

    /// <summary>
    /// A resource that the metafield belongs to.
    /// </summary>
    public class MetafieldParentResourceQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="MetafieldParentResourceQuery" /> is used to build queries. Typically
        /// <see cref="MetafieldParentResourceQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public MetafieldParentResourceQuery(StringBuilder query) {
            Query = query;

            Query.Append("__typename ");
        }

        /// <summary>
        /// will allow you to write queries on Product.
        /// </summary>
        public MetafieldParentResourceQuery onProduct(ProductDelegate buildQuery) {
            Query.Append("...on Product{");
            buildQuery(new ProductQuery(Query));
            Query.Append("}");
            return this;
        }

        /// <summary>
        /// will allow you to write queries on ProductVariant.
        /// </summary>
        public MetafieldParentResourceQuery onProductVariant(ProductVariantDelegate buildQuery) {
            Query.Append("...on ProductVariant{");
            buildQuery(new ProductVariantQuery(Query));
            Query.Append("}");
            return this;
        }
    }
    }
