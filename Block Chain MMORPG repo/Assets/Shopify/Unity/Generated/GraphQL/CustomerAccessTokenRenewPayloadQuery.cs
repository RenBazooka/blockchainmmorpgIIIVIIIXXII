namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void CustomerAccessTokenRenewPayloadDelegate(CustomerAccessTokenRenewPayloadQuery query);

    /// <summary>
    /// Return type for `customerAccessTokenRenew` mutation.
    /// </summary>
    public class CustomerAccessTokenRenewPayloadQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="CustomerAccessTokenRenewPayloadQuery" /> is used to build queries. Typically
        /// <see cref="CustomerAccessTokenRenewPayloadQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public CustomerAccessTokenRenewPayloadQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// The renewed customer access token object.
        /// </summary>
        public CustomerAccessTokenRenewPayloadQuery customerAccessToken(CustomerAccessTokenDelegate buildQuery) {
            Query.Append("customerAccessToken ");

            Query.Append("{");
            buildQuery(new CustomerAccessTokenQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// List of errors that occurred executing the mutation.
        /// </summary>
        public CustomerAccessTokenRenewPayloadQuery userErrors(UserErrorDelegate buildQuery) {
            Query.Append("userErrors ");

            Query.Append("{");
            buildQuery(new UserErrorQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
