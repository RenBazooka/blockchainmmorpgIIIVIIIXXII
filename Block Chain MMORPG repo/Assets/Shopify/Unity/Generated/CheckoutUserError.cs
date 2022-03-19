namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// Represents an error that happens during execution of a checkout mutation.
    /// </summary>
    public class CheckoutUserError : AbstractResponse, ICloneable, DisplayableError {
        /// <summary>
        /// <see ref="CheckoutUserError" /> Accepts deserialized json data.
        /// <see ref="CheckoutUserError" /> Will further parse passed in data.
        /// </summary>
        /// <param name="dataJSON">Deserialized JSON data for CheckoutUserError</param>
        public CheckoutUserError(Dictionary<string, object> dataJSON) {
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
                    case "code":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            CastUtils.GetEnumValue<CheckoutErrorCode>(dataJSON[key])
                        );
                    }

                    break;

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
        /// Error code to uniquely identify the error.
        /// </summary>
        public CheckoutErrorCode? code() {
            return Get<CheckoutErrorCode?>("code");
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
            return new CheckoutUserError(DataJSON);
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
