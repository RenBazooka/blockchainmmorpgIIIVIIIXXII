namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// An amount discounting the line that has been allocated by a discount.
    /// </summary>
    public class DiscountAllocation : AbstractResponse, ICloneable {
        /// <summary>
        /// <see ref="DiscountAllocation" /> Accepts deserialized json data.
        /// <see ref="DiscountAllocation" /> Will further parse passed in data.
        /// </summary>
        /// <param name="dataJSON">Deserialized JSON data for DiscountAllocation</param>
        public DiscountAllocation(Dictionary<string, object> dataJSON) {
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
                    case "allocatedAmount":

                    Data.Add(
                        key,

                        new MoneyV2((Dictionary<string,object>) dataJSON[key])
                    );

                    break;

                    case "discountApplication":

                    Data.Add(
                        key,

                        UnknownDiscountApplication.Create((Dictionary<string,object>) dataJSON[key])
                    );

                    break;
                }
            }
        }

        /// <summary>
        /// Amount of discount allocated.
        /// </summary>
        public MoneyV2 allocatedAmount() {
            return Get<MoneyV2>("allocatedAmount");
        }

        /// <summary>
        /// The discount this allocated amount originated from.
        /// </summary>
        public DiscountApplication discountApplication() {
            return Get<DiscountApplication>("discountApplication");
        }

        public object Clone() {
            return new DiscountAllocation(DataJSON);
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
