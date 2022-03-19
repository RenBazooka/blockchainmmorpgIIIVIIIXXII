namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void CustomerUpdatePayloadDelegate(CustomerUpdatePayloadQuery query);

    /// <summary>
    /// Return type for `customerUpdate` mutation.
    /// </summary>
    public class CustomerUpdatePayloadQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="CustomerUpdatePayloadQuery" /> is used to build queries. Typically
        /// <see cref="CustomerUpdatePayloadQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public CustomerUpdatePayloadQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// The updated customer object.
        /// </summary>
        public CustomerUpdatePayloadQuery customer(CustomerDelegate buildQuery) {
            Query.Append("customer ");

            Query.Append("{");
            buildQuery(new CustomerQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// The newly created customer access token. If the customer's password is updated, all previous access tokens
        /// (including the one used to perform this mutation) become invalid, and a new token is generated.
        /// </summary>
        public CustomerUpdatePayloadQuery customerAccessToken(CustomerAccessTokenDelegate buildQuery) {
            Query.Append("customerAccessToken ");

            Query.Append("{");
            buildQuery(new CustomerAccessTokenQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// List of errors that occurred executing the mutation.
        /// </summary>
        public CustomerUpdatePayloadQuery customerUserErrors(CustomerUserErrorDelegate buildQuery) {
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
        public CustomerUpdatePayloadQuery userErrors(UserErrorDelegate buildQuery) {
            Log.DeprecatedQueryField("CustomerUpdatePayload", "userErrors", "Use `customerUserErrors` instead");

            Query.Append("userErrors ");

            Query.Append("{");
            buildQuery(new UserErrorQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
