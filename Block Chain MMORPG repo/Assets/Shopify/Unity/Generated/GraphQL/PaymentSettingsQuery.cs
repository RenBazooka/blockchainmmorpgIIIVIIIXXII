namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void PaymentSettingsDelegate(PaymentSettingsQuery query);

    /// <summary>
    /// Settings related to payments.
    /// </summary>
    public class PaymentSettingsQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="PaymentSettingsQuery" /> is used to build queries. Typically
        /// <see cref="PaymentSettingsQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public PaymentSettingsQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// List of the card brands which the shop accepts.
        /// </summary>
        public PaymentSettingsQuery acceptedCardBrands() {
            Query.Append("acceptedCardBrands ");

            return this;
        }

        /// <summary>
        /// The url pointing to the endpoint to vault credit cards.
        /// </summary>
        public PaymentSettingsQuery cardVaultUrl() {
            Query.Append("cardVaultUrl ");

            return this;
        }

        /// <summary>
        /// The country where the shop is located.
        /// </summary>
        public PaymentSettingsQuery countryCode() {
            Query.Append("countryCode ");

            return this;
        }

        /// <summary>
        /// The three-letter code for the shop's primary currency.
        /// </summary>
        public PaymentSettingsQuery currencyCode() {
            Query.Append("currencyCode ");

            return this;
        }

        /// <summary>
        /// A list of enabled currencies (ISO 4217 format) that the shop accepts. Merchants can enable currencies from their Shopify Payments settings in the Shopify admin.
        /// </summary>
        public PaymentSettingsQuery enabledPresentmentCurrencies() {
            Query.Append("enabledPresentmentCurrencies ");

            return this;
        }

        /// <summary>
        /// The shop’s Shopify Payments account id.
        /// </summary>
        public PaymentSettingsQuery shopifyPaymentsAccountId() {
            Query.Append("shopifyPaymentsAccountId ");

            return this;
        }

        /// <summary>
        /// List of the digital wallets which the shop supports.
        /// </summary>
        public PaymentSettingsQuery supportedDigitalWallets() {
            Query.Append("supportedDigitalWallets ");

            return this;
        }
    }
    }
