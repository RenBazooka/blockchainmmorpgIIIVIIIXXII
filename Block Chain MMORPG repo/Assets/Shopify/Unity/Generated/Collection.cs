namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// A collection represents a grouping of products that a shop owner can create to organize them or make their shops easier to browse.
    /// </summary>
    public class Collection : AbstractResponse, ICloneable, Node {
        /// <summary>
        /// <see ref="Collection" /> Accepts deserialized json data.
        /// <see ref="Collection" /> Will further parse passed in data.
        /// </summary>
        /// <param name="dataJSON">Deserialized JSON data for Collection</param>
        public Collection(Dictionary<string, object> dataJSON) {
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
                    case "description":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
                    );

                    break;

                    case "descriptionHtml":

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

                    case "image":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new Image((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "products":

                    Data.Add(
                        key,

                        new ProductConnection((Dictionary<string,object>) dataJSON[key])
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
                }
            }
        }

        /// <summary>
        /// Stripped description of the collection, single line with HTML tags removed.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public string description(string alias = null) {
            return Get<string>("description", alias);
        }

        /// <summary>
        /// The description of the collection, complete with HTML formatting.
        /// </summary>
        public string descriptionHtml() {
            return Get<string>("descriptionHtml");
        }

        /// <summary>
        /// A human-friendly unique string for the collection automatically generated from its title.
        /// Limit of 255 characters.
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
        /// Image associated with the collection.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public Image image(string alias = null) {
            return Get<Image>("image", alias);
        }

        /// <summary>
        /// List of products in the collection.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public ProductConnection products(string alias = null) {
            return Get<ProductConnection>("products", alias);
        }

        /// <summary>
        /// The collection’s name. Limit of 255 characters.
        /// </summary>
        public string title() {
            return Get<string>("title");
        }

        /// <summary>
        /// The date and time when the collection was last modified.
        /// </summary>
        public DateTime? updatedAt() {
            return Get<DateTime?>("updatedAt");
        }

        public object Clone() {
            return new Collection(DataJSON);
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
