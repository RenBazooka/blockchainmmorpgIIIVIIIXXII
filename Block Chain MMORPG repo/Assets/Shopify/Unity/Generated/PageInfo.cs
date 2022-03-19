namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// Information about pagination in a connection.
    /// </summary>
    public class PageInfo : AbstractResponse, ICloneable {
        /// <summary>
        /// <see ref="PageInfo" /> Accepts deserialized json data.
        /// <see ref="PageInfo" /> Will further parse passed in data.
        /// </summary>
        /// <param name="dataJSON">Deserialized JSON data for PageInfo</param>
        public PageInfo(Dictionary<string, object> dataJSON) {
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
                    case "hasNextPage":

                    Data.Add(
                        key,

                        (bool) dataJSON[key]
                    );

                    break;

                    case "hasPreviousPage":

                    Data.Add(
                        key,

                        (bool) dataJSON[key]
                    );

                    break;
                }
            }
        }

        /// <summary>
        /// Indicates if there are more pages to fetch.
        /// </summary>
        public bool hasNextPage() {
            return Get<bool>("hasNextPage");
        }

        /// <summary>
        /// Indicates if there are any pages prior to the current page.
        /// </summary>
        public bool hasPreviousPage() {
            return Get<bool>("hasPreviousPage");
        }

        public object Clone() {
            return new PageInfo(DataJSON);
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
