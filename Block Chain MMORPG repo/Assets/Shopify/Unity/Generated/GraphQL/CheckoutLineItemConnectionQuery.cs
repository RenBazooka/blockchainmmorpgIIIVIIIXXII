namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void CheckoutLineItemConnectionDelegate(CheckoutLineItemConnectionQuery query);

    /// <summary>
    /// An auto-generated type for paginating through multiple CheckoutLineItems.
    /// </summary>
    public class CheckoutLineItemConnectionQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="CheckoutLineItemConnectionQuery" /> is used to build queries. Typically
        /// <see cref="CheckoutLineItemConnectionQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public CheckoutLineItemConnectionQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// A list of edges.
        /// </summary>
        public CheckoutLineItemConnectionQuery edges(CheckoutLineItemEdgeDelegate buildQuery) {
            Query.Append("edges ");

            Query.Append("{");
            buildQuery(new CheckoutLineItemEdgeQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Information to aid in pagination.
        /// </summary>
        public CheckoutLineItemConnectionQuery pageInfo(PageInfoDelegate buildQuery) {
            Query.Append("pageInfo ");

            Query.Append("{");
            buildQuery(new PageInfoQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
