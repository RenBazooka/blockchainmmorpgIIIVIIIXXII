namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// A shipping rate to be applied to a checkout.
    /// </summary>
    public class ShippingRate : AbstractResponse, ICloneable {
        /// <summary>
        /// <see ref="ShippingRate" /> Accepts deserialized json data.
        /// <see ref="ShippingRate" /> Will further parse passed in data.
        /// </summary>
        /// <param name="dataJSON">Deserialized JSON data for ShippingRate</param>
        public ShippingRate(Dictionary<string, object> dataJSON) {
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
                    case "handle":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
                    );

                    break;

                    case "price":

                    Data.Add(
                        key,

                        Convert.ToDecimal(dataJSON[key])
                    );

                    break;

                    case "priceV2":

                    Data.Add(
                        key,

                        new MoneyV2((Dictionary<string,object>) dataJSON[key])
                    );

                    break;

                    case "title":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
                    );

                    break;
                }
            }
        }

        /// <summary>
        /// Human-readable unique identifier for this shipping rate.
        /// </summary>
        public string handle() {
            return Get<string>("handle");
        }

        /// \deprecated Use `priceV2` instead
        /// <summary>
        /// Price of this shipping rate.
        /// </summary>
        public decimal price() {
            return Get<decimal>("price");
        }

        /// <summary>
        /// Price of this shipping rate.
        /// </summary>
        public MoneyV2 priceV2() {
            return Get<MoneyV2>("priceV2");
        }

        /// <summary>
        /// Title of this shipping rate.
        /// </summary>
        public string title() {
            return Get<string>("title");
        }

        public object Clone() {
            return new ShippingRate(DataJSON);
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
