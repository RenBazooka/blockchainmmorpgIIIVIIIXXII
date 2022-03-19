namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void ProductVariantPricePairDelegate(ProductVariantPricePairQuery query);

    /// <summary>
    /// The compare-at price and price of a variant sharing a currency.
    /// </summary>
    public class ProductVariantPricePairQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="ProductVariantPricePairQuery" /> is used to build queries. Typically
        /// <see cref="ProductVariantPricePairQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public ProductVariantPricePairQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// The compare-at price of the variant with associated currency.
        /// </summary>
        public ProductVariantPricePairQuery compareAtPrice(MoneyV2Delegate buildQuery) {
            Query.Append("compareAtPrice ");

            Query.Append("{");
            buildQuery(new MoneyV2Query(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// The price of the variant with associated currency.
        /// </summary>
        public ProductVariantPricePairQuery price(MoneyV2Delegate buildQuery) {
            Query.Append("price ");

            Query.Append("{");
            buildQuery(new MoneyV2Query(Query));
            Query.Append("}");

            return this;
        }
    }
    }
