namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void CustomerAccessTokenDeletePayloadDelegate(CustomerAccessTokenDeletePayloadQuery query);

    /// <summary>
    /// Return type for `customerAccessTokenDelete` mutation.
    /// </summary>
    public class CustomerAccessTokenDeletePayloadQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="CustomerAccessTokenDeletePayloadQuery" /> is used to build queries. Typically
        /// <see cref="CustomerAccessTokenDeletePayloadQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public CustomerAccessTokenDeletePayloadQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// The destroyed access token.
        /// </summary>
        public CustomerAccessTokenDeletePayloadQuery deletedAccessToken() {
            Query.Append("deletedAccessToken ");

            return this;
        }

        /// <summary>
        /// ID of the destroyed customer access token.
        /// </summary>
        public CustomerAccessTokenDeletePayloadQuery deletedCustomerAccessTokenId() {
            Query.Append("deletedCustomerAccessTokenId ");

            return this;
        }

        /// <summary>
        /// List of errors that occurred executing the mutation.
        /// </summary>
        public CustomerAccessTokenDeletePayloadQuery userErrors(UserErrorDelegate buildQuery) {
            Query.Append("userErrors ");

            Query.Append("{");
            buildQuery(new UserErrorQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
