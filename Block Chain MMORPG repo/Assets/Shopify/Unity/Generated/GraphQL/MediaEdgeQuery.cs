namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void MediaEdgeDelegate(MediaEdgeQuery query);

    /// <summary>
    /// An auto-generated type which holds one Media and a cursor during pagination.
    /// </summary>
    public class MediaEdgeQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="MediaEdgeQuery" /> is used to build queries. Typically
        /// <see cref="MediaEdgeQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public MediaEdgeQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// A cursor for use in pagination.
        /// </summary>
        public MediaEdgeQuery cursor() {
            Query.Append("cursor ");

            return this;
        }

        /// <summary>
        /// The item at the end of MediaEdge.
        /// </summary>
        public MediaEdgeQuery node(MediaDelegate buildQuery) {
            Query.Append("node ");

            Query.Append("{");
            buildQuery(new MediaQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
