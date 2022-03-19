namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void CheckoutCustomerAssociateV2payloadDelegate(CheckoutCustomerAssociateV2payloadQuery query);

    /// <summary>
    /// Return type for `checkoutCustomerAssociateV2` mutation.
    /// </summary>
    public class CheckoutCustomerAssociateV2payloadQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="CheckoutCustomerAssociateV2payloadQuery" /> is used to build queries. Typically
        /// <see cref="CheckoutCustomerAssociateV2payloadQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public CheckoutCustomerAssociateV2payloadQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// The updated checkout object.
        /// </summary>
        public CheckoutCustomerAssociateV2payloadQuery checkout(CheckoutDelegate buildQuery) {
            Query.Append("checkout ");

            Query.Append("{");
            buildQuery(new CheckoutQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// List of errors that occurred executing the mutation.
        /// </summary>
        public CheckoutCustomerAssociateV2payloadQuery checkoutUserErrors(CheckoutUserErrorDelegate buildQuery) {
            Query.Append("checkoutUserErrors ");

            Query.Append("{");
            buildQuery(new CheckoutUserErrorQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// The associated customer object.
        /// </summary>
        public CheckoutCustomerAssociateV2payloadQuery customer(CustomerDelegate buildQuery) {
            Query.Append("customer ");

            Query.Append("{");
            buildQuery(new CustomerQuery(Query));
            Query.Append("}");

            return this;
        }

        /// \deprecated Use `checkoutUserErrors` instead
        /// <summary>
        /// List of errors that occurred executing the mutation.
        /// </summary>
        public CheckoutCustomerAssociateV2payloadQuery userErrors(UserErrorDelegate buildQuery) {
            Log.DeprecatedQueryField("CheckoutCustomerAssociateV2Payload", "userErrors", "Use `checkoutUserErrors` instead");

            Query.Append("userErrors ");

            Query.Append("{");
            buildQuery(new UserErrorQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
