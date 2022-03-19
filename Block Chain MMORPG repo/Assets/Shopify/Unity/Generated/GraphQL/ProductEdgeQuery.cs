namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void ProductEdgeDelegate(ProductEdgeQuery query);

    /// <summary>
    /// An auto-generated type which holds one Product and a cursor during pagination.
    /// </summary>
    public class ProductEdgeQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="ProductEdgeQuery" /> is used to build queries. Typically
        /// <see cref="ProductEdgeQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public ProductEdgeQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// A cursor for use in pagination.
        /// </summary>
        public ProductEdgeQuery cursor() {
            Query.Append("cursor ");

            return this;
        }

        /// <summary>
        /// The item at the end of ProductEdge.
        /// </summary>
        public ProductEdgeQuery node(ProductDelegate buildQuery) {
            Query.Append("node ");

            Query.Append("{");
            buildQuery(new ProductQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
