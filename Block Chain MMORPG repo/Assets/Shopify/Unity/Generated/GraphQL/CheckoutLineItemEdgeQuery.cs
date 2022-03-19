namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void CheckoutLineItemEdgeDelegate(CheckoutLineItemEdgeQuery query);

    /// <summary>
    /// An auto-generated type which holds one CheckoutLineItem and a cursor during pagination.
    /// </summary>
    public class CheckoutLineItemEdgeQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="CheckoutLineItemEdgeQuery" /> is used to build queries. Typically
        /// <see cref="CheckoutLineItemEdgeQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public CheckoutLineItemEdgeQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// A cursor for use in pagination.
        /// </summary>
        public CheckoutLineItemEdgeQuery cursor() {
            Query.Append("cursor ");

            return this;
        }

        /// <summary>
        /// The item at the end of CheckoutLineItemEdge.
        /// </summary>
        public CheckoutLineItemEdgeQuery node(CheckoutLineItemDelegate buildQuery) {
            Query.Append("node ");

            Query.Append("{");
            buildQuery(new CheckoutLineItemQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
