namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// Represents a single line item in a fulfillment. There is at most one fulfillment line item for each order line item.
    /// </summary>
    public class FulfillmentLineItem : AbstractResponse, ICloneable {
        /// <summary>
        /// <see ref="FulfillmentLineItem" /> Accepts deserialized json data.
        /// <see ref="FulfillmentLineItem" /> Will further parse passed in data.
        /// </summary>
        /// <param name="dataJSON">Deserialized JSON data for FulfillmentLineItem</param>
        public FulfillmentLineItem(Dictionary<string, object> dataJSON) {
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
                    case "lineItem":

                    Data.Add(
                        key,

                        new OrderLineItem((Dictionary<string,object>) dataJSON[key])
                    );

                    break;

                    case "quantity":

                    Data.Add(
                        key,

                        (long) dataJSON[key]
                    );

                    break;
                }
            }
        }

        /// <summary>
        /// The associated order's line item.
        /// </summary>
        public OrderLineItem lineItem() {
            return Get<OrderLineItem>("lineItem");
        }

        /// <summary>
        /// The amount fulfilled in this fulfillment.
        /// </summary>
        public long quantity() {
            return Get<long>("quantity");
        }

        public object Clone() {
            return new FulfillmentLineItem(DataJSON);
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
