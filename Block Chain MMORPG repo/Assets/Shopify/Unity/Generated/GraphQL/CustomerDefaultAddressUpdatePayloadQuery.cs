namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void CustomerDefaultAddressUpdatePayloadDelegate(CustomerDefaultAddressUpdatePayloadQuery query);

    /// <summary>
    /// Return type for `customerDefaultAddressUpdate` mutation.
    /// </summary>
    public class CustomerDefaultAddressUpdatePayloadQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="CustomerDefaultAddressUpdatePayloadQuery" /> is used to build queries. Typically
        /// <see cref="CustomerDefaultAddressUpdatePayloadQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public CustomerDefaultAddressUpdatePayloadQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// The updated customer object.
        /// </summary>
        public CustomerDefaultAddressUpdatePayloadQuery customer(CustomerDelegate buildQuery) {
            Query.Append("customer ");

            Query.Append("{");
            buildQuery(new CustomerQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// List of errors that occurred executing the mutation.
        /// </summary>
        public CustomerDefaultAddressUpdatePayloadQuery customerUserErrors(CustomerUserErrorDelegate buildQuery) {
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
        public CustomerDefaultAddressUpdatePayloadQuery userErrors(UserErrorDelegate buildQuery) {
            Log.DeprecatedQueryField("CustomerDefaultAddressUpdatePayload", "userErrors", "Use `customerUserErrors` instead");

            Query.Append("userErrors ");

            Query.Append("{");
            buildQuery(new UserErrorQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
