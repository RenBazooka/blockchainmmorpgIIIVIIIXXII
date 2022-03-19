namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// Shopify merchants can create pages to hold static HTML content. Each Page object represents a custom page on the online store.
    /// </summary>
    public class Page : AbstractResponse, ICloneable, Node {
        /// <summary>
        /// <see ref="Page" /> Accepts deserialized json data.
        /// <see ref="Page" /> Will further parse passed in data.
        /// </summary>
        /// <param name="dataJSON">Deserialized JSON data for Page</param>
        public Page(Dictionary<string, object> dataJSON) {
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

                    case "bodySummary":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
                    );

                    break;

                    case "createdAt":

                    Data.Add(
                        key,

                        Convert.ToDateTime(dataJSON[key])
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

                    case "updatedAt":

                    Data.Add(
                        key,

                        Convert.ToDateTime(dataJSON[key])
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
        /// The description of the page, complete with HTML formatting.
        /// </summary>
        public string body() {
            return Get<string>("body");
        }

        /// <summary>
        /// Summary of the page body.
        /// </summary>
        public string bodySummary() {
            return Get<string>("bodySummary");
        }

        /// <summary>
        /// The timestamp of the page creation.
        /// </summary>
        public DateTime? createdAt() {
            return Get<DateTime?>("createdAt");
        }

        /// <summary>
        /// A human-friendly unique string for the page automatically generated from its title.
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
        /// The title of the page.
        /// </summary>
        public string title() {
            return Get<string>("title");
        }

        /// <summary>
        /// The timestamp of the latest page update.
        /// </summary>
        public DateTime? updatedAt() {
            return Get<DateTime?>("updatedAt");
        }

        /// <summary>
        /// The url pointing to the page accessible from the web.
        /// </summary>
        public string url() {
            return Get<string>("url");
        }

        public object Clone() {
            return new Page(DataJSON);
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
