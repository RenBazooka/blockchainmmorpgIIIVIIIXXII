namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void ProductPriceRangeDelegate(ProductPriceRangeQuery query);

    /// <summary>
    /// The price range of the product.
    /// </summary>
    public class ProductPriceRangeQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="ProductPriceRangeQuery" /> is used to build queries. Typically
        /// <see cref="ProductPriceRangeQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public ProductPriceRangeQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// The highest variant's price.
        /// </summary>
        public ProductPriceRangeQuery maxVariantPrice(MoneyV2Delegate buildQuery) {
            Query.Append("maxVariantPrice ");

            Query.Append("{");
            buildQuery(new MoneyV2Query(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// The lowest variant's price.
        /// </summary>
        public ProductPriceRangeQuery minVariantPrice(MoneyV2Delegate buildQuery) {
            Query.Append("minVariantPrice ");

            Query.Append("{");
            buildQuery(new MoneyV2Query(Query));
            Query.Append("}");

            return this;
        }
    }
    }
