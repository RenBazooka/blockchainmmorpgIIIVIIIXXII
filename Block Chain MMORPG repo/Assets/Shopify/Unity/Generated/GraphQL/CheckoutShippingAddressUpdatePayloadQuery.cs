namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void CheckoutShippingAddressUpdatePayloadDelegate(CheckoutShippingAddressUpdatePayloadQuery query);

    /// <summary>
    /// Return type for `checkoutShippingAddressUpdate` mutation.
    /// </summary>
    public class CheckoutShippingAddressUpdatePayloadQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="CheckoutShippingAddressUpdatePayloadQuery" /> is used to build queries. Typically
        /// <see cref="CheckoutShippingAddressUpdatePayloadQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public CheckoutShippingAddressUpdatePayloadQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// The updated checkout object.
        /// </summary>
        public CheckoutShippingAddressUpdatePayloadQuery checkout(CheckoutDelegate buildQuery) {
            Query.Append("checkout ");

            Query.Append("{");
            buildQuery(new CheckoutQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// List of errors that occurred executing the mutation.
        /// </summary>
        public CheckoutShippingAddressUpdatePayloadQuery checkoutUserErrors(CheckoutUserErrorDelegate buildQuery) {
            Query.Append("checkoutUserErrors ");

            Query.Append("{");
            buildQuery(new CheckoutUserErrorQuery(Query));
            Query.Append("}");

            return this;
        }

        /// \deprecated Use `checkoutUserErrors` instead
        /// <summary>
        /// List of errors that occurred executing the mutation.
        /// </summary>
        public CheckoutShippingAddressUpdatePayloadQuery userErrors(UserErrorDelegate buildQuery) {
            Log.DeprecatedQueryField("CheckoutShippingAddressUpdatePayload", "userErrors", "Use `checkoutUserErrors` instead");

            Query.Append("userErrors ");

            Query.Append("{");
            buildQuery(new UserErrorQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
