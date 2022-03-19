namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// Return type for `checkoutCompleteWithCreditCardV2` mutation.
    /// </summary>
    public class CheckoutCompleteWithCreditCardV2payload : AbstractResponse, ICloneable {
        /// <summary>
        /// <see ref="CheckoutCompleteWithCreditCardV2payload" /> Accepts deserialized json data.
        /// <see ref="CheckoutCompleteWithCreditCardV2payload" /> Will further parse passed in data.
        /// </summary>
        /// <param name="dataJSON">Deserialized JSON data for CheckoutCompleteWithCreditCardV2payload</param>
        public CheckoutCompleteWithCreditCardV2payload(Dictionary<string, object> dataJSON) {
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

                    case "payment":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new Payment((Dictionary<string,object>) dataJSON[key])
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
        /// The checkout on which the payment was applied.
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

        /// <summary>
        /// A representation of the attempted payment.
        /// </summary>
        public Payment payment() {
            return Get<Payment>("payment");
        }

        /// \deprecated Use `checkoutUserErrors` instead
        /// <summary>
        /// List of errors that occurred executing the mutation.
        /// </summary>
        public List<UserError> userErrors() {
            return Get<List<UserError>>("userErrors");
        }

        public object Clone() {
            return new CheckoutCompleteWithCreditCardV2payload(DataJSON);
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
