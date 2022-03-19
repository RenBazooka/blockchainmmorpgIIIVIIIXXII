namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void MoneyV2connectionDelegate(MoneyV2connectionQuery query);

    /// <summary>
    /// An auto-generated type for paginating through multiple MoneyV2s.
    /// </summary>
    public class MoneyV2connectionQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="MoneyV2connectionQuery" /> is used to build queries. Typically
        /// <see cref="MoneyV2connectionQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public MoneyV2connectionQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// A list of edges.
        /// </summary>
        public MoneyV2connectionQuery edges(MoneyV2edgeDelegate buildQuery) {
            Query.Append("edges ");

            Query.Append("{");
            buildQuery(new MoneyV2edgeQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Information to aid in pagination.
        /// </summary>
        public MoneyV2connectionQuery pageInfo(PageInfoDelegate buildQuery) {
            Query.Append("pageInfo ");

            Query.Append("{");
            buildQuery(new PageInfoQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
