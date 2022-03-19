namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void ArticleConnectionDelegate(ArticleConnectionQuery query);

    /// <summary>
    /// An auto-generated type for paginating through multiple Articles.
    /// </summary>
    public class ArticleConnectionQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="ArticleConnectionQuery" /> is used to build queries. Typically
        /// <see cref="ArticleConnectionQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public ArticleConnectionQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// A list of edges.
        /// </summary>
        public ArticleConnectionQuery edges(ArticleEdgeDelegate buildQuery) {
            Query.Append("edges ");

            Query.Append("{");
            buildQuery(new ArticleEdgeQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Information to aid in pagination.
        /// </summary>
        public ArticleConnectionQuery pageInfo(PageInfoDelegate buildQuery) {
            Query.Append("pageInfo ");

            Query.Append("{");
            buildQuery(new PageInfoQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
