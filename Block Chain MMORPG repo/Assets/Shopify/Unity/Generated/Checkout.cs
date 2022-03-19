namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// A container for all the information required to checkout items and pay.
    /// </summary>
    public class Checkout : AbstractResponse, ICloneable, Node {
        /// <summary>
        /// <see ref="Checkout" /> Accepts deserialized json data.
        /// <see ref="Checkout" /> Will further parse passed in data.
        /// </summary>
        /// <param name="dataJSON">Deserialized JSON data for Checkout</param>
        public Checkout(Dictionary<string, object> dataJSON) {
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
                    case "appliedGiftCards":

                    Data.Add(
                        key,

                        CastUtils.CastList<List<AppliedGiftCard>>((IList) dataJSON[key])
                    );

                    break;

                    case "availableShippingRates":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new AvailableShippingRates((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "completedAt":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            Convert.ToDateTime(dataJSON[key])
                        );
                    }

                    break;

                    case "createdAt":

                    Data.Add(
                        key,

                        Convert.ToDateTime(dataJSON[key])
                    );

                    break;

                    case "currencyCode":

                    Data.Add(
                        key,

                        CastUtils.GetEnumValue<CurrencyCode>(dataJSON[key])
                    );

                    break;

                    case "customAttributes":

                    Data.Add(
                        key,

                        CastUtils.CastList<List<Attribute>>((IList) dataJSON[key])
                    );

                    break;

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

                        new CheckoutLineItemConnection((Dictionary<string,object>) dataJSON[key])
                    );

                    break;

                    case "lineItemsSubtotalPrice":

                    Data.Add(
                        key,

                        new MoneyV2((Dictionary<string,object>) dataJSON[key])
                    );

                    break;

                    case "note":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            (string) dataJSON[key]
                        );
                    }

                    break;

                    case "order":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new Order((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "orderStatusUrl":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            (string) dataJSON[key]
                        );
                    }

                    break;

                    case "paymentDue":

                    Data.Add(
                        key,

                        Convert.ToDecimal(dataJSON[key])
                    );

                    break;

                    case "paymentDueV2":

                    Data.Add(
                        key,

                        new MoneyV2((Dictionary<string,object>) dataJSON[key])
                    );

                    break;

                    case "ready":

                    Data.Add(
                        key,

                        (bool) dataJSON[key]
                    );

                    break;

                    case "requiresShipping":

                    Data.Add(
                        key,

                        (bool) dataJSON[key]
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

                    case "shippingLine":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new ShippingRate((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "subtotalPrice":

                    Data.Add(
                        key,

                        Convert.ToDecimal(dataJSON[key])
                    );

                    break;

                    case "subtotalPriceV2":

                    Data.Add(
                        key,

                        new MoneyV2((Dictionary<string,object>) dataJSON[key])
                    );

                    break;

                    case "taxExempt":

                    Data.Add(
                        key,

                        (bool) dataJSON[key]
                    );

                    break;

                    case "taxesIncluded":

                    Data.Add(
                        key,

                        (bool) dataJSON[key]
                    );

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

                    case "totalTax":

                    Data.Add(
                        key,

                        Convert.ToDecimal(dataJSON[key])
                    );

                    break;

                    case "totalTaxV2":

                    Data.Add(
                        key,

                        new MoneyV2((Dictionary<string,object>) dataJSON[key])
                    );

                    break;

                    case "updatedAt":

                    Data.Add(
                        key,

                        Convert.ToDateTime(dataJSON[key])
                    );

                    break;

                    case "webUrl":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
                    );

                    break;
                }
            }
        }

        /// <summary>
        /// The gift cards used on the checkout.
        /// </summary>
        public List<AppliedGiftCard> appliedGiftCards() {
            return Get<List<AppliedGiftCard>>("appliedGiftCards");
        }

        /// <summary>
        /// The available shipping rates for this Checkout.
        /// Should only be used when checkout `requiresShipping` is `true` and
        /// the shipping address is valid.
        /// </summary>
        public AvailableShippingRates availableShippingRates() {
            return Get<AvailableShippingRates>("availableShippingRates");
        }

        /// <summary>
        /// The date and time when the checkout was completed.
        /// </summary>
        public DateTime? completedAt() {
            return Get<DateTime?>("completedAt");
        }

        /// <summary>
        /// The date and time when the checkout was created.
        /// </summary>
        public DateTime? createdAt() {
            return Get<DateTime?>("createdAt");
        }

        /// <summary>
        /// The currency code for the Checkout.
        /// </summary>
        public CurrencyCode currencyCode() {
            return Get<CurrencyCode>("currencyCode");
        }

        /// <summary>
        /// A list of extra information that is added to the checkout.
        /// </summary>
        public List<Attribute> customAttributes() {
            return Get<List<Attribute>>("customAttributes");
        }

        /// \deprecated This field will always return null. If you have an authentication token for the customer, you can use the `customer` field on the query root to retrieve it.
        /// <summary>
        /// The customer associated with the checkout.
        /// </summary>
        public Customer customer() {
            return Get<Customer>("customer");
        }

        /// <summary>
        /// Discounts that have been applied on the checkout.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public DiscountApplicationConnection discountApplications(string alias = null) {
            return Get<DiscountApplicationConnection>("discountApplications", alias);
        }

        /// <summary>
        /// The email attached to this checkout.
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
        /// A list of line item objects, each one containing information about an item in the checkout.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public CheckoutLineItemConnection lineItems(string alias = null) {
            return Get<CheckoutLineItemConnection>("lineItems", alias);
        }

        /// <summary>
        /// The sum of all the prices of all the items in the checkout. Duties, taxes, shipping and discounts excluded.
        /// </summary>
        public MoneyV2 lineItemsSubtotalPrice() {
            return Get<MoneyV2>("lineItemsSubtotalPrice");
        }

        /// <summary>
        /// The note associated with the checkout.
        /// </summary>
        public string note() {
            return Get<string>("note");
        }

        /// <summary>
        /// The resulting order from a paid checkout.
        /// </summary>
        public Order order() {
            return Get<Order>("order");
        }

        /// <summary>
        /// The Order Status Page for this Checkout, null when checkout is not completed.
        /// </summary>
        public string orderStatusUrl() {
            return Get<string>("orderStatusUrl");
        }

        /// \deprecated Use `paymentDueV2` instead
        /// <summary>
        /// The amount left to be paid. This is equal to the cost of the line items, taxes and shipping minus discounts and gift cards.
        /// </summary>
        public decimal paymentDue() {
            return Get<decimal>("paymentDue");
        }

        /// <summary>
        /// The amount left to be paid. This is equal to the cost of the line items, duties, taxes and shipping minus discounts and gift cards.
        /// </summary>
        public MoneyV2 paymentDueV2() {
            return Get<MoneyV2>("paymentDueV2");
        }

        /// <summary>
        /// Whether or not the Checkout is ready and can be completed. Checkouts may
        /// have asynchronous operations that can take time to finish. If you want
        /// to complete a checkout or ensure all the fields are populated and up to
        /// date, polling is required until the value is true.
        /// </summary>
        public bool ready() {
            return Get<bool>("ready");
        }

        /// <summary>
        /// States whether or not the fulfillment requires shipping.
        /// </summary>
        public bool requiresShipping() {
            return Get<bool>("requiresShipping");
        }

        /// <summary>
        /// The shipping address to where the line items will be shipped.
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
        /// Once a shipping rate is selected by the customer it is transitioned to a `shipping_line` object.
        /// </summary>
        public ShippingRate shippingLine() {
            return Get<ShippingRate>("shippingLine");
        }

        /// \deprecated Use `subtotalPriceV2` instead
        /// <summary>
        /// Price of the checkout before shipping and taxes.
        /// </summary>
        public decimal subtotalPrice() {
            return Get<decimal>("subtotalPrice");
        }

        /// <summary>
        /// Price of the checkout before duties, shipping and taxes.
        /// </summary>
        public MoneyV2 subtotalPriceV2() {
            return Get<MoneyV2>("subtotalPriceV2");
        }

        /// <summary>
        /// Specifies if the Checkout is tax exempt.
        /// </summary>
        public bool taxExempt() {
            return Get<bool>("taxExempt");
        }

        /// <summary>
        /// Specifies if taxes are included in the line item and shipping line prices.
        /// </summary>
        public bool taxesIncluded() {
            return Get<bool>("taxesIncluded");
        }

        /// \deprecated Use `totalPriceV2` instead
        /// <summary>
        /// The sum of all the prices of all the items in the checkout, taxes and discounts included.
        /// </summary>
        public decimal totalPrice() {
            return Get<decimal>("totalPrice");
        }

        /// <summary>
        /// The sum of all the prices of all the items in the checkout, duties, taxes and discounts included.
        /// </summary>
        public MoneyV2 totalPriceV2() {
            return Get<MoneyV2>("totalPriceV2");
        }

        /// \deprecated Use `totalTaxV2` instead
        /// <summary>
        /// The sum of all the taxes applied to the line items and shipping lines in the checkout.
        /// </summary>
        public decimal totalTax() {
            return Get<decimal>("totalTax");
        }

        /// <summary>
        /// The sum of all the taxes applied to the line items and shipping lines in the checkout.
        /// </summary>
        public MoneyV2 totalTaxV2() {
            return Get<MoneyV2>("totalTaxV2");
        }

        /// <summary>
        /// The date and time when the checkout was last updated.
        /// </summary>
        public DateTime? updatedAt() {
            return Get<DateTime?>("updatedAt");
        }

        /// <summary>
        /// The url pointing to the checkout accessible from the web.
        /// </summary>
        public string webUrl() {
            return Get<string>("webUrl");
        }

        public object Clone() {
            return new Checkout(DataJSON);
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
