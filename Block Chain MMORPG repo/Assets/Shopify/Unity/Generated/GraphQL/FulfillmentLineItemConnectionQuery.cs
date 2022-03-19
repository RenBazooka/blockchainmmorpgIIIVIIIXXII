namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void FulfillmentLineItemConnectionDelegate(FulfillmentLineItemConnectionQuery query);

    /// <summary>
    /// An auto-generated type for paginating through multiple FulfillmentLineItems.
    /// </summary>
    public class FulfillmentLineItemConnectionQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="FulfillmentLineItemConnectionQuery" /> is used to build queries. Typically
        /// <see cref="FulfillmentLineItemConnectionQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public FulfillmentLineItemConnectionQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// A list of edges.
        /// </summary>
        public FulfillmentLineItemConnectionQuery edges(FulfillmentLineItemEdgeDelegate buildQuery) {
            Query.Append("edges ");

            Query.Append("{");
            buildQuery(new FulfillmentLineItemEdgeQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Information to aid in pagination.
        /// </summary>
        public FulfillmentLineItemConnectionQuery pageInfo(PageInfoDelegate buildQuery) {
            Query.Append("pageInfo ");

            Query.Append("{");
            buildQuery(new PageInfoQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
