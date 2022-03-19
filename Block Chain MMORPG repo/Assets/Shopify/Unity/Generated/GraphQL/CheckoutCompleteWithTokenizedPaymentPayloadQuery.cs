namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void CheckoutCompleteWithTokenizedPaymentPayloadDelegate(CheckoutCompleteWithTokenizedPaymentPayloadQuery query);

    /// <summary>
    /// Return type for `checkoutCompleteWithTokenizedPayment` mutation.
    /// </summary>
    public class CheckoutCompleteWithTokenizedPaymentPayloadQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="CheckoutCompleteWithTokenizedPaymentPayloadQuery" /> is used to build queries. Typically
        /// <see cref="CheckoutCompleteWithTokenizedPaymentPayloadQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public CheckoutCompleteWithTokenizedPaymentPayloadQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// The checkout on which the payment was applied.
        /// </summary>
        public CheckoutCompleteWithTokenizedPaymentPayloadQuery checkout(CheckoutDelegate buildQuery) {
            Query.Append("checkout ");

            Query.Append("{");
            buildQuery(new CheckoutQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// List of errors that occurred executing the mutation.
        /// </summary>
        public CheckoutCompleteWithTokenizedPaymentPayloadQuery checkoutUserErrors(CheckoutUserErrorDelegate buildQuery) {
            Query.Append("checkoutUserErrors ");

            Query.Append("{");
            buildQuery(new CheckoutUserErrorQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// A representation of the attempted payment.
        /// </summary>
        public CheckoutCompleteWithTokenizedPaymentPayloadQuery payment(PaymentDelegate buildQuery) {
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
        public CheckoutCompleteWithTokenizedPaymentPayloadQuery userErrors(UserErrorDelegate buildQuery) {
            Log.DeprecatedQueryField("CheckoutCompleteWithTokenizedPaymentPayload", "userErrors", "Use `checkoutUserErrors` instead");

            Query.Append("userErrors ");

            Query.Append("{");
            buildQuery(new UserErrorQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
