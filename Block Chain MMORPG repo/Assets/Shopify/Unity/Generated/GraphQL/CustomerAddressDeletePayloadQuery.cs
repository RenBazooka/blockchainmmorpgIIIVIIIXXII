namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void CustomerAddressDeletePayloadDelegate(CustomerAddressDeletePayloadQuery query);

    /// <summary>
    /// Return type for `customerAddressDelete` mutation.
    /// </summary>
    public class CustomerAddressDeletePayloadQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="CustomerAddressDeletePayloadQuery" /> is used to build queries. Typically
        /// <see cref="CustomerAddressDeletePayloadQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public CustomerAddressDeletePayloadQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// List of errors that occurred executing the mutation.
        /// </summary>
        public CustomerAddressDeletePayloadQuery customerUserErrors(CustomerUserErrorDelegate buildQuery) {
            Query.Append("customerUserErrors ");

            Query.Append("{");
            buildQuery(new CustomerUserErrorQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// ID of the deleted customer address.
        /// </summary>
        public CustomerAddressDeletePayloadQuery deletedCustomerAddressId() {
            Query.Append("deletedCustomerAddressId ");

            return this;
        }

        /// \deprecated Use `customerUserErrors` instead
        /// <summary>
        /// List of errors that occurred executing the mutation.
        /// </summary>
        public CustomerAddressDeletePayloadQuery userErrors(UserErrorDelegate buildQuery) {
            Log.DeprecatedQueryField("CustomerAddressDeletePayload", "userErrors", "Use `customerUserErrors` instead");

            Query.Append("userErrors ");

            Query.Append("{");
            buildQuery(new UserErrorQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
