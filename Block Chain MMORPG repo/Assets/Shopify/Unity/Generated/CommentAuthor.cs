namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// The author of a comment.
    /// </summary>
    public class CommentAuthor : AbstractResponse, ICloneable {
        /// <summary>
        /// <see ref="CommentAuthor" /> Accepts deserialized json data.
        /// <see ref="CommentAuthor" /> Will further parse passed in data.
        /// </summary>
        /// <param name="dataJSON">Deserialized JSON data for CommentAuthor</param>
        public CommentAuthor(Dictionary<string, object> dataJSON) {
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
                    case "email":

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
        /// The author's email.
        /// </summary>
        public string email() {
            return Get<string>("email");
        }

        /// <summary>
        /// The author’s name.
        /// </summary>
        public string name() {
            return Get<string>("name");
        }

        public object Clone() {
            return new CommentAuthor(DataJSON);
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
