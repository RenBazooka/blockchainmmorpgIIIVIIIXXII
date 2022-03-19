namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void ProductConnectionDelegate(ProductConnectionQuery query);

    /// <summary>
    /// An auto-generated type for paginating through multiple Products.
    /// </summary>
    public class ProductConnectionQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="ProductConnectionQuery" /> is used to build queries. Typically
        /// <see cref="ProductConnectionQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public ProductConnectionQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// A list of edges.
        /// </summary>
        public ProductConnectionQuery edges(ProductEdgeDelegate buildQuery) {
            Query.Append("edges ");

            Query.Append("{");
            buildQuery(new ProductEdgeQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Information to aid in pagination.
        /// </summary>
        public ProductConnectionQuery pageInfo(PageInfoDelegate buildQuery) {
            Query.Append("pageInfo ");

            Query.Append("{");
            buildQuery(new PageInfoQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
