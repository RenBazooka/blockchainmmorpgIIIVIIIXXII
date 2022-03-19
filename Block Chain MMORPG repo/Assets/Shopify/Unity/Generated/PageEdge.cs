namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// An auto-generated type which holds one Page and a cursor during pagination.
    /// </summary>
    public class PageEdge : AbstractResponse, ICloneable {
        /// <summary>
        /// <see ref="PageEdge" /> Accepts deserialized json data.
        /// <see ref="PageEdge" /> Will further parse passed in data.
        /// </summary>
        /// <param name="dataJSON">Deserialized JSON data for PageEdge</param>
        public PageEdge(Dictionary<string, object> dataJSON) {
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
                    case "cursor":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
                    );

                    break;

                    case "node":

                    Data.Add(
                        key,

                        new Page((Dictionary<string,object>) dataJSON[key])
                    );

                    break;
                }
            }
        }

        /// <summary>
        /// A cursor for use in pagination.
        /// </summary>
        public string cursor() {
            return Get<string>("cursor");
        }

        /// <summary>
        /// The item at the end of PageEdge.
        /// </summary>
        public Page node() {
            return Get<Page>("node");
        }

        public object Clone() {
            return new PageEdge(DataJSON);
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
