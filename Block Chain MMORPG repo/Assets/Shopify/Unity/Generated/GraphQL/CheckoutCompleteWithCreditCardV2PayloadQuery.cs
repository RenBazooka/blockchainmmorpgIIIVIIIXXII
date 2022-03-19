namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void CheckoutCompleteWithCreditCardV2payloadDelegate(CheckoutCompleteWithCreditCardV2payloadQuery query);

    /// <summary>
    /// Return type for `checkoutCompleteWithCreditCardV2` mutation.
    /// </summary>
    public class CheckoutCompleteWithCreditCardV2payloadQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="CheckoutCompleteWithCreditCardV2payloadQuery" /> is used to build queries. Typically
        /// <see cref="CheckoutCompleteWithCreditCardV2payloadQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public CheckoutCompleteWithCreditCardV2payloadQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// The checkout on which the payment was applied.
        /// </summary>
        public CheckoutCompleteWithCreditCardV2payloadQuery checkout(CheckoutDelegate buildQuery) {
            Query.Append("checkout ");

            Query.Append("{");
            buildQuery(new CheckoutQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// List of errors that occurred executing the mutation.
        /// </summary>
        public CheckoutCompleteWithCreditCardV2payloadQuery checkoutUserErrors(CheckoutUserErrorDelegate buildQuery) {
            Query.Append("checkoutUserErrors ");

            Query.Append("{");
            buildQuery(new CheckoutUserErrorQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// A representation of the attempted payment.
        /// </summary>
        public CheckoutCompleteWithCreditCardV2payloadQuery payment(PaymentDelegate buildQuery) {
            Query.Append("payment ");

            Query.Append("{");
            buildQuery(new PaymentQuery(Query));
            Query.Append("}");

            return this;
        }

        /// \deprecated Use `checkoutUserErrors` instead
        /// <summary>
        /// List of errors that occurred executing the mutation.
        /// </summary>
        public CheckoutCompleteWithCreditCardV2payloadQuery userErrors(UserErrorDelegate buildQuery) {
            Log.DeprecatedQueryField("CheckoutCompleteWithCreditCardV2Payload", "userErrors", "Use `checkoutUserErrors` instead");

            Query.Append("userErrors ");

            Query.Append("{");
            buildQuery(new UserErrorQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
