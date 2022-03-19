namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void MetafieldConnectionDelegate(MetafieldConnectionQuery query);

    /// <summary>
    /// An auto-generated type for paginating through multiple Metafields.
    /// </summary>
    public class MetafieldConnectionQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="MetafieldConnectionQuery" /> is used to build queries. Typically
        /// <see cref="MetafieldConnectionQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public MetafieldConnectionQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// A list of edges.
        /// </summary>
        public MetafieldConnectionQuery edges(MetafieldEdgeDelegate buildQuery) {
            Query.Append("edges ");

            Query.Append("{");
            buildQuery(new MetafieldEdgeQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Information to aid in pagination.
        /// </summary>
        public MetafieldConnectionQuery pageInfo(PageInfoDelegate buildQuery) {
            Query.Append("pageInfo ");

            Query.Append("{");
            buildQuery(new PageInfoQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
