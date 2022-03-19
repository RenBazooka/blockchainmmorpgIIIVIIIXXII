namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// A product represents an individual item for sale in a Shopify store. Products are often physical, but they don't have to be.
    /// For example, a digital download (such as a movie, music or ebook file) also qualifies as a product, as do services (such as equipment rental, work for hire, customization of another product or an extended warranty).
    /// </summary>
    public class Product : AbstractResponse, ICloneable, HasMetafields, Node {
        /// <summary>
        /// <see ref="Product" /> Accepts deserialized json data.
        /// <see ref="Product" /> Will further parse passed in data.
        /// </summary>
        /// <param name="dataJSON">Deserialized JSON data for Product</param>
        public Product(Dictionary<string, object> dataJSON) {
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
                    case "availableForSale":

                    Data.Add(
                        key,

                        (bool) dataJSON[key]
                    );

                    break;

                    case "collections":

                    Data.Add(
                        key,

                        new CollectionConnection((Dictionary<string,object>) dataJSON[key])
                    );

                    break;

                    case "createdAt":

                    Data.Add(
                        key,

                        Convert.ToDateTime(dataJSON[key])
                    );

                    break;

                    case "description":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
                    );

                    break;

                    case "descriptionHtml":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
                    );

                    break;

                    case "handle":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
                    );

                    break;

                    case "id":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
                    );

                    break;

                    case "images":

                    Data.Add(
                        key,

                        new ImageConnection((Dictionary<string,object>) dataJSON[key])
                    );

                    break;

                    case "media":

                    Data.Add(
                        key,

                        new MediaConnection((Dictionary<string,object>) dataJSON[key])
                    );

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

                    case "onlineStoreUrl":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            (string) dataJSON[key]
                        );
                    }

                    break;

                    case "options":

                    Data.Add(
                        key,

                        CastUtils.CastList<List<ProductOption>>((IList) dataJSON[key])
                    );

                    break;

                    case "presentmentPriceRanges":

                    Data.Add(
                        key,

                        new ProductPriceRangeConnection((Dictionary<string,object>) dataJSON[key])
                    );

                    break;

                    case "priceRange":

                    Data.Add(
                        key,

                        new ProductPriceRange((Dictionary<string,object>) dataJSON[key])
                    );

                    break;

                    case "productType":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
                    );

                    break;

                    case "publishedAt":

                    Data.Add(
                        key,

                        Convert.ToDateTime(dataJSON[key])
                    );

                    break;

                    case "tags":

                    Data.Add(
                        key,

                        CastUtils.CastList<List<string>>((IList) dataJSON[key])
                    );

                    break;

                    case "title":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
                    );

                    break;

                    case "updatedAt":

                    Data.Add(
                        key,

                        Convert.ToDateTime(dataJSON[key])
                    );

                    break;

                    case "variantBySelectedOptions":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new ProductVariant((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "variants":

                    Data.Add(
                        key,

                        new ProductVariantConnection((Dictionary<string,object>) dataJSON[key])
                    );

                    break;

                    case "vendor":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
                    );

                    break;
                }
            }
        }

        /// <summary>
        /// Indicates if at least one product variant is available for sale.
        /// </summary>
        public bool availableForSale() {
            return Get<bool>("availableForSale");
        }

        /// <summary>
        /// List of collections a product belongs to.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public CollectionConnection collections(string alias = null) {
            return Get<CollectionConnection>("collections", alias);
        }

        /// <summary>
        /// The date and time when the product was created.
        /// </summary>
        public DateTime? createdAt() {
            return Get<DateTime?>("createdAt");
        }

        /// <summary>
        /// Stripped description of the product, single line with HTML tags removed.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public string description(string alias = null) {
            return Get<string>("description", alias);
        }

        /// <summary>
        /// The description of the product, complete with HTML formatting.
        /// </summary>
        public string descriptionHtml() {
            return Get<string>("descriptionHtml");
        }

        /// <summary>
        /// A human-friendly unique string for the Product automatically generated from its title.
        /// They are used by the Liquid templating language to refer to objects.
        /// </summary>
        public string handle() {
            return Get<string>("handle");
        }

        /// <summary>
        /// Globally unique identifier.
        /// </summary>
        public string id() {
            return Get<string>("id");
        }

        /// <summary>
        /// List of images associated with the product.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public ImageConnection images(string alias = null) {
            return Get<ImageConnection>("images", alias);
        }

        /// <summary>
        /// The media associated with the product.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public MediaConnection media(string alias = null) {
            return Get<MediaConnection>("media", alias);
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
        /// The online store URL for the product.
        /// A value of `null` indicates that the product is not published to the Online Store sales channel.
        /// </summary>
        public string onlineStoreUrl() {
            return Get<string>("onlineStoreUrl");
        }

        /// <summary>
        /// List of product options.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public List<ProductOption> options(string alias = null) {
            return Get<List<ProductOption>>("options", alias);
        }

        /// <summary>
        /// List of price ranges in the presentment currencies for this shop.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public ProductPriceRangeConnection presentmentPriceRanges(string alias = null) {
            return Get<ProductPriceRangeConnection>("presentmentPriceRanges", alias);
        }

        /// <summary>
        /// The price range.
        /// </summary>
        public ProductPriceRange priceRange() {
            return Get<ProductPriceRange>("priceRange");
        }

        /// <summary>
        /// A categorization that a product can be tagged with, commonly used for filtering and searching.
        /// </summary>
        public string productType() {
            return Get<string>("productType");
        }

        /// <summary>
        /// The date and time when the product was published to the channel.
        /// </summary>
        public DateTime? publishedAt() {
            return Get<DateTime?>("publishedAt");
        }

        /// <summary>
        /// A comma separated list of tags that have been added to the product.
        /// Additional access scope required for private apps: unauthenticated_read_product_tags.
        /// </summary>
        public List<string> tags() {
            return Get<List<string>>("tags");
        }

        /// <summary>
        /// The product’s title.
        /// </summary>
        public string title() {
            return Get<string>("title");
        }

        /// <summary>
        /// The date and time when the product was last modified.
        /// A product's `updatedAt` value can change for different reasons. For example, if an order
        /// is placed for a product that has inventory tracking set up, then the inventory adjustment
        /// is counted as an update.
        /// </summary>
        public DateTime? updatedAt() {
            return Get<DateTime?>("updatedAt");
        }

        /// <summary>
        /// Find a product’s variant based on its selected options.
        /// This is useful for converting a user’s selection of product options into a single matching variant.
        /// If there is not a variant for the selected options, `null` will be returned.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public ProductVariant variantBySelectedOptions(string alias = null) {
            return Get<ProductVariant>("variantBySelectedOptions", alias);
        }

        /// <summary>
        /// List of the product’s variants.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public ProductVariantConnection variants(string alias = null) {
            return Get<ProductVariantConnection>("variants", alias);
        }

        /// <summary>
        /// The product’s vendor name.
        /// </summary>
        public string vendor() {
            return Get<string>("vendor");
        }

        public object Clone() {
            return new Product(DataJSON);
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
