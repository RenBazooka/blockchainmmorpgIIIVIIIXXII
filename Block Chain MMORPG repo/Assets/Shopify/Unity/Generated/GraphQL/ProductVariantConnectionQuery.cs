namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void ProductVariantConnectionDelegate(ProductVariantConnectionQuery query);

    /// <summary>
    /// An auto-generated type for paginating through multiple ProductVariants.
    /// </summary>
    public class ProductVariantConnectionQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="ProductVariantConnectionQuery" /> is used to build queries. Typically
        /// <see cref="ProductVariantConnectionQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public ProductVariantConnectionQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// A list of edges.
        /// </summary>
        public ProductVariantConnectionQuery edges(ProductVariantEdgeDelegate buildQuery) {
            Query.Append("edges ");

            Query.Append("{");
            buildQuery(new ProductVariantEdgeQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Information to aid in pagination.
        /// </summary>
        public ProductVariantConnectionQuery pageInfo(PageInfoDelegate buildQuery) {
            Query.Append("pageInfo ");

            Query.Append("{");
            buildQuery(new PageInfoQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
