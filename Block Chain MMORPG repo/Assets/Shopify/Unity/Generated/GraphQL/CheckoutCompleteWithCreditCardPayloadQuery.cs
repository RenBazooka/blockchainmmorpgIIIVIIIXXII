namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void CheckoutCompleteWithCreditCardPayloadDelegate(CheckoutCompleteWithCreditCardPayloadQuery query);

    /// <summary>
    /// Return type for `checkoutCompleteWithCreditCard` mutation.
    /// </summary>
    public class CheckoutCompleteWithCreditCardPayloadQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="CheckoutCompleteWithCreditCardPayloadQuery" /> is used to build queries. Typically
        /// <see cref="CheckoutCompleteWithCreditCardPayloadQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public CheckoutCompleteWithCreditCardPayloadQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// The checkout on which the payment was applied.
        /// </summary>
        public CheckoutCompleteWithCreditCardPayloadQuery checkout(CheckoutDelegate buildQuery) {
            Query.Append("checkout ");

            Query.Append("{");
            buildQuery(new CheckoutQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// List of errors that occurred executing the mutation.
        /// </summary>
        public CheckoutCompleteWithCreditCardPayloadQuery checkoutUserErrors(CheckoutUserErrorDelegate buildQuery) {
            Query.Append("checkoutUserErrors ");

            Query.Append("{");
            buildQuery(new CheckoutUserErrorQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// A representation of the attempted payment.
        /// </summary>
        public CheckoutCompleteWithCreditCardPayloadQuery payment(PaymentDelegate buildQuery) {
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
        public CheckoutCompleteWithCreditCardPayloadQuery userErrors(UserErrorDelegate buildQuery) {
            Log.DeprecatedQueryField("CheckoutCompleteWithCreditCardPayload", "userErrors", "Use `checkoutUserErrors` instead");

            Query.Append("userErrors ");

            Query.Append("{");
            buildQuery(new UserErrorQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
