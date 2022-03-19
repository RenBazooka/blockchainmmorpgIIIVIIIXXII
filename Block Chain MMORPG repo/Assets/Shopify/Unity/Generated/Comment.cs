namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// A comment on an article.
    /// </summary>
    public class Comment : AbstractResponse, ICloneable, Node {
        /// <summary>
        /// <see ref="Comment" /> Accepts deserialized json data.
        /// <see ref="Comment" /> Will further parse passed in data.
        /// </summary>
        /// <param name="dataJSON">Deserialized JSON data for Comment</param>
        public Comment(Dictionary<string, object> dataJSON) {
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
                    case "author":

                    Data.Add(
                        key,

                        new CommentAuthor((Dictionary<string,object>) dataJSON[key])
                    );

                    break;

                    case "content":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
                    );

                    break;

                    case "contentHtml":

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
                }
            }
        }

        /// <summary>
        /// The comment’s author.
        /// </summary>
        public CommentAuthor author() {
            return Get<CommentAuthor>("author");
        }

        /// <summary>
        /// Stripped content of the comment, single line with HTML tags removed.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public string content(string alias = null) {
            return Get<string>("content", alias);
        }

        /// <summary>
        /// The content of the comment, complete with HTML formatting.
        /// </summary>
        public string contentHtml() {
            return Get<string>("contentHtml");
        }

        /// <summary>
        /// Globally unique identifier.
        /// </summary>
        public string id() {
            return Get<string>("id");
        }

        public object Clone() {
            return new Comment(DataJSON);
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
