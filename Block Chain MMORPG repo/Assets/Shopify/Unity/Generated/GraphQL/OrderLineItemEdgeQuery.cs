namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void OrderLineItemEdgeDelegate(OrderLineItemEdgeQuery query);

    /// <summary>
    /// An auto-generated type which holds one OrderLineItem and a cursor during pagination.
    /// </summary>
    public class OrderLineItemEdgeQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="OrderLineItemEdgeQuery" /> is used to build queries. Typically
        /// <see cref="OrderLineItemEdgeQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public OrderLineItemEdgeQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// A cursor for use in pagination.
        /// </summary>
        public OrderLineItemEdgeQuery cursor() {
            Query.Append("cursor ");

            return this;
        }

        /// <summary>
        /// The item at the end of OrderLineItemEdge.
        /// </summary>
        public OrderLineItemEdgeQuery node(OrderLineItemDelegate buildQuery) {
            Query.Append("node ");

            Query.Append("{");
            buildQuery(new OrderLineItemQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
