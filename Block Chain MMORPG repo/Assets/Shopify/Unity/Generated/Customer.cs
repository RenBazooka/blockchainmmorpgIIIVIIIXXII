namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// A customer represents a customer account with the shop. Customer accounts store contact information for the customer, saving logged-in customers the trouble of having to provide it at every checkout.
    /// </summary>
    public class Customer : AbstractResponse, ICloneable {
        /// <summary>
        /// <see ref="Customer" /> Accepts deserialized json data.
        /// <see ref="Customer" /> Will further parse passed in data.
        /// </summary>
        /// <param name="dataJSON">Deserialized JSON data for Customer</param>
        public Customer(Dictionary<string, object> dataJSON) {
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
                    case "acceptsMarketing":

                    Data.Add(
                        key,

                        (bool) dataJSON[key]
                    );

                    break;

                    case "addresses":

                    Data.Add(
                        key,

                        new MailingAddressConnection((Dictionary<string,object>) dataJSON[key])
                    );

                    break;

                    case "createdAt":

                    Data.Add(
                        key,

                        Convert.ToDateTime(dataJSON[key])
                    );

                    break;

                    case "defaultAddress":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new MailingAddress((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "displayName":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
                    );

                    break;

                    case "email":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            (string) dataJSON[key]
                        );
                    }

                    break;

                    case "firstName":

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

                    case "lastIncompleteCheckout":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new Checkout((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "lastName":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            (string) dataJSON[key]
                        );
                    }

                    break;

                    case "orders":

                    Data.Add(
                        key,

                        new OrderConnection((Dictionary<string,object>) dataJSON[key])
                    );

                    break;

                    case "phone":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            (string) dataJSON[key]
                        );
                    }

                    break;

                    case "tags":

                    Data.Add(
                        key,

                        CastUtils.CastList<List<string>>((IList) dataJSON[key])
                    );

                    break;

                    case "updatedAt":

                    Data.Add(
                        key,

                        Convert.ToDateTime(dataJSON[key])
                    );

                    break;
                }
            }
        }

        /// <summary>
        /// Indicates whether the customer has consented to be sent marketing material via email.
        /// </summary>
        public bool acceptsMarketing() {
            return Get<bool>("acceptsMarketing");
        }

        /// <summary>
        /// A list of addresses for the customer.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public MailingAddressConnection addresses(string alias = null) {
            return Get<MailingAddressConnection>("addresses", alias);
        }

        /// <summary>
        /// The date and time when the customer was created.
        /// </summary>
        public DateTime? createdAt() {
            return Get<DateTime?>("createdAt");
        }

        /// <summary>
        /// The customer’s default address.
        /// </summary>
        public MailingAddress defaultAddress() {
            return Get<MailingAddress>("defaultAddress");
        }

        /// <summary>
        /// The customer’s name, email or phone number.
        /// </summary>
        public string displayName() {
            return Get<string>("displayName");
        }

        /// <summary>
        /// The customer’s email address.
        /// </summary>
        public string email() {
            return Get<string>("email");
        }

        /// <summary>
        /// The customer’s first name.
        /// </summary>
        public string firstName() {
            return Get<string>("firstName");
        }

        /// <summary>
        /// A unique identifier for the customer.
        /// </summary>
        public string id() {
            return Get<string>("id");
        }

        /// <summary>
        /// The customer's most recently updated, incomplete checkout.
        /// </summary>
        public Checkout lastIncompleteCheckout() {
            return Get<Checkout>("lastIncompleteCheckout");
        }

        /// <summary>
        /// The customer’s last name.
        /// </summary>
        public string lastName() {
            return Get<string>("lastName");
        }

        /// <summary>
        /// The orders associated with the customer.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public OrderConnection orders(string alias = null) {
            return Get<OrderConnection>("orders", alias);
        }

        /// <summary>
        /// The customer’s phone number.
        /// </summary>
        public string phone() {
            return Get<string>("phone");
        }

        /// <summary>
        /// A comma separated list of tags that have been added to the customer.
        /// Additional access scope required: unauthenticated_read_customer_tags.
        /// </summary>
        public List<string> tags() {
            return Get<List<string>>("tags");
        }

        /// <summary>
        /// The date and time when the customer information was updated.
        /// </summary>
        public DateTime? updatedAt() {
            return Get<DateTime?>("updatedAt");
        }

        public object Clone() {
            return new Customer(DataJSON);
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
