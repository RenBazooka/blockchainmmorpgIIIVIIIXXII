namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// A collection of available shipping rates for a checkout.
    /// </summary>
    public class AvailableShippingRates : AbstractResponse, ICloneable {
        /// <summary>
        /// <see ref="AvailableShippingRates" /> Accepts deserialized json data.
        /// <see ref="AvailableShippingRates" /> Will further parse passed in data.
        /// </summary>
        /// <param name="dataJSON">Deserialized JSON data for AvailableShippingRates</param>
        public AvailableShippingRates(Dictionary<string, object> dataJSON) {
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
                    case "ready":

                    Data.Add(
                        key,

                        (bool) dataJSON[key]
                    );

                    break;

                    case "shippingRates":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            CastUtils.CastList<List<ShippingRate>>((IList) dataJSON[key])
                        );
                    }

                    break;
                }
            }
        }

        /// <summary>
        /// Whether or not the shipping rates are ready.
        /// The `shippingRates` field is `null` when this value is `false`.
        /// This field should be polled until its value becomes `true`.
        /// </summary>
        public bool ready() {
            return Get<bool>("ready");
        }

        /// <summary>
        /// The fetched shipping rates. `null` until the `ready` field is `true`.
        /// </summary>
        public List<ShippingRate> shippingRates() {
            return Get<List<ShippingRate>>("shippingRates");
        }

        public object Clone() {
            return new AvailableShippingRates(DataJSON);
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
