namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void DiscountApplicationConnectionDelegate(DiscountApplicationConnectionQuery query);

    /// <summary>
    /// An auto-generated type for paginating through multiple DiscountApplications.
    /// </summary>
    public class DiscountApplicationConnectionQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="DiscountApplicationConnectionQuery" /> is used to build queries. Typically
        /// <see cref="DiscountApplicationConnectionQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public DiscountApplicationConnectionQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// A list of edges.
        /// </summary>
        public DiscountApplicationConnectionQuery edges(DiscountApplicationEdgeDelegate buildQuery) {
            Query.Append("edges ");

            Query.Append("{");
            buildQuery(new DiscountApplicationEdgeQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Information to aid in pagination.
        /// </summary>
        public DiscountApplicationConnectionQuery pageInfo(PageInfoDelegate buildQuery) {
            Query.Append("pageInfo ");

            Query.Append("{");
            buildQuery(new PageInfoQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
