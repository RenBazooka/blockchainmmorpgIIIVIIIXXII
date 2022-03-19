namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void CheckoutGiftCardRemovePayloadDelegate(CheckoutGiftCardRemovePayloadQuery query);

    /// <summary>
    /// Return type for `checkoutGiftCardRemove` mutation.
    /// </summary>
    public class CheckoutGiftCardRemovePayloadQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="CheckoutGiftCardRemovePayloadQuery" /> is used to build queries. Typically
        /// <see cref="CheckoutGiftCardRemovePayloadQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public CheckoutGiftCardRemovePayloadQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// The updated checkout object.
        /// </summary>
        public CheckoutGiftCardRemovePayloadQuery checkout(CheckoutDelegate buildQuery) {
            Query.Append("checkout ");

            Query.Append("{");
            buildQuery(new CheckoutQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// List of errors that occurred executing the mutation.
        /// </summary>
        public CheckoutGiftCardRemovePayloadQuery checkoutUserErrors(CheckoutUserErrorDelegate buildQuery) {
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
        public CheckoutGiftCardRemovePayloadQuery userErrors(UserErrorDelegate buildQuery) {
            Log.DeprecatedQueryField("CheckoutGiftCardRemovePayload", "userErrors", "Use `checkoutUserErrors` instead");

            Query.Append("userErrors ");

            Query.Append("{");
            buildQuery(new UserErrorQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
