namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// A version of the API.
    /// </summary>
    public class ApiVersion : AbstractResponse, ICloneable {
        /// <summary>
        /// <see ref="ApiVersion" /> Accepts deserialized json data.
        /// <see ref="ApiVersion" /> Will further parse passed in data.
        /// </summary>
        /// <param name="dataJSON">Deserialized JSON data for ApiVersion</param>
        public ApiVersion(Dictionary<string, object> dataJSON) {
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
                    case "displayName":

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

                    case "supported":

                    Data.Add(
                        key,

                        (bool) dataJSON[key]
                    );

                    break;
                }
            }
        }

        /// <summary>
        /// The human-readable name of the version.
        /// </summary>
        public string displayName() {
            return Get<string>("displayName");
        }

        /// <summary>
        /// The unique identifier of an ApiVersion. All supported API versions have a date-based (YYYY-MM) or `unstable` handle.
        /// </summary>
        public string handle() {
            return Get<string>("handle");
        }

        /// <summary>
        /// Whether the version is supported by Shopify.
        /// </summary>
        public bool supported() {
            return Get<bool>("supported");
        }

        public object Clone() {
            return new ApiVersion(DataJSON);
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
