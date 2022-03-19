namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// A payment applied to a checkout.
    /// </summary>
    public class Payment : AbstractResponse, ICloneable, Node {
        /// <summary>
        /// <see ref="Payment" /> Accepts deserialized json data.
        /// <see ref="Payment" /> Will further parse passed in data.
        /// </summary>
        /// <param name="dataJSON">Deserialized JSON data for Payment</param>
        public Payment(Dictionary<string, object> dataJSON) {
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
                    case "amount":

                    Data.Add(
                        key,

                        Convert.ToDecimal(dataJSON[key])
                    );

                    break;

                    case "amountV2":

                    Data.Add(
                        key,

                        new MoneyV2((Dictionary<string,object>) dataJSON[key])
                    );

                    break;

                    case "billingAddress":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new MailingAddress((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "checkout":

                    Data.Add(
                        key,

                        new Checkout((Dictionary<string,object>) dataJSON[key])
                    );

                    break;

                    case "creditCard":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new CreditCard((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "errorMessage":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            (string) dataJSON[key]
                        );
                    }

                    break;

                    case "id":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
                    );

                    break;

                    case "idempotencyKey":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            (string) dataJSON[key]
                        );
                    }

                    break;

                    case "nextActionUrl":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            (string) dataJSON[key]
                        );
                    }

                    break;

                    case "ready":

                    Data.Add(
                        key,

                        (bool) dataJSON[key]
                    );

                    break;

                    case "test":

                    Data.Add(
                        key,

                        (bool) dataJSON[key]
                    );

                    break;

                    case "transaction":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new Transaction((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;
                }
            }
        }

        /// \deprecated Use `amountV2` instead
        /// <summary>
        /// The amount of the payment.
        /// </summary>
        public decimal amount() {
            return Get<decimal>("amount");
        }

        /// <summary>
        /// The amount of the payment.
        /// </summary>
        public MoneyV2 amountV2() {
            return Get<MoneyV2>("amountV2");
        }

        /// <summary>
        /// The billing address for the payment.
        /// </summary>
        public MailingAddress billingAddress() {
            return Get<MailingAddress>("billingAddress");
        }

        /// <summary>
        /// The checkout to which the payment belongs.
        /// </summary>
        public Checkout checkout() {
            return Get<Checkout>("checkout");
        }

        /// <summary>
        /// The credit card used for the payment in the case of direct payments.
        /// </summary>
        public CreditCard creditCard() {
            return Get<CreditCard>("creditCard");
        }

        /// <summary>
        /// A message describing a processing error during asynchronous processing.
        /// </summary>
        public string errorMessage() {
            return Get<string>("errorMessage");
        }

        /// <summary>
        /// Globally unique identifier.
        /// </summary>
        public string id() {
            return Get<string>("id");
        }

        /// <summary>
        /// A client-side generated token to identify a payment and perform idempotent operations.
        /// </summary>
        public string idempotencyKey() {
            return Get<string>("idempotencyKey");
        }

        /// <summary>
        /// The URL where the customer needs to be redirected so they can complete the 3D Secure payment flow.
        /// </summary>
        public string nextActionUrl() {
            return Get<string>("nextActionUrl");
        }

        /// <summary>
        /// Whether or not the payment is still processing asynchronously.
        /// </summary>
        public bool ready() {
            return Get<bool>("ready");
        }

        /// <summary>
        /// A flag to indicate if the payment is to be done in test mode for gateways that support it.
        /// </summary>
        public bool test() {
            return Get<bool>("test");
        }

        /// <summary>
        /// The actual transaction recorded by Shopify after having processed the payment with the gateway.
        /// </summary>
        public Transaction transaction() {
            return Get<Transaction>("transaction");
        }

        public object Clone() {
            return new Payment(DataJSON);
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
