namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// Return type for `checkoutGiftCardsAppend` mutation.
    /// </summary>
    public class CheckoutGiftCardsAppendPayload : AbstractResponse, ICloneable {
        /// <summary>
        /// <see ref="CheckoutGiftCardsAppendPayload" /> Accepts deserialized json data.
        /// <see ref="CheckoutGiftCardsAppendPayload" /> Will further parse passed in data.
        /// </summary>
        /// <param name="dataJSON">Deserialized JSON data for CheckoutGiftCardsAppendPayload</param>
        public CheckoutGiftCardsAppendPayload(Dictionary<string, object> dataJSON) {
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

                    case "checkoutUserErrors":

                    Data.Add(
                        key,

                        CastUtils.CastList<List<CheckoutUserError>>((IList) dataJSON[key])
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
        /// The updated checkout object.
        /// </summary>
        public Checkout checkout() {
            return Get<Checkout>("checkout");
        }

        /// <summary>
        /// List of errors that occurred executing the mutation.
        /// </summary>
        public List<CheckoutUserError> checkoutUserErrors() {
            return Get<List<CheckoutUserError>>("checkoutUserErrors");
        }

        /// \deprecated Use `checkoutUserErrors` instead
        /// <summary>
        /// List of errors that occurred executing the mutation.
        /// </summary>
        public List<UserError> userErrors() {
            return Get<List<UserError>>("userErrors");
        }

        public object Clone() {
            return new CheckoutGiftCardsAppendPayload(DataJSON);
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
