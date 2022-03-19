namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// Return type for `customerAccessTokenDelete` mutation.
    /// </summary>
    public class CustomerAccessTokenDeletePayload : AbstractResponse, ICloneable {
        /// <summary>
        /// <see ref="CustomerAccessTokenDeletePayload" /> Accepts deserialized json data.
        /// <see ref="CustomerAccessTokenDeletePayload" /> Will further parse passed in data.
        /// </summary>
        /// <param name="dataJSON">Deserialized JSON data for CustomerAccessTokenDeletePayload</param>
        public CustomerAccessTokenDeletePayload(Dictionary<string, object> dataJSON) {
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
                    case "deletedAccessToken":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            (string) dataJSON[key]
                        );
                    }

                    break;

                    case "deletedCustomerAccessTokenId":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            (string) dataJSON[key]
                        );
                    }

                    break;

                    case "userErrors":

                    Data.Add(
                        key,

                        CastUtils.CastList<List<UserError>>((IList) dataJSON[key])
                    );

                    break;
                }
            }
        }

        /// <summary>
        /// The destroyed access token.
        /// </summary>
        public string deletedAccessToken() {
            return Get<string>("deletedAccessToken");
        }

        /// <summary>
        /// ID of the destroyed customer access token.
        /// </summary>
        public string deletedCustomerAccessTokenId() {
            return Get<string>("deletedCustomerAccessTokenId");
        }

        /// <summary>
        /// List of errors that occurred executing the mutation.
        /// </summary>
        public List<UserError> userErrors() {
            return Get<List<UserError>>("userErrors");
        }

        public object Clone() {
            return new CustomerAccessTokenDeletePayload(DataJSON);
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
