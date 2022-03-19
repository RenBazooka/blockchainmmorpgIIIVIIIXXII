namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void MetafieldEdgeDelegate(MetafieldEdgeQuery query);

    /// <summary>
    /// An auto-generated type which holds one Metafield and a cursor during pagination.
    /// </summary>
    public class MetafieldEdgeQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="MetafieldEdgeQuery" /> is used to build queries. Typically
        /// <see cref="MetafieldEdgeQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public MetafieldEdgeQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// A cursor for use in pagination.
        /// </summary>
        public MetafieldEdgeQuery cursor() {
            Query.Append("cursor ");

            return this;
        }

        /// <summary>
        /// The item at the end of MetafieldEdge.
        /// </summary>
        public MetafieldEdgeQuery node(MetafieldDelegate buildQuery) {
            Query.Append("node ");

            Query.Append("{");
            buildQuery(new MetafieldQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
