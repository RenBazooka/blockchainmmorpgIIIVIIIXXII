namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void FulfillmentLineItemEdgeDelegate(FulfillmentLineItemEdgeQuery query);

    /// <summary>
    /// An auto-generated type which holds one FulfillmentLineItem and a cursor during pagination.
    /// </summary>
    public class FulfillmentLineItemEdgeQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="FulfillmentLineItemEdgeQuery" /> is used to build queries. Typically
        /// <see cref="FulfillmentLineItemEdgeQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public FulfillmentLineItemEdgeQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// A cursor for use in pagination.
        /// </summary>
        public FulfillmentLineItemEdgeQuery cursor() {
            Query.Append("cursor ");

            return this;
        }

        /// <summary>
        /// The item at the end of FulfillmentLineItemEdge.
        /// </summary>
        public FulfillmentLineItemEdgeQuery node(FulfillmentLineItemDelegate buildQuery) {
            Query.Append("node ");

            Query.Append("{");
            buildQuery(new FulfillmentLineItemQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
