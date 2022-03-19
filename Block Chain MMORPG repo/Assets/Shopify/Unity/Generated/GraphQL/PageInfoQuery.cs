namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void PageInfoDelegate(PageInfoQuery query);

    /// <summary>
    /// Information about pagination in a connection.
    /// </summary>
    public class PageInfoQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="PageInfoQuery" /> is used to build queries. Typically
        /// <see cref="PageInfoQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public PageInfoQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// Indicates if there are more pages to fetch.
        /// </summary>
        public PageInfoQuery hasNextPage() {
            Query.Append("hasNextPage ");

            return this;
        }

        /// <summary>
        /// Indicates if there are any pages prior to the current page.
        /// </summary>
        public PageInfoQuery hasPreviousPage() {
            Query.Append("hasPreviousPage ");

            return this;
        }
    }
    }
