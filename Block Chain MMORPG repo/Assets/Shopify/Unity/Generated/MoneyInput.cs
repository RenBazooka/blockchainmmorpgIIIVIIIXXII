namespace Shopify.Unity {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    /// <summary>
    /// Specifies the fields for a monetary value with currency.
    /// </summary>
    public class MoneyInput : InputBase {
        public const string amountFieldKey = "amount";

        public const string currencyCodeFieldKey = "currencyCode";

        /// <summary>
        /// Decimal money amount.
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
        /// Currency of the money.
        /// </summary>
        public CurrencyCode currencyCode {
            get {
                return (CurrencyCode) Get(currencyCodeFieldKey);
            }
            set {
                Set(currencyCodeFieldKey, value);
            }
        }

        /// <param name="amount">
        /// Decimal money amount.
        /// </param>
        /// <param name="currencyCode">
        /// Currency of the money.
        /// </param>
        public MoneyInput(decimal amount,CurrencyCode currencyCode) {
            Set(amountFieldKey, amount);

            Set(currencyCodeFieldKey, currencyCode);
        }

        /// <param name="amount">
        /// Decimal money amount.
        /// </param>
        /// <param name="currencyCode">
        /// Currency of the money.
        /// </param>
        public MoneyInput(Dictionary<string, object> dataJSON) {
            try {
                Set(amountFieldKey, dataJSON[amountFieldKey]);

                Set(currencyCodeFieldKey, dataJSON[currencyCodeFieldKey]);
            } catch {
                throw;
            }
        }
    }
    }
