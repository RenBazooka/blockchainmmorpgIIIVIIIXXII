namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// The value of the percentage pricing object.
    /// </summary>
    public class PricingPercentageValue : AbstractResponse, ICloneable {
        /// <summary>
        /// <see ref="PricingPercentageValue" /> Accepts deserialized json data.
        /// <see ref="PricingPercentageValue" /> Will further parse passed in data.
        /// </summary>
        /// <param name="dataJSON">Deserialized JSON data for PricingPercentageValue</param>
        public PricingPercentageValue(Dictionary<string, object> dataJSON) {
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
                    case "percentage":

                    Data.Add(
                        key,

                        (double) dataJSON[key]
                    );

                    break;
                }
            }
        }

        /// <summary>
        /// The percentage value of the object.
        /// </summary>
        public double percentage() {
            return Get<double>("percentage");
        }

        public object Clone() {
            return new PricingPercentageValue(DataJSON);
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
