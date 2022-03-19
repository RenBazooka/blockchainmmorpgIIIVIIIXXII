namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// Return type for `customerActivate` mutation.
    /// </summary>
    public class CustomerActivatePayload : AbstractResponse, ICloneable {
        /// <summary>
        /// <see ref="CustomerActivatePayload" /> Accepts deserialized json data.
        /// <see ref="CustomerActivatePayload" /> Will further parse passed in data.
        /// </summary>
        /// <param name="dataJSON">Deserialized JSON data for CustomerActivatePayload</param>
        public CustomerActivatePayload(Dictionary<string, object> dataJSON) {
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
                    case "customer":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new Customer((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "customerAccessToken":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new CustomerAccessToken((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "customerUserErrors":

                    Data.Add(
                        key,

                        CastUtils.CastList<List<CustomerUserError>>((IList) dataJSON[key])
                    );

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
        /// The customer object.
        /// </summary>
        public Customer customer() {
            return Get<Customer>("customer");
        }

        /// <summary>
        /// A newly created customer access token object for the customer.
        /// </summary>
        public CustomerAccessToken customerAccessToken() {
            return Get<CustomerAccessToken>("customerAccessToken");
        }

        /// <summary>
        /// List of errors that occurred executing the mutation.
        /// </summary>
        public List<CustomerUserError> customerUserErrors() {
            return Get<List<CustomerUserError>>("customerUserErrors");
        }

        /// \deprecated Use `customerUserErrors` instead
        /// <summary>
        /// List of errors that occurred executing the mutation.
        /// </summary>
        public List<UserError> userErrors() {
            return Get<List<UserError>>("userErrors");
        }

        public object Clone() {
            return new CustomerActivatePayload(DataJSON);
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
