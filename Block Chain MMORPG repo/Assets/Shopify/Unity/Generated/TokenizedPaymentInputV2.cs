namespace Shopify.Unity {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    /// <summary>
    /// Specifies the fields required to complete a checkout with
    /// a tokenized payment.
    /// </summary>
    public class TokenizedPaymentInputV2 : InputBase {
        public const string paymentAmountFieldKey = "paymentAmount";

        public const string idempotencyKeyFieldKey = "idempotencyKey";

        public const string billingAddressFieldKey = "billingAddress";

        public const string paymentDataFieldKey = "paymentData";

        public const string testFieldKey = "test";

        public const string identifierFieldKey = "identifier";

        public const string typeFieldKey = "type";

        /// <summary>
        /// The amount and currency of the payment.
        /// </summary>
        public MoneyInput paymentAmount {
            get {
                return (MoneyInput) Get(paymentAmountFieldKey);
            }
            set {
                Set(paymentAmountFieldKey, value);
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
        /// Whether to execute the payment in test mode, if possible. Test mode is not supported in production stores. Defaults to `false`.
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

        /// <param name="paymentAmount">
        /// The amount and currency of the payment.
        /// </param>
        /// <param name="idempotencyKey">
        /// A unique client generated key used to avoid duplicate charges. When a duplicate payment is found, the original is returned instead of creating a new one.
        /// </param>
        /// <param name="billingAddress">
        /// The billing address for the payment.
        /// </param>
        /// <param name="paymentData">
        /// A simple string or JSON containing the required payment data for the tokenized payment.
        /// </param>
        /// <param name="test">
        /// Whether to execute the payment in test mode, if possible. Test mode is not supported in production stores. Defaults to `false`.
        /// </param>
        /// <param name="identifier">
        /// Public Hash Key used for AndroidPay payments only.
        /// </param>
        /// <param name="type">
        /// The type of payment token.
        /// </param>
        public TokenizedPaymentInputV2(MoneyInput paymentAmount,string idempotencyKey,MailingAddressInput billingAddress,string paymentData,string type,bool? test = null,string identifier = null) {
            Set(paymentAmountFieldKey, paymentAmount);

            Set(idempotencyKeyFieldKey, idempotencyKey);

            Set(billingAddressFieldKey, billingAddress);

            Set(paymentDataFieldKey, paymentData);

            Set(typeFieldKey, type);

            if (test != null) {
                Set(testFieldKey, test);
            }

            if (identifier != null) {
                Set(identifierFieldKey, identifier);
            }
        }

        /// <param name="paymentAmount">
        /// The amount and currency of the payment.
        /// </param>
        /// <param name="idempotencyKey">
        /// A unique client generated key used to avoid duplicate charges. When a duplicate payment is found, the original is returned instead of creating a new one.
        /// </param>
        /// <param name="billingAddress">
        /// The billing address for the payment.
        /// </param>
        /// <param name="paymentData">
        /// A simple string or JSON containing the required payment data for the tokenized payment.
        /// </param>
        /// <param name="test">
        /// Whether to execute the payment in test mode, if possible. Test mode is not supported in production stores. Defaults to `false`.
        /// </param>
        /// <param name="identifier">
        /// Public Hash Key used for AndroidPay payments only.
        /// </param>
        /// <param name="type">
        /// The type of payment token.
        /// </param>
        public TokenizedPaymentInputV2(Dictionary<string, object> dataJSON) {
            try {
                Set(paymentAmountFieldKey, dataJSON[paymentAmountFieldKey]);

                Set(idempotencyKeyFieldKey, dataJSON[idempotencyKeyFieldKey]);

                Set(billingAddressFieldKey, dataJSON[billingAddressFieldKey]);

                Set(paymentDataFieldKey, dataJSON[paymentDataFieldKey]);

                Set(typeFieldKey, dataJSON[typeFieldKey]);
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
