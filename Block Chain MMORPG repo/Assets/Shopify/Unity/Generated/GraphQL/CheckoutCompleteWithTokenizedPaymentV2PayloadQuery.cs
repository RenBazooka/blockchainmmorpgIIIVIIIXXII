namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void CheckoutCompleteWithTokenizedPaymentV2payloadDelegate(CheckoutCompleteWithTokenizedPaymentV2payloadQuery query);

    /// <summary>
    /// Return type for `checkoutCompleteWithTokenizedPaymentV2` mutation.
    /// </summary>
    public class CheckoutCompleteWithTokenizedPaymentV2payloadQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="CheckoutCompleteWithTokenizedPaymentV2payloadQuery" /> is used to build queries. Typically
        /// <see cref="CheckoutCompleteWithTokenizedPaymentV2payloadQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public CheckoutCompleteWithTokenizedPaymentV2payloadQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// The checkout on which the payment was applied.
        /// </summary>
        public CheckoutCompleteWithTokenizedPaymentV2payloadQuery checkout(CheckoutDelegate buildQuery) {
            Query.Append("checkout ");

            Query.Append("{");
            buildQuery(new CheckoutQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// List of errors that occurred executing the mutation.
        /// </summary>
        public CheckoutCompleteWithTokenizedPaymentV2payloadQuery checkoutUserErrors(CheckoutUserErrorDelegate buildQuery) {
            Query.Append("checkoutUserErrors ");

            Query.Append("{");
            buildQuery(new CheckoutUserErrorQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// A representation of the attempted payment.
        /// </summary>
        public CheckoutCompleteWithTokenizedPaymentV2payloadQuery payment(PaymentDelegate buildQuery) {
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
        public CheckoutCompleteWithTokenizedPaymentV2payloadQuery userErrors(UserErrorDelegate buildQuery) {
            Log.DeprecatedQueryField("CheckoutCompleteWithTokenizedPaymentV2Payload", "userErrors", "Use `checkoutUserErrors` instead");

            Query.Append("userErrors ");

            Query.Append("{");
            buildQuery(new UserErrorQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
