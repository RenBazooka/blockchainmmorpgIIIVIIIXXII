namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// A CustomerAccessToken represents the unique token required to make modifications to the customer object.
    /// </summary>
    public class CustomerAccessToken : AbstractResponse, ICloneable {
        /// <summary>
        /// <see ref="CustomerAccessToken" /> Accepts deserialized json data.
        /// <see ref="CustomerAccessToken" /> Will further parse passed in data.
        /// </summary>
        /// <param name="dataJSON">Deserialized JSON data for CustomerAccessToken</param>
        public CustomerAccessToken(Dictionary<string, object> dataJSON) {
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
                    case "accessToken":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
                    );

                    break;

                    case "expiresAt":

                    Data.Add(
                        key,

                        Convert.ToDateTime(dataJSON[key])
                    );

                    break;
                }
            }
        }

        /// <summary>
        /// The customer’s access token.
        /// </summary>
        public string accessToken() {
            return Get<string>("accessToken");
        }

        /// <summary>
        /// The date and time when the customer access token expires.
        /// </summary>
        public DateTime? expiresAt() {
            return Get<DateTime?>("expiresAt");
        }

        public object Clone() {
            return new CustomerAccessToken(DataJSON);
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
