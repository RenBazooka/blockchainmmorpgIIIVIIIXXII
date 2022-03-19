namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void FulfillmentLineItemDelegate(FulfillmentLineItemQuery query);

    /// <summary>
    /// Represents a single line item in a fulfillment. There is at most one fulfillment line item for each order line item.
    /// </summary>
    public class FulfillmentLineItemQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="FulfillmentLineItemQuery" /> is used to build queries. Typically
        /// <see cref="FulfillmentLineItemQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public FulfillmentLineItemQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// The associated order's line item.
        /// </summary>
        public FulfillmentLineItemQuery lineItem(OrderLineItemDelegate buildQuery) {
            Query.Append("lineItem ");

            Query.Append("{");
            buildQuery(new OrderLineItemQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// The amount fulfilled in this fulfillment.
        /// </summary>
        public FulfillmentLineItemQuery quantity() {
            Query.Append("quantity ");

            return this;
        }
    }
    }
