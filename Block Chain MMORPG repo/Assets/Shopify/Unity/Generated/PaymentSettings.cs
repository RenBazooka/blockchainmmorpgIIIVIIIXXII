namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// Settings related to payments.
    /// </summary>
    public class PaymentSettings : AbstractResponse, ICloneable {
        /// <summary>
        /// <see ref="PaymentSettings" /> Accepts deserialized json data.
        /// <see ref="PaymentSettings" /> Will further parse passed in data.
        /// </summary>
        /// <param name="dataJSON">Deserialized JSON data for PaymentSettings</param>
        public PaymentSettings(Dictionary<string, object> dataJSON) {
            DataJSON = dataJSON;
            Data = new Dictionary<string,object>();

            foreach (string key in dataJSON.Keys) {
                string fieldName = key;
                Regex regexAlias = new Regex("^(.+)___.+$");
                Match match = regexAlias.Match(key);

                if (match.Success) {
                    fieldName = match.Groups[1].Value;
                }

                switch(fieldName) {
                    case "acceptedCardBrands":

                    Data.Add(
                        key,

                        CastUtils.CastList<List<CardBrand>>((IList) dataJSON[key])
                    );

                    break;

                    case "cardVaultUrl":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
                    );

                    break;

                    case "countryCode":

                    Data.Add(
                        key,

                        CastUtils.GetEnumValue<CountryCode>(dataJSON[key])
                    );

                    break;

                    case "currencyCode":

                    Data.Add(
                        key,

                        CastUtils.GetEnumValue<CurrencyCode>(dataJSON[key])
                    );

                    break;

                    case "enabledPresentmentCurrencies":

                    Data.Add(
                        key,

                        CastUtils.CastList<List<CurrencyCode>>((IList) dataJSON[key])
                    );

                    break;

                    case "shopifyPaymentsAccountId":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            (string) dataJSON[key]
                        );
                    }

                    break;

                    case "supportedDigitalWallets":

                    Data.Add(
                        key,

                        CastUtils.CastList<List<DigitalWallet>>((IList) dataJSON[key])
                    );

                    break;
                }
            }
        }

        /// <summary>
        /// List of the card brands which the shop accepts.
        /// </summary>
        public List<CardBrand> acceptedCardBrands() {
            return Get<List<CardBrand>>("acceptedCardBrands");
        }

        /// <summary>
        /// The url pointing to the endpoint to vault credit cards.
        /// </summary>
        public string cardVaultUrl() {
            return Get<string>("cardVaultUrl");
        }

        /// <summary>
        /// The country where the shop is located.
        /// </summary>
        public CountryCode countryCode() {
            return Get<CountryCode>("countryCode");
        }

        /// <summary>
        /// The three-letter code for the shop's primary currency.
        /// </summary>
        public CurrencyCode currencyCode() {
            return Get<CurrencyCode>("currencyCode");
        }

        /// <summary>
        /// A list of enabled currencies (ISO 4217 format) that the shop accepts. Merchants can enable currencies from their Shopify Payments settings in the Shopify admin.
        /// </summary>
        public List<CurrencyCode> enabledPresentmentCurrencies() {
            return Get<List<CurrencyCode>>("enabledPresentmentCurrencies");
        }

        /// <summary>
        /// The shop’s Shopify Payments account id.
        /// </summary>
        public string shopifyPaymentsAccountId() {
            return Get<string>("shopifyPaymentsAccountId");
        }

        /// <summary>
        /// List of the digital wallets which the shop supports.
        /// </summary>
        public List<DigitalWallet> supportedDigitalWallets() {
            return Get<List<DigitalWallet>>("supportedDigitalWallets");
        }

        public object Clone() {
            return new PaymentSettings(DataJSON);
        }

        private static List<Node> DataToNodeList(object data) {
            var objects = (List<object>)data;
            var nodes = new List<Node>();

            foreach (var obj in objects) {
                if (obj == null) continue;
                nodes.Add(UnknownNode.Create((Dictionary<string,object>) obj));
            }

            return nodes;
        }
    }
    }
