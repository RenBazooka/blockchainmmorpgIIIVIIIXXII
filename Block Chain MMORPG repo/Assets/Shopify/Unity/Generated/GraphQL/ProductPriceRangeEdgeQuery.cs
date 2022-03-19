namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void ProductPriceRangeEdgeDelegate(ProductPriceRangeEdgeQuery query);

    /// <summary>
    /// An auto-generated type which holds one ProductPriceRange and a cursor during pagination.
    /// </summary>
    public class ProductPriceRangeEdgeQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="ProductPriceRangeEdgeQuery" /> is used to build queries. Typically
        /// <see cref="ProductPriceRangeEdgeQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public ProductPriceRangeEdgeQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// A cursor for use in pagination.
        /// </summary>
        public ProductPriceRangeEdgeQuery cursor() {
            Query.Append("cursor ");

            return this;
        }

        /// <summary>
        /// The item at the end of ProductPriceRangeEdge.
        /// </summary>
        public ProductPriceRangeEdgeQuery node(ProductPriceRangeDelegate buildQuery) {
            Query.Append("node ");

            Query.Append("{");
            buildQuery(new ProductPriceRangeQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
