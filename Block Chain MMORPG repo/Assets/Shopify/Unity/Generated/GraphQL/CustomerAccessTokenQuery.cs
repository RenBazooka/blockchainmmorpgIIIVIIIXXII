namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void CustomerAccessTokenDelegate(CustomerAccessTokenQuery query);

    /// <summary>
    /// A CustomerAccessToken represents the unique token required to make modifications to the customer object.
    /// </summary>
    public class CustomerAccessTokenQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="CustomerAccessTokenQuery" /> is used to build queries. Typically
        /// <see cref="CustomerAccessTokenQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public CustomerAccessTokenQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// The customer’s access token.
        /// </summary>
        public CustomerAccessTokenQuery accessToken() {
            Query.Append("accessToken ");

            return this;
        }

        /// <summary>
        /// The date and time when the customer access token expires.
        /// </summary>
        public CustomerAccessTokenQuery expiresAt() {
            Query.Append("expiresAt ");

            return this;
        }
    }
    }
