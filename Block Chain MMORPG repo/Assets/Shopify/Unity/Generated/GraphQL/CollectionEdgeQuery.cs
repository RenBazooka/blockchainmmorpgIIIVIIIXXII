namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void CollectionEdgeDelegate(CollectionEdgeQuery query);

    /// <summary>
    /// An auto-generated type which holds one Collection and a cursor during pagination.
    /// </summary>
    public class CollectionEdgeQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="CollectionEdgeQuery" /> is used to build queries. Typically
        /// <see cref="CollectionEdgeQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public CollectionEdgeQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// A cursor for use in pagination.
        /// </summary>
        public CollectionEdgeQuery cursor() {
            Query.Append("cursor ");

            return this;
        }

        /// <summary>
        /// The item at the end of CollectionEdge.
        /// </summary>
        public CollectionEdgeQuery node(CollectionDelegate buildQuery) {
            Query.Append("node ");

            Query.Append("{");
            buildQuery(new CollectionQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
