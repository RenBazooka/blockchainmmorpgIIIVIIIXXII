namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// Tracking information associated with the fulfillment.
    /// </summary>
    public class FulfillmentTrackingInfo : AbstractResponse, ICloneable {
        /// <summary>
        /// <see ref="FulfillmentTrackingInfo" /> Accepts deserialized json data.
        /// <see ref="FulfillmentTrackingInfo" /> Will further parse passed in data.
        /// </summary>
        /// <param name="dataJSON">Deserialized JSON data for FulfillmentTrackingInfo</param>
        public FulfillmentTrackingInfo(Dictionary<string, object> dataJSON) {
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
                    case "number":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            (string) dataJSON[key]
                        );
                    }

                    break;

                    case "url":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            (string) dataJSON[key]
                        );
                    }

                    break;
                }
            }
        }

        /// <summary>
        /// The tracking number of the fulfillment.
        /// </summary>
        public string number() {
            return Get<string>("number");
        }

        /// <summary>
        /// The URL to track the fulfillment.
        /// </summary>
        public string url() {
            return Get<string>("url");
        }

        public object Clone() {
            return new FulfillmentTrackingInfo(DataJSON);
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
