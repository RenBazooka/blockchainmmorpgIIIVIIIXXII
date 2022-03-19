namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// Represents a web address.
    /// </summary>
    public class Domain : AbstractResponse, ICloneable {
        /// <summary>
        /// <see ref="Domain" /> Accepts deserialized json data.
        /// <see ref="Domain" /> Will further parse passed in data.
        /// </summary>
        /// <param name="dataJSON">Deserialized JSON data for Domain</param>
        public Domain(Dictionary<string, object> dataJSON) {
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
                    case "host":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
                    );

                    break;

                    case "sslEnabled":

                    Data.Add(
                        key,

                        (bool) dataJSON[key]
                    );

                    break;

                    case "url":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
                    );

                    break;
                }
            }
        }

        /// <summary>
        /// The host name of the domain (eg: `example.com`).
        /// </summary>
        public string host() {
            return Get<string>("host");
        }

        /// <summary>
        /// Whether SSL is enabled or not.
        /// </summary>
        public bool sslEnabled() {
            return Get<bool>("sslEnabled");
        }

        /// <summary>
        /// The URL of the domain (eg: `https://example.com`).
        /// </summary>
        public string url() {
            return Get<string>("url");
        }

        public object Clone() {
            return new Domain(DataJSON);
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
