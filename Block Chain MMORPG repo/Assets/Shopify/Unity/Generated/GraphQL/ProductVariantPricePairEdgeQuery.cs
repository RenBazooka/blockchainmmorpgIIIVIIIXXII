namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void ProductVariantPricePairEdgeDelegate(ProductVariantPricePairEdgeQuery query);

    /// <summary>
    /// An auto-generated type which holds one ProductVariantPricePair and a cursor during pagination.
    /// </summary>
    public class ProductVariantPricePairEdgeQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="ProductVariantPricePairEdgeQuery" /> is used to build queries. Typically
        /// <see cref="ProductVariantPricePairEdgeQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public ProductVariantPricePairEdgeQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// A cursor for use in pagination.
        /// </summary>
        public ProductVariantPricePairEdgeQuery cursor() {
            Query.Append("cursor ");

            return this;
        }

        /// <summary>
        /// The item at the end of ProductVariantPricePairEdge.
        /// </summary>
        public ProductVariantPricePairEdgeQuery node(ProductVariantPricePairDelegate buildQuery) {
            Query.Append("node ");

            Query.Append("{");
            buildQuery(new ProductVariantPricePairQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
