namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void DomainDelegate(DomainQuery query);

    /// <summary>
    /// Represents a web address.
    /// </summary>
    public class DomainQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="DomainQuery" /> is used to build queries. Typically
        /// <see cref="DomainQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public DomainQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// The host name of the domain (eg: `example.com`).
        /// </summary>
        public DomainQuery host() {
            Query.Append("host ");

            return this;
        }

        /// <summary>
        /// Whether SSL is enabled or not.
        /// </summary>
        public DomainQuery sslEnabled() {
            Query.Append("sslEnabled ");

            return this;
        }

        /// <summary>
        /// The URL of the domain (eg: `https://example.com`).
        /// </summary>
        public DomainQuery url() {
            Query.Append("url ");

            return this;
        }
    }
    }
