namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// The schema’s entry-point for queries. This acts as the public, top-level API from which all queries must start.
    /// </summary>
    public class QueryRoot : AbstractResponse, ICloneable {
        /// <summary>
        /// <see ref="QueryRoot" /> Accepts deserialized json data.
        /// <see ref="QueryRoot" /> Will further parse passed in data.
        /// </summary>
        /// <param name="dataJSON">Deserialized JSON data for QueryRoot</param>
        public QueryRoot(Dictionary<string, object> dataJSON) {
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

                    case "blogByHandle":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new Blog((Dictionary<string,object>) dataJSON[key])
                        );
                    }

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

                    case "node":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            UnknownNode.Create((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "nodes":

                    Data.Add(
                        key,

                        DataToNodeList(dataJSON[key])
                    );

                    break;

                    case "pageByHandle":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new Page((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "pages":

                    Data.Add(
                        key,

                        new PageConnection((Dictionary<string,object>) dataJSON[key])
                    );

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

                    case "productRecommendations":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            CastUtils.CastList<List<Product>>((IList) dataJSON[key])
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

                    case "publicApiVersions":

                    Data.Add(
                        key,

                        CastUtils.CastList<List<ApiVersion>>((IList) dataJSON[key])
                    );

                    break;

                    case "shop":

                    Data.Add(
                        key,

                        new Shop((Dictionary<string,object>) dataJSON[key])
                    );

                    break;
                }
            }
        }

        /// <summary>
        /// List of the shop's articles.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public ArticleConnection articles(string alias = null) {
            return Get<ArticleConnection>("articles", alias);
        }

        /// <summary>
        /// Find a blog by its handle.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public Blog blogByHandle(string alias = null) {
            return Get<Blog>("blogByHandle", alias);
        }

        /// <summary>
        /// List of the shop's blogs.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public BlogConnection blogs(string alias = null) {
            return Get<BlogConnection>("blogs", alias);
        }

        /// <summary>
        /// Find a collection by its handle.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public Collection collectionByHandle(string alias = null) {
            return Get<Collection>("collectionByHandle", alias);
        }

        /// <summary>
        /// List of the shop’s collections.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public CollectionConnection collections(string alias = null) {
            return Get<CollectionConnection>("collections", alias);
        }

        /// <summary>
        /// Find a customer by its access token.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public Customer customer(string alias = null) {
            return Get<Customer>("customer", alias);
        }

        /// <summary>
        /// Returns a specific node by ID.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public Node node(string alias = null) {
            return Get<Node>("node", alias);
        }

        /// <summary>
        /// Returns the list of nodes with the given IDs.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public List<Node> nodes(string alias = null) {
            return Get<List<Node>>("nodes", alias);
        }

        /// <summary>
        /// Find a page by its handle.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public Page pageByHandle(string alias = null) {
            return Get<Page>("pageByHandle", alias);
        }

        /// <summary>
        /// List of the shop's pages.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public PageConnection pages(string alias = null) {
            return Get<PageConnection>("pages", alias);
        }

        /// <summary>
        /// Find a product by its handle.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public Product productByHandle(string alias = null) {
            return Get<Product>("productByHandle", alias);
        }

        /// <summary>
        /// Find recommended products related to a given `product_id`.
        /// To learn more about how recommendations are generated, see
        /// [*Showing product recommendations on product pages*](https://help.shopify.com/themes/development/recommended-products).
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public List<Product> productRecommendations(string alias = null) {
            return Get<List<Product>>("productRecommendations", alias);
        }

        /// <summary>
        /// Tags added to products.
        /// Additional access scope required: unauthenticated_read_product_tags.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public StringConnection productTags(string alias = null) {
            return Get<StringConnection>("productTags", alias);
        }

        /// <summary>
        /// List of product types for the shop's products that are published to your app.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public StringConnection productTypes(string alias = null) {
            return Get<StringConnection>("productTypes", alias);
        }

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
        /// The list of public Storefront API versions, including supported, release candidate and unstable versions.
        /// </summary>
        public List<ApiVersion> publicApiVersions() {
            return Get<List<ApiVersion>>("publicApiVersions");
        }

        /// <summary>
        /// The shop associated with the storefront access token.
        /// </summary>
        public Shop shop() {
            return Get<Shop>("shop");
        }

        public object Clone() {
            return new QueryRoot(DataJSON);
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
