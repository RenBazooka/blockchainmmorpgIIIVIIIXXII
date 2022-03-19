namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void MoneyV2edgeDelegate(MoneyV2edgeQuery query);

    /// <summary>
    /// An auto-generated type which holds one MoneyV2 and a cursor during pagination.
    /// </summary>
    public class MoneyV2edgeQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="MoneyV2edgeQuery" /> is used to build queries. Typically
        /// <see cref="MoneyV2edgeQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public MoneyV2edgeQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// A cursor for use in pagination.
        /// </summary>
        public MoneyV2edgeQuery cursor() {
            Query.Append("cursor ");

            return this;
        }

        /// <summary>
        /// The item at the end of MoneyV2Edge.
        /// </summary>
        public MoneyV2edgeQuery node(MoneyV2Delegate buildQuery) {
            Query.Append("node ");

            Query.Append("{");
            buildQuery(new MoneyV2Query(Query));
            Query.Append("}");

            return this;
        }
    }
    }
