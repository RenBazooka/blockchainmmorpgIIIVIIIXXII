namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// The author of an article.
    /// </summary>
    public class ArticleAuthor : AbstractResponse, ICloneable {
        /// <summary>
        /// <see ref="ArticleAuthor" /> Accepts deserialized json data.
        /// <see ref="ArticleAuthor" /> Will further parse passed in data.
        /// </summary>
        /// <param name="dataJSON">Deserialized JSON data for ArticleAuthor</param>
        public ArticleAuthor(Dictionary<string, object> dataJSON) {
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
                    case "bio":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            (string) dataJSON[key]
                        );
                    }

                    break;

                    case "email":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
                    );

                    break;

                    case "firstName":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
                    );

                    break;

                    case "lastName":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
                    );

                    break;

                    case "name":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
                    );

                    break;
                }
            }
        }

        /// <summary>
        /// The author's bio.
        /// </summary>
        public string bio() {
            return Get<string>("bio");
        }

        /// <summary>
        /// The author’s email.
        /// </summary>
        public string email() {
            return Get<string>("email");
        }

        /// <summary>
        /// The author's first name.
        /// </summary>
        public string firstName() {
            return Get<string>("firstName");
        }

        /// <summary>
        /// The author's last name.
        /// </summary>
        public string lastName() {
            return Get<string>("lastName");
        }

        /// <summary>
        /// The author's full name.
        /// </summary>
        public string name() {
            return Get<string>("name");
        }

        public object Clone() {
            return new ArticleAuthor(DataJSON);
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
