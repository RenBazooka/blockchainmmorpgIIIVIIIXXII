namespace Shopify.Unity {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    /// <summary>
    /// Specifies the fields required to complete a checkout with
    /// a Shopify vaulted credit card payment.
    /// </summary>
    public class CreditCardPaymentInput : InputBase {
        public const string amountFieldKey = "amount";

        public const string idempotencyKeyFieldKey = "idempotencyKey";

        public const string billingAddressFieldKey = "billingAddress";

        public const string vaultIdFieldKey = "vaultId";

        public const string testFieldKey = "test";

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
        /// The ID returned by Shopify's Card Vault.
        /// </summary>
        public string vaultId {
            get {
                return (string) Get(vaultIdFieldKey);
            }
            set {
                Set(vaultIdFieldKey, value);
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

        /// <param name="amount">
        /// The amount of the payment.
        /// </param>
        /// <param name="idempotencyKey">
        /// A unique client generated key used to avoid duplicate charges. When a duplicate payment is found, the original is returned instead of creating a new one.
        /// </param>
        /// <param name="billingAddress">
        /// The billing address for the payment.
        /// </param>
        /// <param name="vaultId">
        /// The ID returned by Shopify's Card Vault.
        /// </param>
        /// <param name="test">
        /// Executes the payment in test mode if possible. Defaults to `false`.
        /// </param>
        public CreditCardPaymentInput(decimal amount,string idempotencyKey,MailingAddressInput billingAddress,string vaultId,bool? test = null) {
            Set(amountFieldKey, amount);

            Set(idempotencyKeyFieldKey, idempotencyKey);

            Set(billingAddressFieldKey, billingAddress);

            Set(vaultIdFieldKey, vaultId);

            if (test != null) {
                Set(testFieldKey, test);
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
        /// <param name="vaultId">
        /// The ID returned by Shopify's Card Vault.
        /// </param>
        /// <param name="test">
        /// Executes the payment in test mode if possible. Defaults to `false`.
        /// </param>
        public CreditCardPaymentInput(Dictionary<string, object> dataJSON) {
            try {
                Set(amountFieldKey, dataJSON[amountFieldKey]);

                Set(idempotencyKeyFieldKey, dataJSON[idempotencyKeyFieldKey]);

                Set(billingAddressFieldKey, dataJSON[billingAddressFieldKey]);

                Set(vaultIdFieldKey, dataJSON[vaultIdFieldKey]);
            } catch {
                throw;
            }

            if (dataJSON.ContainsKey(testFieldKey)) {
                Set(testFieldKey, dataJSON[testFieldKey]);
            }
        }
    }
    }
