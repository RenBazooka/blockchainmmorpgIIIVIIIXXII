namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void CheckoutCustomerAssociatePayloadDelegate(CheckoutCustomerAssociatePayloadQuery query);

    /// <summary>
    /// Return type for `checkoutCustomerAssociate` mutation.
    /// </summary>
    public class CheckoutCustomerAssociatePayloadQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="CheckoutCustomerAssociatePayloadQuery" /> is used to build queries. Typically
        /// <see cref="CheckoutCustomerAssociatePayloadQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public CheckoutCustomerAssociatePayloadQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// The updated checkout object.
        /// </summary>
        public CheckoutCustomerAssociatePayloadQuery checkout(CheckoutDelegate buildQuery) {
            Query.Append("checkout ");

            Query.Append("{");
            buildQuery(new CheckoutQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// The associated customer object.
        /// </summary>
        public CheckoutCustomerAssociatePayloadQuery customer(CustomerDelegate buildQuery) {
            Query.Append("customer ");

            Query.Append("{");
            buildQuery(new CustomerQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// List of errors that occurred executing the mutation.
        /// </summary>
        public CheckoutCustomerAssociatePayloadQuery userErrors(UserErrorDelegate buildQuery) {
            Query.Append("userErrors ");

            Query.Append("{");
            buildQuery(new UserErrorQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
