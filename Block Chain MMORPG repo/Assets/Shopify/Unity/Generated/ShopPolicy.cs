namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// Policy that a merchant has configured for their store, such as their refund or privacy policy.
    /// </summary>
    public class ShopPolicy : AbstractResponse, ICloneable, Node {
        /// <summary>
        /// <see ref="ShopPolicy" /> Accepts deserialized json data.
        /// <see ref="ShopPolicy" /> Will further parse passed in data.
        /// </summary>
        /// <param name="dataJSON">Deserialized JSON data for ShopPolicy</param>
        public ShopPolicy(Dictionary<string, object> dataJSON) {
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
                    case "body":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
                    );

                    break;

                    case "handle":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
                    );

                    break;

                    case "id":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
                    );

                    break;

                    case "title":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
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
        /// Policy text, maximum size of 64kb.
        /// </summary>
        public string body() {
            return Get<string>("body");
        }

        /// <summary>
        /// Policy’s handle.
        /// </summary>
        public string handle() {
            return Get<string>("handle");
        }

        /// <summary>
        /// Globally unique identifier.
        /// </summary>
        public string id() {
            return Get<string>("id");
        }

        /// <summary>
        /// Policy’s title.
        /// </summary>
        public string title() {
            return Get<string>("title");
        }

        /// <summary>
        /// Public URL to the policy.
        /// </summary>
        public string url() {
            return Get<string>("url");
        }

        public object Clone() {
            return new ShopPolicy(DataJSON);
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
