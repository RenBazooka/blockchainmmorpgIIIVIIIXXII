namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void ArticleEdgeDelegate(ArticleEdgeQuery query);

    /// <summary>
    /// An auto-generated type which holds one Article and a cursor during pagination.
    /// </summary>
    public class ArticleEdgeQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="ArticleEdgeQuery" /> is used to build queries. Typically
        /// <see cref="ArticleEdgeQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public ArticleEdgeQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// A cursor for use in pagination.
        /// </summary>
        public ArticleEdgeQuery cursor() {
            Query.Append("cursor ");

            return this;
        }

        /// <summary>
        /// The item at the end of ArticleEdge.
        /// </summary>
        public ArticleEdgeQuery node(ArticleDelegate buildQuery) {
            Query.Append("node ");

            Query.Append("{");
            buildQuery(new ArticleQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
