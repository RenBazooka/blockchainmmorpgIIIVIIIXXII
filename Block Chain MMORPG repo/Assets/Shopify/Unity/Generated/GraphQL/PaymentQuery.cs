namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void PaymentDelegate(PaymentQuery query);

    /// <summary>
    /// A payment applied to a checkout.
    /// </summary>
    public class PaymentQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="PaymentQuery" /> is used to build queries. Typically
        /// <see cref="PaymentQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public PaymentQuery(StringBuilder query) {
            Query = query;
        }

        /// \deprecated Use `amountV2` instead
        /// <summary>
        /// The amount of the payment.
        /// </summary>
        public PaymentQuery amount() {
            Log.DeprecatedQueryField("Payment", "amount", "Use `amountV2` instead");

            Query.Append("amount ");

            return this;
        }

        /// <summary>
        /// The amount of the payment.
        /// </summary>
        public PaymentQuery amountV2(MoneyV2Delegate buildQuery) {
            Query.Append("amountV2 ");

            Query.Append("{");
            buildQuery(new MoneyV2Query(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// The billing address for the payment.
        /// </summary>
        public PaymentQuery billingAddress(MailingAddressDelegate buildQuery) {
            Query.Append("billingAddress ");

            Query.Append("{");
            buildQuery(new MailingAddressQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// The checkout to which the payment belongs.
        /// </summary>
        public PaymentQuery checkout(CheckoutDelegate buildQuery) {
            Query.Append("checkout ");

            Query.Append("{");
            buildQuery(new CheckoutQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// The credit card used for the payment in the case of direct payments.
        /// </summary>
        public PaymentQuery creditCard(CreditCardDelegate buildQuery) {
            Query.Append("creditCard ");

            Query.Append("{");
            buildQuery(new CreditCardQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// A message describing a processing error during asynchronous processing.
        /// </summary>
        public PaymentQuery errorMessage() {
            Query.Append("errorMessage ");

            return this;
        }

        /// <summary>
        /// Globally unique identifier.
        /// </summary>
        public PaymentQuery id() {
            Query.Append("id ");

            return this;
        }

        /// <summary>
        /// A client-side generated token to identify a payment and perform idempotent operations.
        /// </summary>
        public PaymentQuery idempotencyKey() {
            Query.Append("idempotencyKey ");

            return this;
        }

        /// <summary>
        /// The URL where the customer needs to be redirected so they can complete the 3D Secure payment flow.
        /// </summary>
        public PaymentQuery nextActionUrl() {
            Query.Append("nextActionUrl ");

            return this;
        }

        /// <summary>
        /// Whether or not the payment is still processing asynchronously.
        /// </summary>
        public PaymentQuery ready() {
            Query.Append("ready ");

            return this;
        }

        /// <summary>
        /// A flag to indicate if the payment is to be done in test mode for gateways that support it.
        /// </summary>
        public PaymentQuery test() {
            Query.Append("test ");

            return this;
        }

        /// <summary>
        /// The actual transaction recorded by Shopify after having processed the payment with the gateway.
        /// </summary>
        public PaymentQuery transaction(TransactionDelegate buildQuery) {
            Query.Append("transaction ");

            Query.Append("{");
            buildQuery(new TransactionQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
