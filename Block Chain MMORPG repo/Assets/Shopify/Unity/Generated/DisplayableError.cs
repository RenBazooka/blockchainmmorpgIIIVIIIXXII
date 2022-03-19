namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// Represents an error in the input of a mutation.
    /// </summary>
    public interface DisplayableError {
        /// <summary>
        /// Path to the input field which caused the error.
        /// </summary>
        List<string> field();

        /// <summary>
        /// The error message.
        /// </summary>
        string message();
    }

    /// <summary>
    /// UnknownDisplayableError is a response object.
    /// With <see cref="UnknownDisplayableError.Create" /> you'll be able instantiate objects implementing DisplayableError.
    /// <c>UnknownDisplayableError.Create</c> will return one of the following types:
    /// <list type="bullet">
    /// <item><description><see cref="CheckoutUserError" /></description></item>
    /// <item><description><see cref="CustomerUserError" /></description></item>
    /// <item><description><see cref="UserError" /></description></item>
    /// </list>
    /// </summary>
    public class UnknownDisplayableError : AbstractResponse, ICloneable, DisplayableError {
        /// <summary>
        /// Instantiate objects implementing <see cref="DisplayableError" />. Possible types are:
        /// <list type="bullet">
        /// <item><description><see cref="CheckoutUserError" /></description></item>
        /// <item><description><see cref="CustomerUserError" /></description></item>
        /// <item><description><see cref="UserError" /></description></item>
        /// </list>
        /// </summary>
        public static DisplayableError Create(Dictionary<string, object> dataJSON) {
            string typeName = (string) dataJSON["__typename"];

            switch(typeName) {
                case "CheckoutUserError":
                return new CheckoutUserError(dataJSON);

                case "CustomerUserError":
                return new CustomerUserError(dataJSON);

                case "UserError":
                return new UserError(dataJSON);

                default:
                return new UnknownDisplayableError(dataJSON);
            }
        }

        /// <summary>
        /// <see ref="UnknownDisplayableError" /> Accepts deserialized json data.
        /// <see ref="UnknownDisplayableError" /> Will further parse passed in data.
        /// </summary>
        /// <param name="dataJSON">Deserialized JSON data for DisplayableError</param>
        public UnknownDisplayableError(Dictionary<string, object> dataJSON) {
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
            return new UnknownDisplayableError(DataJSON);
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
