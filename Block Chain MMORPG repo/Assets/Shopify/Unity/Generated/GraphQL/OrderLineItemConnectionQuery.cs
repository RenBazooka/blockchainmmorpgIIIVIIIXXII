namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void OrderLineItemConnectionDelegate(OrderLineItemConnectionQuery query);

    /// <summary>
    /// An auto-generated type for paginating through multiple OrderLineItems.
    /// </summary>
    public class OrderLineItemConnectionQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="OrderLineItemConnectionQuery" /> is used to build queries. Typically
        /// <see cref="OrderLineItemConnectionQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public OrderLineItemConnectionQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// A list of edges.
        /// </summary>
        public OrderLineItemConnectionQuery edges(OrderLineItemEdgeDelegate buildQuery) {
            Query.Append("edges ");

            Query.Append("{");
            buildQuery(new OrderLineItemEdgeQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Information to aid in pagination.
        /// </summary>
        public OrderLineItemConnectionQuery pageInfo(PageInfoDelegate buildQuery) {
            Query.Append("pageInfo ");

            Query.Append("{");
            buildQuery(new PageInfoQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
