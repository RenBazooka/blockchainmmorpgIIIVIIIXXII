namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// Represents a single fulfillment in an order.
    /// </summary>
    public class Fulfillment : AbstractResponse, ICloneable {
        /// <summary>
        /// <see ref="Fulfillment" /> Accepts deserialized json data.
        /// <see ref="Fulfillment" /> Will further parse passed in data.
        /// </summary>
        /// <param name="dataJSON">Deserialized JSON data for Fulfillment</param>
        public Fulfillment(Dictionary<string, object> dataJSON) {
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
                    case "fulfillmentLineItems":

                    Data.Add(
                        key,

                        new FulfillmentLineItemConnection((Dictionary<string,object>) dataJSON[key])
                    );

                    break;

                    case "trackingCompany":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            (string) dataJSON[key]
                        );
                    }

                    break;

                    case "trackingInfo":

                    Data.Add(
                        key,

                        CastUtils.CastList<List<FulfillmentTrackingInfo>>((IList) dataJSON[key])
                    );

                    break;
                }
            }
        }

        /// <summary>
        /// List of the fulfillment's line items.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public FulfillmentLineItemConnection fulfillmentLineItems(string alias = null) {
            return Get<FulfillmentLineItemConnection>("fulfillmentLineItems", alias);
        }

        /// <summary>
        /// The name of the tracking company.
        /// </summary>
        public string trackingCompany() {
            return Get<string>("trackingCompany");
        }

        /// <summary>
        /// Tracking information associated with the fulfillment,
        /// such as the tracking number and tracking URL.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public List<FulfillmentTrackingInfo> trackingInfo(string alias = null) {
            return Get<List<FulfillmentTrackingInfo>>("trackingInfo", alias);
        }

        public object Clone() {
            return new Fulfillment(DataJSON);
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
