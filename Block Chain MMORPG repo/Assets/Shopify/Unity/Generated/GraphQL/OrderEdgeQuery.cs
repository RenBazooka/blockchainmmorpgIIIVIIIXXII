namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void OrderEdgeDelegate(OrderEdgeQuery query);

    /// <summary>
    /// An auto-generated type which holds one Order and a cursor during pagination.
    /// </summary>
    public class OrderEdgeQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="OrderEdgeQuery" /> is used to build queries. Typically
        /// <see cref="OrderEdgeQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public OrderEdgeQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// A cursor for use in pagination.
        /// </summary>
        public OrderEdgeQuery cursor() {
            Query.Append("cursor ");

            return this;
        }

        /// <summary>
        /// The item at the end of OrderEdge.
        /// </summary>
        public OrderEdgeQuery node(OrderDelegate buildQuery) {
            Query.Append("node ");

            Query.Append("{");
            buildQuery(new OrderQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
