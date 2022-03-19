namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void ProductVariantPricePairConnectionDelegate(ProductVariantPricePairConnectionQuery query);

    /// <summary>
    /// An auto-generated type for paginating through multiple ProductVariantPricePairs.
    /// </summary>
    public class ProductVariantPricePairConnectionQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="ProductVariantPricePairConnectionQuery" /> is used to build queries. Typically
        /// <see cref="ProductVariantPricePairConnectionQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public ProductVariantPricePairConnectionQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// A list of edges.
        /// </summary>
        public ProductVariantPricePairConnectionQuery edges(ProductVariantPricePairEdgeDelegate buildQuery) {
            Query.Append("edges ");

            Query.Append("{");
            buildQuery(new ProductVariantPricePairEdgeQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Information to aid in pagination.
        /// </summary>
        public ProductVariantPricePairConnectionQuery pageInfo(PageInfoDelegate buildQuery) {
            Query.Append("pageInfo ");

            Query.Append("{");
            buildQuery(new PageInfoQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
