namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void CustomerResetByUrlPayloadDelegate(CustomerResetByUrlPayloadQuery query);

    /// <summary>
    /// Return type for `customerResetByUrl` mutation.
    /// </summary>
    public class CustomerResetByUrlPayloadQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="CustomerResetByUrlPayloadQuery" /> is used to build queries. Typically
        /// <see cref="CustomerResetByUrlPayloadQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public CustomerResetByUrlPayloadQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// The customer object which was reset.
        /// </summary>
        public CustomerResetByUrlPayloadQuery customer(CustomerDelegate buildQuery) {
            Query.Append("customer ");

            Query.Append("{");
            buildQuery(new CustomerQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// A newly created customer access token object for the customer.
        /// </summary>
        public CustomerResetByUrlPayloadQuery customerAccessToken(CustomerAccessTokenDelegate buildQuery) {
            Query.Append("customerAccessToken ");

            Query.Append("{");
            buildQuery(new CustomerAccessTokenQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// List of errors that occurred executing the mutation.
        /// </summary>
        public CustomerResetByUrlPayloadQuery customerUserErrors(CustomerUserErrorDelegate buildQuery) {
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
        public CustomerResetByUrlPayloadQuery userErrors(UserErrorDelegate buildQuery) {
            Log.DeprecatedQueryField("CustomerResetByUrlPayload", "userErrors", "Use `customerUserErrors` instead");

            Query.Append("userErrors ");

            Query.Append("{");
            buildQuery(new UserErrorQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
