namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void CustomerAccessTokenCreatePayloadDelegate(CustomerAccessTokenCreatePayloadQuery query);

    /// <summary>
    /// Return type for `customerAccessTokenCreate` mutation.
    /// </summary>
    public class CustomerAccessTokenCreatePayloadQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="CustomerAccessTokenCreatePayloadQuery" /> is used to build queries. Typically
        /// <see cref="CustomerAccessTokenCreatePayloadQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public CustomerAccessTokenCreatePayloadQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// The newly created customer access token object.
        /// </summary>
        public CustomerAccessTokenCreatePayloadQuery customerAccessToken(CustomerAccessTokenDelegate buildQuery) {
            Query.Append("customerAccessToken ");

            Query.Append("{");
            buildQuery(new CustomerAccessTokenQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// List of errors that occurred executing the mutation.
        /// </summary>
        public CustomerAccessTokenCreatePayloadQuery customerUserErrors(CustomerUserErrorDelegate buildQuery) {
            Query.Append("customerUserErrors ");

            Query.Append("{");
            buildQuery(new CustomerUserErrorQuery(Query));
            Query.Append("}");

            return this;
        }

        /// \deprecated Use `customerUserErrors` instead
        /// <summary>
        /// List of errors that occurred executing the mutation.
        /// </summary>
        public CustomerAccessTokenCreatePayloadQuery userErrors(UserErrorDelegate buildQuery) {
            Log.DeprecatedQueryField("CustomerAccessTokenCreatePayload", "userErrors", "Use `customerUserErrors` instead");

            Query.Append("userErrors ");

            Query.Append("{");
            buildQuery(new UserErrorQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
