namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// The price range of the product.
    /// </summary>
    public class ProductPriceRange : AbstractResponse, ICloneable {
        /// <summary>
        /// <see ref="ProductPriceRange" /> Accepts deserialized json data.
        /// <see ref="ProductPriceRange" /> Will further parse passed in data.
        /// </summary>
        /// <param name="dataJSON">Deserialized JSON data for ProductPriceRange</param>
        public ProductPriceRange(Dictionary<string, object> dataJSON) {
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
                    case "maxVariantPrice":

                    Data.Add(
                        key,

                        new MoneyV2((Dictionary<string,object>) dataJSON[key])
                    );

                    break;

                    case "minVariantPrice":

                    Data.Add(
                        key,

                        new MoneyV2((Dictionary<string,object>) dataJSON[key])
                    );

                    break;
                }
            }
        }

        /// <summary>
        /// The highest variant's price.
        /// </summary>
        public MoneyV2 maxVariantPrice() {
            return Get<MoneyV2>("maxVariantPrice");
        }

        /// <summary>
        /// The lowest variant's price.
        /// </summary>
        public MoneyV2 minVariantPrice() {
            return Get<MoneyV2>("minVariantPrice");
        }

        public object Clone() {
            return new ProductPriceRange(DataJSON);
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
