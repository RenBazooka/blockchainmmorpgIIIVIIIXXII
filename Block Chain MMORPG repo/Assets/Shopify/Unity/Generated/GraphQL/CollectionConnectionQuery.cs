namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void CollectionConnectionDelegate(CollectionConnectionQuery query);

    /// <summary>
    /// An auto-generated type for paginating through multiple Collections.
    /// </summary>
    public class CollectionConnectionQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="CollectionConnectionQuery" /> is used to build queries. Typically
        /// <see cref="CollectionConnectionQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public CollectionConnectionQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// A list of edges.
        /// </summary>
        public CollectionConnectionQuery edges(CollectionEdgeDelegate buildQuery) {
            Query.Append("edges ");

            Query.Append("{");
            buildQuery(new CollectionEdgeQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Information to aid in pagination.
        /// </summary>
        public CollectionConnectionQuery pageInfo(PageInfoDelegate buildQuery) {
            Query.Append("pageInfo ");

            Query.Append("{");
            buildQuery(new PageInfoQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
