namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void BlogEdgeDelegate(BlogEdgeQuery query);

    /// <summary>
    /// An auto-generated type which holds one Blog and a cursor during pagination.
    /// </summary>
    public class BlogEdgeQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="BlogEdgeQuery" /> is used to build queries. Typically
        /// <see cref="BlogEdgeQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public BlogEdgeQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// A cursor for use in pagination.
        /// </summary>
        public BlogEdgeQuery cursor() {
            Query.Append("cursor ");

            return this;
        }

        /// <summary>
        /// The item at the end of BlogEdge.
        /// </summary>
        public BlogEdgeQuery node(BlogDelegate buildQuery) {
            Query.Append("node ");

            Query.Append("{");
            buildQuery(new BlogQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
