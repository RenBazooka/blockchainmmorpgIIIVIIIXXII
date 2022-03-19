namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// An order is a customer’s completed request to purchase one or more products from a shop. An order is created when a customer completes the checkout process, during which time they provides an email address, billing address and payment information.
    /// </summary>
    public class Order : AbstractResponse, ICloneable, Node {
        /// <summary>
        /// <see ref="Order" /> Accepts deserialized json data.
        /// <see ref="Order" /> Will further parse passed in data.
        /// </summary>
        /// <param name="dataJSON">Deserialized JSON data for Order</param>
        public Order(Dictionary<string, object> dataJSON) {
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
                    case "currencyCode":

                    Data.Add(
                        key,

                        CastUtils.GetEnumValue<CurrencyCode>(dataJSON[key])
                    );

                    break;

                    case "customerLocale":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            (string) dataJSON[key]
                        );
                    }

                    break;

                    case "customerUrl":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            (string) dataJSON[key]
                        );
                    }

                    break;

                    case "discountApplications":

                    Data.Add(
                        key,

                        new DiscountApplicationConnection((Dictionary<string,object>) dataJSON[key])
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

                    case "id":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
                    );

                    break;

                    case "lineItems":

                    Data.Add(
                        key,

                        new OrderLineItemConnection((Dictionary<string,object>) dataJSON[key])
                    );

                    break;

                    case "name":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
                    );

                    break;

                    case "orderNumber":

                    Data.Add(
                        key,

                        (long) dataJSON[key]
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

                    case "processedAt":

                    Data.Add(
                        key,

                        Convert.ToDateTime(dataJSON[key])
                    );

                    break;

                    case "shippingAddress":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new MailingAddress((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "shippingDiscountAllocations":

                    Data.Add(
                        key,

                        CastUtils.CastList<List<DiscountAllocation>>((IList) dataJSON[key])
                    );

                    break;

                    case "statusUrl":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
                    );

                    break;

                    case "subtotalPrice":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            Convert.ToDecimal(dataJSON[key])
                        );
                    }

                    break;

                    case "subtotalPriceV2":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new MoneyV2((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "successfulFulfillments":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            CastUtils.CastList<List<Fulfillment>>((IList) dataJSON[key])
                        );
                    }

                    break;

                    case "totalPrice":

                    Data.Add(
                        key,

                        Convert.ToDecimal(dataJSON[key])
                    );

                    break;

                    case "totalPriceV2":

                    Data.Add(
                        key,

                        new MoneyV2((Dictionary<string,object>) dataJSON[key])
                    );

                    break;

                    case "totalRefunded":

                    Data.Add(
                        key,

                        Convert.ToDecimal(dataJSON[key])
                    );

                    break;

                    case "totalRefundedV2":

                    Data.Add(
                        key,

                        new MoneyV2((Dictionary<string,object>) dataJSON[key])
                    );

                    break;

                    case "totalShippingPrice":

                    Data.Add(
                        key,

                        Convert.ToDecimal(dataJSON[key])
                    );

                    break;

                    case "totalShippingPriceV2":

                    Data.Add(
                        key,

                        new MoneyV2((Dictionary<string,object>) dataJSON[key])
                    );

                    break;

                    case "totalTax":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            Convert.ToDecimal(dataJSON[key])
                        );
                    }

                    break;

                    case "totalTaxV2":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new MoneyV2((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;
                }
            }
        }

        /// <summary>
        /// The code of the currency used for the payment.
        /// </summary>
        public CurrencyCode currencyCode() {
            return Get<CurrencyCode>("currencyCode");
        }

        /// <summary>
        /// The locale code in which this specific order happened.
        /// </summary>
        public string customerLocale() {
            return Get<string>("customerLocale");
        }

        /// <summary>
        /// The unique URL that the customer can use to access the order.
        /// </summary>
        public string customerUrl() {
            return Get<string>("customerUrl");
        }

        /// <summary>
        /// Discounts that have been applied on the order.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public DiscountApplicationConnection discountApplications(string alias = null) {
            return Get<DiscountApplicationConnection>("discountApplications", alias);
        }

        /// <summary>
        /// The customer's email address.
        /// </summary>
        public string email() {
            return Get<string>("email");
        }

        /// <summary>
        /// Globally unique identifier.
        /// </summary>
        public string id() {
            return Get<string>("id");
        }

        /// <summary>
        /// List of the order’s line items.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public OrderLineItemConnection lineItems(string alias = null) {
            return Get<OrderLineItemConnection>("lineItems", alias);
        }

        /// <summary>
        /// Unique identifier for the order that appears on the order.
        /// For example, _#1000_ or _Store1001.
        /// </summary>
        public string name() {
            return Get<string>("name");
        }

        /// <summary>
        /// A unique numeric identifier for the order for use by shop owner and customer.
        /// </summary>
        public long orderNumber() {
            return Get<long>("orderNumber");
        }

        /// <summary>
        /// The customer's phone number for receiving SMS notifications.
        /// </summary>
        public string phone() {
            return Get<string>("phone");
        }

        /// <summary>
        /// The date and time when the order was imported.
        /// This value can be set to dates in the past when importing from other systems.
        /// If no value is provided, it will be auto-generated based on current date and time.
        /// </summary>
        public DateTime? processedAt() {
            return Get<DateTime?>("processedAt");
        }

        /// <summary>
        /// The address to where the order will be shipped.
        /// </summary>
        public MailingAddress shippingAddress() {
            return Get<MailingAddress>("shippingAddress");
        }

        /// <summary>
        /// The discounts that have been allocated onto the shipping line by discount applications.
        /// </summary>
        public List<DiscountAllocation> shippingDiscountAllocations() {
            return Get<List<DiscountAllocation>>("shippingDiscountAllocations");
        }

        /// <summary>
        /// The unique URL for the order's status page.
        /// </summary>
        public string statusUrl() {
            return Get<string>("statusUrl");
        }

        /// \deprecated Use `subtotalPriceV2` instead
        /// <summary>
        /// Price of the order before shipping and taxes.
        /// </summary>
        public decimal subtotalPrice() {
            return Get<decimal>("subtotalPrice");
        }

        /// <summary>
        /// Price of the order before duties, shipping and taxes.
        /// </summary>
        public MoneyV2 subtotalPriceV2() {
            return Get<MoneyV2>("subtotalPriceV2");
        }

        /// <summary>
        /// List of the order’s successful fulfillments.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public List<Fulfillment> successfulFulfillments(string alias = null) {
            return Get<List<Fulfillment>>("successfulFulfillments", alias);
        }

        /// \deprecated Use `totalPriceV2` instead
        /// <summary>
        /// The sum of all the prices of all the items in the order, taxes and discounts included (must be positive).
        /// </summary>
        public decimal totalPrice() {
            return Get<decimal>("totalPrice");
        }

        /// <summary>
        /// The sum of all the prices of all the items in the order, duties, taxes and discounts included (must be positive).
        /// </summary>
        public MoneyV2 totalPriceV2() {
            return Get<MoneyV2>("totalPriceV2");
        }

        /// \deprecated Use `totalRefundedV2` instead
        /// <summary>
        /// The total amount that has been refunded.
        /// </summary>
        public decimal totalRefunded() {
            return Get<decimal>("totalRefunded");
        }

        /// <summary>
        /// The total amount that has been refunded.
        /// </summary>
        public MoneyV2 totalRefundedV2() {
            return Get<MoneyV2>("totalRefundedV2");
        }

        /// \deprecated Use `totalShippingPriceV2` instead
        /// <summary>
        /// The total cost of shipping.
        /// </summary>
        public decimal totalShippingPrice() {
            return Get<decimal>("totalShippingPrice");
        }

        /// <summary>
        /// The total cost of shipping.
        /// </summary>
        public MoneyV2 totalShippingPriceV2() {
            return Get<MoneyV2>("totalShippingPriceV2");
        }

        /// \deprecated Use `totalTaxV2` instead
        /// <summary>
        /// The total cost of taxes.
        /// </summary>
        public decimal totalTax() {
            return Get<decimal>("totalTax");
        }

        /// <summary>
        /// The total cost of taxes.
        /// </summary>
        public MoneyV2 totalTaxV2() {
            return Get<MoneyV2>("totalTaxV2");
        }

        public object Clone() {
            return new Order(DataJSON);
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
