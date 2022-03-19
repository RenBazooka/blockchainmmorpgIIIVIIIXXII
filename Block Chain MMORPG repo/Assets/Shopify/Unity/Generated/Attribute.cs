namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// Represents a generic custom attribute.
    /// </summary>
    public class Attribute : AbstractResponse, ICloneable {
        /// <summary>
        /// <see ref="Attribute" /> Accepts deserialized json data.
        /// <see ref="Attribute" /> Will further parse passed in data.
        /// </summary>
        /// <param name="dataJSON">Deserialized JSON data for Attribute</param>
        public Attribute(Dictionary<string, object> dataJSON) {
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
                    case "key":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
                    );

                    break;

                    case "value":

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
        /// Key or name of the attribute.
        /// </summary>
        public string key() {
            return Get<string>("key");
        }

        /// <summary>
        /// Value of the attribute.
        /// </summary>
        public string value() {
            return Get<string>("value");
        }

        public object Clone() {
            return new Attribute(DataJSON);
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
