namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void CustomerAddressCreatePayloadDelegate(CustomerAddressCreatePayloadQuery query);

    /// <summary>
    /// Return type for `customerAddressCreate` mutation.
    /// </summary>
    public class CustomerAddressCreatePayloadQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="CustomerAddressCreatePayloadQuery" /> is used to build queries. Typically
        /// <see cref="CustomerAddressCreatePayloadQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public CustomerAddressCreatePayloadQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// The new customer address object.
        /// </summary>
        public CustomerAddressCreatePayloadQuery customerAddress(MailingAddressDelegate buildQuery) {
            Query.Append("customerAddress ");

            Query.Append("{");
            buildQuery(new MailingAddressQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// List of errors that occurred executing the mutation.
        /// </summary>
        public CustomerAddressCreatePayloadQuery customerUserErrors(CustomerUserErrorDelegate buildQuery) {
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
        public CustomerAddressCreatePayloadQuery userErrors(UserErrorDelegate buildQuery) {
            Log.DeprecatedQueryField("CustomerAddressCreatePayload", "userErrors", "Use `customerUserErrors` instead");

            Query.Append("userErrors ");

            Query.Append("{");
            buildQuery(new UserErrorQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
