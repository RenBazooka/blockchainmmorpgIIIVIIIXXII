namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// Return type for `checkoutLineItemsReplace` mutation.
    /// </summary>
    public class CheckoutLineItemsReplacePayload : AbstractResponse, ICloneable {
        /// <summary>
        /// <see ref="CheckoutLineItemsReplacePayload" /> Accepts deserialized json data.
        /// <see ref="CheckoutLineItemsReplacePayload" /> Will further parse passed in data.
        /// </summary>
        /// <param name="dataJSON">Deserialized JSON data for CheckoutLineItemsReplacePayload</param>
        public CheckoutLineItemsReplacePayload(Dictionary<string, object> dataJSON) {
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
                    case "checkout":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new Checkout((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "userErrors":

                    Data.Add(
                        key,

                        CastUtils.CastList<List<CheckoutUserError>>((IList) dataJSON[key])
                    );

                    break;
                }
            }
        }

        /// <summary>
        /// The updated checkout object.
        /// </summary>
        public Checkout checkout() {
            return Get<Checkout>("checkout");
        }

        /// <summary>
        /// List of errors that occurred executing the mutation.
        /// </summary>
        public List<CheckoutUserError> userErrors() {
            return Get<List<CheckoutUserError>>("userErrors");
        }

        public object Clone() {
            return new CheckoutLineItemsReplacePayload(DataJSON);
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
