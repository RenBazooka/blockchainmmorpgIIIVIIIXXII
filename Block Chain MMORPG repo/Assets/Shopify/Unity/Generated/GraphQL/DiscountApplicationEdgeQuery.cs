namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void DiscountApplicationEdgeDelegate(DiscountApplicationEdgeQuery query);

    /// <summary>
    /// An auto-generated type which holds one DiscountApplication and a cursor during pagination.
    /// </summary>
    public class DiscountApplicationEdgeQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="DiscountApplicationEdgeQuery" /> is used to build queries. Typically
        /// <see cref="DiscountApplicationEdgeQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public DiscountApplicationEdgeQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// A cursor for use in pagination.
        /// </summary>
        public DiscountApplicationEdgeQuery cursor() {
            Query.Append("cursor ");

            return this;
        }

        /// <summary>
        /// The item at the end of DiscountApplicationEdge.
        /// </summary>
        public DiscountApplicationEdgeQuery node(DiscountApplicationDelegate buildQuery) {
            Query.Append("node ");

            Query.Append("{");
            buildQuery(new DiscountApplicationQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
