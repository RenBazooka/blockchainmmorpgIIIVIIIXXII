namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// Shop represents a collection of the general settings and information about the shop.
    /// </summary>
    public class Shop : AbstractResponse, ICloneable {
        /// <summary>
        /// <see ref="Shop" /> Accepts deserialized json data.
        /// <see ref="Shop" /> Will further parse passed in data.
        /// </summary>
        /// <param name="dataJSON">Deserialized JSON data for Shop</param>
        public Shop(Dictionary<string, object> dataJSON) {
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
                    case "articles":

                    Data.Add(
                        key,

                        new ArticleConnection((Dictionary<string,object>) dataJSON[key])
                    );

                    break;

                    case "blogs":

                    Data.Add(
                        key,

                        new BlogConnection((Dictionary<string,object>) dataJSON[key])
                    );

                    break;

                    case "collectionByHandle":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new Collection((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "collections":

                    Data.Add(
                        key,

                        new CollectionConnection((Dictionary<string,object>) dataJSON[key])
                    );

                    break;

                    case "currencyCode":

                    Data.Add(
                        key,

                        CastUtils.GetEnumValue<CurrencyCode>(dataJSON[key])
                    );

                    break;

                    case "description":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            (string) dataJSON[key]
                        );
                    }

                    break;

                    case "moneyFormat":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
                    );

                    break;

                    case "name":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
                    );

                    break;

                    case "paymentSettings":

                    Data.Add(
                        key,

                        new PaymentSettings((Dictionary<string,object>) dataJSON[key])
                    );

                    break;

                    case "primaryDomain":

                    Data.Add(
                        key,

                        new Domain((Dictionary<string,object>) dataJSON[key])
                    );

                    break;

                    case "privacyPolicy":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new ShopPolicy((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "productByHandle":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new Product((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "productTags":

                    Data.Add(
                        key,

                        new StringConnection((Dictionary<string,object>) dataJSON[key])
                    );

                    break;

                    case "productTypes":

                    Data.Add(
                        key,

                        new StringConnection((Dictionary<string,object>) dataJSON[key])
                    );

                    break;

                    case "products":

                    Data.Add(
                        key,

                        new ProductConnection((Dictionary<string,object>) dataJSON[key])
                    );

                    break;

                    case "refundPolicy":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new ShopPolicy((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "shipsToCountries":

                    Data.Add(
                        key,

                        CastUtils.CastList<List<CountryCode>>((IList) dataJSON[key])
                    );

                    break;

                    case "shopifyPaymentsAccountId":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            (string) dataJSON[key]
                        );
                    }

                    break;

                    case "termsOfService":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new ShopPolicy((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;
                }
            }
        }

        /// \deprecated Use `QueryRoot.articles` instead.
        /// <summary>
        /// List of the shop' articles.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public ArticleConnection articles(string alias = null) {
            return Get<ArticleConnection>("articles", alias);
        }

        /// \deprecated Use `QueryRoot.blogs` instead.
        /// <summary>
        /// List of the shop' blogs.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public BlogConnection blogs(string alias = null) {
            return Get<BlogConnection>("blogs", alias);
        }

        /// \deprecated Use `QueryRoot.collectionByHandle` instead.
        /// <summary>
        /// Find a collection by its handle.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public Collection collectionByHandle(string alias = null) {
            return Get<Collection>("collectionByHandle", alias);
        }

        /// \deprecated Use `QueryRoot.collections` instead.
        /// <summary>
        /// List of the shop’s collections.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public CollectionConnection collections(string alias = null) {
            return Get<CollectionConnection>("collections", alias);
        }

        /// \deprecated Use `paymentSettings` instead
        /// <summary>
        /// The three-letter code for the currency that the shop accepts.
        /// </summary>
        public CurrencyCode currencyCode() {
            return Get<CurrencyCode>("currencyCode");
        }

        /// <summary>
        /// A description of the shop.
        /// </summary>
        public string description() {
            return Get<string>("description");
        }

        /// <summary>
        /// A string representing the way currency is formatted when the currency isn’t specified.
        /// </summary>
        public string moneyFormat() {
            return Get<string>("moneyFormat");
        }

        /// <summary>
        /// The shop’s name.
        /// </summary>
        public string name() {
            return Get<string>("name");
        }

        /// <summary>
        /// Settings related to payments.
        /// </summary>
        public PaymentSettings paymentSettings() {
            return Get<PaymentSettings>("paymentSettings");
        }

        /// <summary>
        /// The shop’s primary domain.
        /// </summary>
        public Domain primaryDomain() {
            return Get<Domain>("primaryDomain");
        }

        /// <summary>
        /// The shop’s privacy policy.
        /// </summary>
        public ShopPolicy privacyPolicy() {
            return Get<ShopPolicy>("privacyPolicy");
        }

        /// \deprecated Use `QueryRoot.productByHandle` instead.
        /// <summary>
        /// Find a product by its handle.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public Product productByHandle(string alias = null) {
            return Get<Product>("productByHandle", alias);
        }

        /// \deprecated Use `QueryRoot.productTags` instead.
        /// <summary>
        /// A list of tags that have been added to products.
        /// Additional access scope required: unauthenticated_read_product_tags.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public StringConnection productTags(string alias = null) {
            return Get<StringConnection>("productTags", alias);
        }

        /// \deprecated Use `QueryRoot.productTypes` instead.
        /// <summary>
        /// List of the shop’s product types.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public StringConnection productTypes(string alias = null) {
            return Get<StringConnection>("productTypes", alias);
        }

        /// \deprecated Use `QueryRoot.products` instead.
        /// <summary>
        /// List of the shop’s products.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public ProductConnection products(string alias = null) {
            return Get<ProductConnection>("products", alias);
        }

        /// <summary>
        /// The shop’s refund policy.
        /// </summary>
        public ShopPolicy refundPolicy() {
            return Get<ShopPolicy>("refundPolicy");
        }

        /// <summary>
        /// Countries that the shop ships to.
        /// </summary>
        public List<CountryCode> shipsToCountries() {
            return Get<List<CountryCode>>("shipsToCountries");
        }

        /// \deprecated Use `paymentSettings` instead
        /// <summary>
        /// The shop’s Shopify Payments account id.
        /// </summary>
        public string shopifyPaymentsAccountId() {
            return Get<string>("shopifyPaymentsAccountId");
        }

        /// <summary>
        /// The shop’s terms of service.
        /// </summary>
        public ShopPolicy termsOfService() {
            return Get<ShopPolicy>("termsOfService");
        }

        public object Clone() {
            return new Shop(DataJSON);
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
