namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void PageEdgeDelegate(PageEdgeQuery query);

    /// <summary>
    /// An auto-generated type which holds one Page and a cursor during pagination.
    /// </summary>
    public class PageEdgeQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="PageEdgeQuery" /> is used to build queries. Typically
        /// <see cref="PageEdgeQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public PageEdgeQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// A cursor for use in pagination.
        /// </summary>
        public PageEdgeQuery cursor() {
            Query.Append("cursor ");

            return this;
        }

        /// <summary>
        /// The item at the end of PageEdge.
        /// </summary>
        public PageEdgeQuery node(PageDelegate buildQuery) {
            Query.Append("node ");

            Query.Append("{");
            buildQuery(new PageQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
