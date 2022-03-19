namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void SeoDelegate(SeoQuery query);

    /// <summary>
    /// SEO information.
    /// </summary>
    public class SeoQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="SeoQuery" /> is used to build queries. Typically
        /// <see cref="SeoQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public SeoQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// The meta description.
        /// </summary>
        public SeoQuery description() {
            Query.Append("description ");

            return this;
        }

        /// <summary>
        /// The SEO title.
        /// </summary>
        public SeoQuery title() {
            Query.Append("title ");

            return this;
        }
    }
    }
