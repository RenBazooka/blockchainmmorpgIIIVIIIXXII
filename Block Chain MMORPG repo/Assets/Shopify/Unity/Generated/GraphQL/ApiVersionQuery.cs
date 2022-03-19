namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void ApiVersionDelegate(ApiVersionQuery query);

    /// <summary>
    /// A version of the API.
    /// </summary>
    public class ApiVersionQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="ApiVersionQuery" /> is used to build queries. Typically
        /// <see cref="ApiVersionQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public ApiVersionQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// The human-readable name of the version.
        /// </summary>
        public ApiVersionQuery displayName() {
            Query.Append("displayName ");

            return this;
        }

        /// <summary>
        /// The unique identifier of an ApiVersion. All supported API versions have a date-based (YYYY-MM) or `unstable` handle.
        /// </summary>
        public ApiVersionQuery handle() {
            Query.Append("handle ");

            return this;
        }

        /// <summary>
        /// Whether the version is supported by Shopify.
        /// </summary>
        public ApiVersionQuery supported() {
            Query.Append("supported ");

            return this;
        }
    }
    }
