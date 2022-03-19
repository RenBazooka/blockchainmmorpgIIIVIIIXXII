namespace Shopify.Unity {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    /// <summary>
    /// Specifies the fields required to complete a checkout with
    /// a tokenized payment.
    /// </summary>
    public class TokenizedPaymentInput : InputBase {
        public const string amountFieldKey = "amount";

        public const string idempotencyKeyFieldKey = "idempotencyKey";

        public const string billingAddressFieldKey = "billingAddress";

        public const string typeFieldKey = "type";

        public const string paymentDataFieldKey = "paymentData";

        public const string testFieldKey = "test";

        public const string identifierFieldKey = "identifier";

        /// <summary>
        /// The amount of the payment.
        /// </summary>
        public decimal amount {
            get {
                return Convert.ToDecimal(Get(amountFieldKey));
            }
            set {
                Set(amountFieldKey, value);
            }
        }

        /// <summary>
        /// A unique client generated key used to avoid duplicate charges. When a duplicate payment is found, the original is returned instead of creating a new one.
        /// </summary>
        public string idempotencyKey {
            get {
                return (string) Get(idempotencyKeyFieldKey);
            }
            set {
                Set(idempotencyKeyFieldKey, value);
            }
        }

        /// <summary>
        /// The billing address for the payment.
        /// </summary>
        public MailingAddressInput billingAddress {
            get {
                return (MailingAddressInput) Get(billingAddressFieldKey);
            }
            set {
                Set(billingAddressFieldKey, value);
            }
        }

        /// <summary>
        /// The type of payment token.
        /// </summary>
        public string type {
            get {
                return (string) Get(typeFieldKey);
            }
            set {
                Set(typeFieldKey, value);
            }
        }

        /// <summary>
        /// A simple string or JSON containing the required payment data for the tokenized payment.
        /// </summary>
        public string paymentData {
            get {
                return (string) Get(paymentDataFieldKey);
            }
            set {
                Set(paymentDataFieldKey, value);
            }
        }

        /// <summary>
        /// Executes the payment in test mode if possible. Defaults to `false`.
        /// </summary>
        public bool? test {
            get {
                return (bool) Get(testFieldKey);
            }
            set {
                Set(testFieldKey, value);
            }
        }

        /// <summary>
        /// Public Hash Key used for AndroidPay payments only.
        /// </summary>
        public string identifier {
            get {
                return (string) Get(identifierFieldKey);
            }
            set {
                Set(identifierFieldKey, value);
            }
        }

        /// <param name="amount">
        /// The amount of the payment.
        /// </param>
        /// <param name="idempotencyKey">
        /// A unique client generated key used to avoid duplicate charges. When a duplicate payment is found, the original is returned instead of creating a new one.
        /// </param>
        /// <param name="billingAddress">
        /// The billing address for the payment.
        /// </param>
        /// <param name="type">
        /// The type of payment token.
        /// </param>
        /// <param name="paymentData">
        /// A simple string or JSON containing the required payment data for the tokenized payment.
        /// </param>
        /// <param name="test">
        /// Executes the payment in test mode if possible. Defaults to `false`.
        /// </param>
        /// <param name="identifier">
        /// Public Hash Key used for AndroidPay payments only.
        /// </param>
        public TokenizedPaymentInput(decimal amount,string idempotencyKey,MailingAddressInput billingAddress,string type,string paymentData,bool? test = null,string identifier = null) {
            Set(amountFieldKey, amount);

            Set(idempotencyKeyFieldKey, idempotencyKey);

            Set(billingAddressFieldKey, billingAddress);

            Set(typeFieldKey, type);

            Set(paymentDataFieldKey, paymentData);

            if (test != null) {
                Set(testFieldKey, test);
            }

            if (identifier != null) {
                Set(identifierFieldKey, identifier);
            }
        }

        /// <param name="amount">
        /// The amount of the payment.
        /// </param>
        /// <param name="idempotencyKey">
        /// A unique client generated key used to avoid duplicate charges. When a duplicate payment is found, the original is returned instead of creating a new one.
        /// </param>
        /// <param name="billingAddress">
        /// The billing address for the payment.
        /// </param>
        /// <param name="type">
        /// The type of payment token.
        /// </param>
        /// <param name="paymentData">
        /// A simple string or JSON containing the required payment data for the tokenized payment.
        /// </param>
        /// <param name="test">
        /// Executes the payment in test mode if possible. Defaults to `false`.
        /// </param>
        /// <param name="identifier">
        /// Public Hash Key used for AndroidPay payments only.
        /// </param>
        public TokenizedPaymentInput(Dictionary<string, object> dataJSON) {
            try {
                Set(amountFieldKey, dataJSON[amountFieldKey]);

                Set(idempotencyKeyFieldKey, dataJSON[idempotencyKeyFieldKey]);

                Set(billingAddressFieldKey, dataJSON[billingAddressFieldKey]);

                Set(typeFieldKey, dataJSON[typeFieldKey]);

                Set(paymentDataFieldKey, dataJSON[paymentDataFieldKey]);
            } catch {
                throw;
            }

            if (dataJSON.ContainsKey(testFieldKey)) {
                Set(testFieldKey, dataJSON[testFieldKey]);
            }

            if (dataJSON.ContainsKey(identifierFieldKey)) {
                Set(identifierFieldKey, dataJSON[identifierFieldKey]);
            }
        }
    }
    }
