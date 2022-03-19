namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void CheckoutEmailUpdatePayloadDelegate(CheckoutEmailUpdatePayloadQuery query);

    /// <summary>
    /// Return type for `checkoutEmailUpdate` mutation.
    /// </summary>
    public class CheckoutEmailUpdatePayloadQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="CheckoutEmailUpdatePayloadQuery" /> is used to build queries. Typically
        /// <see cref="CheckoutEmailUpdatePayloadQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public CheckoutEmailUpdatePayloadQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// The checkout object with the updated email.
        /// </summary>
        public CheckoutEmailUpdatePayloadQuery checkout(CheckoutDelegate buildQuery) {
            Query.Append("checkout ");

            Query.Append("{");
            buildQuery(new CheckoutQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// List of errors that occurred executing the mutation.
        /// </summary>
        public CheckoutEmailUpdatePayloadQuery checkoutUserErrors(CheckoutUserErrorDelegate buildQuery) {
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
        public CheckoutEmailUpdatePayloadQuery userErrors(UserErrorDelegate buildQuery) {
            Log.DeprecatedQueryField("CheckoutEmailUpdatePayload", "userErrors", "Use `checkoutUserErrors` instead");

            Query.Append("userErrors ");

            Query.Append("{");
            buildQuery(new UserErrorQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
