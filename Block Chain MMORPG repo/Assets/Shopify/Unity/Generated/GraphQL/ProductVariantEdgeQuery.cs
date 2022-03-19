namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void ProductVariantEdgeDelegate(ProductVariantEdgeQuery query);

    /// <summary>
    /// An auto-generated type which holds one ProductVariant and a cursor during pagination.
    /// </summary>
    public class ProductVariantEdgeQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="ProductVariantEdgeQuery" /> is used to build queries. Typically
        /// <see cref="ProductVariantEdgeQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public ProductVariantEdgeQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// A cursor for use in pagination.
        /// </summary>
        public ProductVariantEdgeQuery cursor() {
            Query.Append("cursor ");

            return this;
        }

        /// <summary>
        /// The item at the end of ProductVariantEdge.
        /// </summary>
        public ProductVariantEdgeQuery node(ProductVariantDelegate buildQuery) {
            Query.Append("node ");

            Query.Append("{");
            buildQuery(new ProductVariantQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
