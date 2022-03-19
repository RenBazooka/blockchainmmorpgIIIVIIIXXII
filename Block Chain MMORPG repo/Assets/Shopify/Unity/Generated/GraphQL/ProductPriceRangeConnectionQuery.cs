namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void ProductPriceRangeConnectionDelegate(ProductPriceRangeConnectionQuery query);

    /// <summary>
    /// An auto-generated type for paginating through multiple ProductPriceRanges.
    /// </summary>
    public class ProductPriceRangeConnectionQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="ProductPriceRangeConnectionQuery" /> is used to build queries. Typically
        /// <see cref="ProductPriceRangeConnectionQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public ProductPriceRangeConnectionQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// A list of edges.
        /// </summary>
        public ProductPriceRangeConnectionQuery edges(ProductPriceRangeEdgeDelegate buildQuery) {
            Query.Append("edges ");

            Query.Append("{");
            buildQuery(new ProductPriceRangeEdgeQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Information to aid in pagination.
        /// </summary>
        public ProductPriceRangeConnectionQuery pageInfo(PageInfoDelegate buildQuery) {
            Query.Append("pageInfo ");

            Query.Append("{");
            buildQuery(new PageInfoQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
