namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// A product variant represents a different version of a product, such as differing sizes or differing colors.
    /// </summary>
    public class ProductVariant : AbstractResponse, ICloneable, HasMetafields, Node {
        /// <summary>
        /// <see ref="ProductVariant" /> Accepts deserialized json data.
        /// <see ref="ProductVariant" /> Will further parse passed in data.
        /// </summary>
        /// <param name="dataJSON">Deserialized JSON data for ProductVariant</param>
        public ProductVariant(Dictionary<string, object> dataJSON) {
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
                    case "available":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            (bool) dataJSON[key]
                        );
                    }

                    break;

                    case "availableForSale":

                    Data.Add(
                        key,

                        (bool) dataJSON[key]
                    );

                    break;

                    case "compareAtPrice":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            Convert.ToDecimal(dataJSON[key])
                        );
                    }

                    break;

                    case "compareAtPriceV2":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new MoneyV2((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "id":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
                    );

                    break;

                    case "image":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new Image((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "metafield":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new Metafield((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "metafields":

                    Data.Add(
                        key,

                        new MetafieldConnection((Dictionary<string,object>) dataJSON[key])
                    );

                    break;

                    case "presentmentPrices":

                    Data.Add(
                        key,

                        new ProductVariantPricePairConnection((Dictionary<string,object>) dataJSON[key])
                    );

                    break;

                    case "presentmentUnitPrices":

                    Data.Add(
                        key,

                        new MoneyV2connection((Dictionary<string,object>) dataJSON[key])
                    );

                    break;

                    case "price":

                    Data.Add(
                        key,

                        Convert.ToDecimal(dataJSON[key])
                    );

                    break;

                    case "priceV2":

                    Data.Add(
                        key,

                        new MoneyV2((Dictionary<string,object>) dataJSON[key])
                    );

                    break;

                    case "product":

                    Data.Add(
                        key,

                        new Product((Dictionary<string,object>) dataJSON[key])
                    );

                    break;

                    case "requiresShipping":

                    Data.Add(
                        key,

                        (bool) dataJSON[key]
                    );

                    break;

                    case "selectedOptions":

                    Data.Add(
                        key,

                        CastUtils.CastList<List<SelectedOption>>((IList) dataJSON[key])
                    );

                    break;

                    case "sku":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            (string) dataJSON[key]
                        );
                    }

                    break;

                    case "title":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
                    );

                    break;

                    case "unitPrice":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new MoneyV2((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "unitPriceMeasurement":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new UnitPriceMeasurement((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "weight":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            (double) dataJSON[key]
                        );
                    }

                    break;

                    case "weightUnit":

                    Data.Add(
                        key,

                        CastUtils.GetEnumValue<WeightUnit>(dataJSON[key])
                    );

                    break;
                }
            }
        }

        /// \deprecated Use `availableForSale` instead
        /// <summary>
        /// Indicates if the product variant is in stock.
        /// </summary>
        public bool? available() {
            return Get<bool?>("available");
        }

        /// <summary>
        /// Indicates if the product variant is available for sale.
        /// </summary>
        public bool availableForSale() {
            return Get<bool>("availableForSale");
        }

        /// \deprecated Use `compareAtPriceV2` instead
        /// <summary>
        /// The compare at price of the variant. This can be used to mark a variant as on sale, when `compareAtPrice` is higher than `price`.
        /// </summary>
        public decimal compareAtPrice() {
            return Get<decimal>("compareAtPrice");
        }

        /// <summary>
        /// The compare at price of the variant. This can be used to mark a variant as on sale, when `compareAtPriceV2` is higher than `priceV2`.
        /// </summary>
        public MoneyV2 compareAtPriceV2() {
            return Get<MoneyV2>("compareAtPriceV2");
        }

        /// <summary>
        /// Globally unique identifier.
        /// </summary>
        public string id() {
            return Get<string>("id");
        }

        /// <summary>
        /// Image associated with the product variant. This field falls back to the product image if no image is available.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public Image image(string alias = null) {
            return Get<Image>("image", alias);
        }

        /// <summary>
        /// The metafield associated with the resource.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public Metafield metafield(string alias = null) {
            return Get<Metafield>("metafield", alias);
        }

        /// <summary>
        /// A paginated list of metafields associated with the resource.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public MetafieldConnection metafields(string alias = null) {
            return Get<MetafieldConnection>("metafields", alias);
        }

        /// <summary>
        /// List of prices and compare-at prices in the presentment currencies for this shop.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public ProductVariantPricePairConnection presentmentPrices(string alias = null) {
            return Get<ProductVariantPricePairConnection>("presentmentPrices", alias);
        }

        /// <summary>
        /// List of unit prices in the presentment currencies for this shop.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public MoneyV2connection presentmentUnitPrices(string alias = null) {
            return Get<MoneyV2connection>("presentmentUnitPrices", alias);
        }

        /// \deprecated Use `priceV2` instead
        /// <summary>
        /// The product variant’s price.
        /// </summary>
        public decimal price() {
            return Get<decimal>("price");
        }

        /// <summary>
        /// The product variant’s price.
        /// </summary>
        public MoneyV2 priceV2() {
            return Get<MoneyV2>("priceV2");
        }

        /// <summary>
        /// The product object that the product variant belongs to.
        /// </summary>
        public Product product() {
            return Get<Product>("product");
        }

        /// <summary>
        /// Whether a customer needs to provide a shipping address when placing an order for the product variant.
        /// </summary>
        public bool requiresShipping() {
            return Get<bool>("requiresShipping");
        }

        /// <summary>
        /// List of product options applied to the variant.
        /// </summary>
        public List<SelectedOption> selectedOptions() {
            return Get<List<SelectedOption>>("selectedOptions");
        }

        /// <summary>
        /// The SKU (stock keeping unit) associated with the variant.
        /// </summary>
        public string sku() {
            return Get<string>("sku");
        }

        /// <summary>
        /// The product variant’s title.
        /// </summary>
        public string title() {
            return Get<string>("title");
        }

        /// <summary>
        /// The unit price value for the variant based on the variant's measurement.
        /// </summary>
        public MoneyV2 unitPrice() {
            return Get<MoneyV2>("unitPrice");
        }

        /// <summary>
        /// The unit price measurement for the variant.
        /// </summary>
        public UnitPriceMeasurement unitPriceMeasurement() {
            return Get<UnitPriceMeasurement>("unitPriceMeasurement");
        }

        /// <summary>
        /// The weight of the product variant in the unit system specified with `weight_unit`.
        /// </summary>
        public double? weight() {
            return Get<double?>("weight");
        }

        /// <summary>
        /// Unit of measurement for weight.
        /// </summary>
        public WeightUnit weightUnit() {
            return Get<WeightUnit>("weightUnit");
        }

        public object Clone() {
            return new ProductVariant(DataJSON);
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
