namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// Represents an error in the input of a mutation.
    /// </summary>
    public class UserError : AbstractResponse, ICloneable, DisplayableError {
        /// <summary>
        /// <see ref="UserError" /> Accepts deserialized json data.
        /// <see ref="UserError" /> Will further parse passed in data.
        /// </summary>
        /// <param name="dataJSON">Deserialized JSON data for UserError</param>
        public UserError(Dictionary<string, object> dataJSON) {
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
                    case "field":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            CastUtils.CastList<List<string>>((IList) dataJSON[key])
                        );
                    }

                    break;

                    case "message":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
                    );

                    break;
                }
            }
        }

        /// <summary>
        /// Path to the input field which caused the error.
        /// </summary>
        public List<string> field() {
            return Get<List<string>>("field");
        }

        /// <summary>
        /// The error message.
        /// </summary>
        public string message() {
            return Get<string>("message");
        }

        public object Clone() {
            return new UserError(DataJSON);
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
