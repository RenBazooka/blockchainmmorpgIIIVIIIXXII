namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// The compare-at price and price of a variant sharing a currency.
    /// </summary>
    public class ProductVariantPricePair : AbstractResponse, ICloneable {
        /// <summary>
        /// <see ref="ProductVariantPricePair" /> Accepts deserialized json data.
        /// <see ref="ProductVariantPricePair" /> Will further parse passed in data.
        /// </summary>
        /// <param name="dataJSON">Deserialized JSON data for ProductVariantPricePair</param>
        public ProductVariantPricePair(Dictionary<string, object> dataJSON) {
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
                    case "compareAtPrice":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new MoneyV2((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "price":

                    Data.Add(
                        key,

                        new MoneyV2((Dictionary<string,object>) dataJSON[key])
                    );

                    break;
                }
            }
        }

        /// <summary>
        /// The compare-at price of the variant with associated currency.
        /// </summary>
        public MoneyV2 compareAtPrice() {
            return Get<MoneyV2>("compareAtPrice");
        }

        /// <summary>
        /// The price of the variant with associated currency.
        /// </summary>
        public MoneyV2 price() {
            return Get<MoneyV2>("price");
        }

        public object Clone() {
            return new ProductVariantPricePair(DataJSON);
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
