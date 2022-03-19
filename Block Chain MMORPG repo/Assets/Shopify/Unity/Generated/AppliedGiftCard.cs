namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// Details about the gift card used on the checkout.
    /// </summary>
    public class AppliedGiftCard : AbstractResponse, ICloneable, Node {
        /// <summary>
        /// <see ref="AppliedGiftCard" /> Accepts deserialized json data.
        /// <see ref="AppliedGiftCard" /> Will further parse passed in data.
        /// </summary>
        /// <param name="dataJSON">Deserialized JSON data for AppliedGiftCard</param>
        public AppliedGiftCard(Dictionary<string, object> dataJSON) {
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
                    case "amountUsed":

                    Data.Add(
                        key,

                        Convert.ToDecimal(dataJSON[key])
                    );

                    break;

                    case "amountUsedV2":

                    Data.Add(
                        key,

                        new MoneyV2((Dictionary<string,object>) dataJSON[key])
                    );

                    break;

                    case "balance":

                    Data.Add(
                        key,

                        Convert.ToDecimal(dataJSON[key])
                    );

                    break;

                    case "balanceV2":

                    Data.Add(
                        key,

                        new MoneyV2((Dictionary<string,object>) dataJSON[key])
                    );

                    break;

                    case "id":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
                    );

                    break;

                    case "lastCharacters":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
                    );

                    break;

                    case "presentmentAmountUsed":

                    Data.Add(
                        key,

                        new MoneyV2((Dictionary<string,object>) dataJSON[key])
                    );

                    break;
                }
            }
        }

        /// \deprecated Use `amountUsedV2` instead
        /// <summary>
        /// The amount that was taken from the gift card by applying it.
        /// </summary>
        public decimal amountUsed() {
            return Get<decimal>("amountUsed");
        }

        /// <summary>
        /// The amount that was taken from the gift card by applying it.
        /// </summary>
        public MoneyV2 amountUsedV2() {
            return Get<MoneyV2>("amountUsedV2");
        }

        /// \deprecated Use `balanceV2` instead
        /// <summary>
        /// The amount left on the gift card.
        /// </summary>
        public decimal balance() {
            return Get<decimal>("balance");
        }

        /// <summary>
        /// The amount left on the gift card.
        /// </summary>
        public MoneyV2 balanceV2() {
            return Get<MoneyV2>("balanceV2");
        }

        /// <summary>
        /// Globally unique identifier.
        /// </summary>
        public string id() {
            return Get<string>("id");
        }

        /// <summary>
        /// The last characters of the gift card.
        /// </summary>
        public string lastCharacters() {
            return Get<string>("lastCharacters");
        }

        /// <summary>
        /// The amount that was applied to the checkout in its currency.
        /// </summary>
        public MoneyV2 presentmentAmountUsed() {
            return Get<MoneyV2>("presentmentAmountUsed");
        }

        public object Clone() {
            return new AppliedGiftCard(DataJSON);
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
