namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void StringEdgeDelegate(StringEdgeQuery query);

    /// <summary>
    /// An auto-generated type which holds one String and a cursor during pagination.
    /// </summary>
    public class StringEdgeQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="StringEdgeQuery" /> is used to build queries. Typically
        /// <see cref="StringEdgeQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public StringEdgeQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// A cursor for use in pagination.
        /// </summary>
        public StringEdgeQuery cursor() {
            Query.Append("cursor ");

            return this;
        }

        /// <summary>
        /// The item at the end of StringEdge.
        /// </summary>
        public StringEdgeQuery node() {
            Query.Append("node ");

            return this;
        }
    }
    }
