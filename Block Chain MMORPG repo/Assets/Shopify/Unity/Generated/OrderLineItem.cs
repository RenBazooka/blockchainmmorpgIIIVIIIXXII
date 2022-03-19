namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// Represents a single line in an order. There is one line item for each distinct product variant.
    /// </summary>
    public class OrderLineItem : AbstractResponse, ICloneable {
        /// <summary>
        /// <see ref="OrderLineItem" /> Accepts deserialized json data.
        /// <see ref="OrderLineItem" /> Will further parse passed in data.
        /// </summary>
        /// <param name="dataJSON">Deserialized JSON data for OrderLineItem</param>
        public OrderLineItem(Dictionary<string, object> dataJSON) {
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
                    case "customAttributes":

                    Data.Add(
                        key,

                        CastUtils.CastList<List<Attribute>>((IList) dataJSON[key])
                    );

                    break;

                    case "discountAllocations":

                    Data.Add(
                        key,

                        CastUtils.CastList<List<DiscountAllocation>>((IList) dataJSON[key])
                    );

                    break;

                    case "quantity":

                    Data.Add(
                        key,

                        (long) dataJSON[key]
                    );

                    break;

                    case "title":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
                    );

                    break;

                    case "variant":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new ProductVariant((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;
                }
            }
        }

        /// <summary>
        /// List of custom attributes associated to the line item.
        /// </summary>
        public List<Attribute> customAttributes() {
            return Get<List<Attribute>>("customAttributes");
        }

        /// <summary>
        /// The discounts that have been allocated onto the order line item by discount applications.
        /// </summary>
        public List<DiscountAllocation> discountAllocations() {
            return Get<List<DiscountAllocation>>("discountAllocations");
        }

        /// <summary>
        /// The number of products variants associated to the line item.
        /// </summary>
        public long quantity() {
            return Get<long>("quantity");
        }

        /// <summary>
        /// The title of the product combined with title of the variant.
        /// </summary>
        public string title() {
            return Get<string>("title");
        }

        /// <summary>
        /// The product variant object associated to the line item.
        /// </summary>
        public ProductVariant variant() {
            return Get<ProductVariant>("variant");
        }

        public object Clone() {
            return new OrderLineItem(DataJSON);
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
