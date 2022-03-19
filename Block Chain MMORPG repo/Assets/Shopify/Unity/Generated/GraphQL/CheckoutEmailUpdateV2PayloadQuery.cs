namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void CheckoutEmailUpdateV2payloadDelegate(CheckoutEmailUpdateV2payloadQuery query);

    /// <summary>
    /// Return type for `checkoutEmailUpdateV2` mutation.
    /// </summary>
    public class CheckoutEmailUpdateV2payloadQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="CheckoutEmailUpdateV2payloadQuery" /> is used to build queries. Typically
        /// <see cref="CheckoutEmailUpdateV2payloadQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public CheckoutEmailUpdateV2payloadQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// The checkout object with the updated email.
        /// </summary>
        public CheckoutEmailUpdateV2payloadQuery checkout(CheckoutDelegate buildQuery) {
            Query.Append("checkout ");

            Query.Append("{");
            buildQuery(new CheckoutQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// List of errors that occurred executing the mutation.
        /// </summary>
        public CheckoutEmailUpdateV2payloadQuery checkoutUserErrors(CheckoutUserErrorDelegate buildQuery) {
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
        public CheckoutEmailUpdateV2payloadQuery userErrors(UserErrorDelegate buildQuery) {
            Log.DeprecatedQueryField("CheckoutEmailUpdateV2Payload", "userErrors", "Use `checkoutUserErrors` instead");

            Query.Append("userErrors ");

            Query.Append("{");
            buildQuery(new UserErrorQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
