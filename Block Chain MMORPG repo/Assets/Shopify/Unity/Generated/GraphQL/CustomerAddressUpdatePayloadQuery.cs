namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void CustomerAddressUpdatePayloadDelegate(CustomerAddressUpdatePayloadQuery query);

    /// <summary>
    /// Return type for `customerAddressUpdate` mutation.
    /// </summary>
    public class CustomerAddressUpdatePayloadQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="CustomerAddressUpdatePayloadQuery" /> is used to build queries. Typically
        /// <see cref="CustomerAddressUpdatePayloadQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public CustomerAddressUpdatePayloadQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// The customer’s updated mailing address.
        /// </summary>
        public CustomerAddressUpdatePayloadQuery customerAddress(MailingAddressDelegate buildQuery) {
            Query.Append("customerAddress ");

            Query.Append("{");
            buildQuery(new MailingAddressQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// List of errors that occurred executing the mutation.
        /// </summary>
        public CustomerAddressUpdatePayloadQuery customerUserErrors(CustomerUserErrorDelegate buildQuery) {
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
        public CustomerAddressUpdatePayloadQuery userErrors(UserErrorDelegate buildQuery) {
            Log.DeprecatedQueryField("CustomerAddressUpdatePayload", "userErrors", "Use `customerUserErrors` instead");

            Query.Append("userErrors ");

            Query.Append("{");
            buildQuery(new UserErrorQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
