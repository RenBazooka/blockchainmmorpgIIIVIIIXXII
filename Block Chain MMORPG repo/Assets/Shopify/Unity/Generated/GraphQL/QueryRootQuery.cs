namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void QueryRootDelegate(QueryRootQuery query);

    /// <summary>
    /// <see cref="QueryRootQuery" /> is the root query builder. All Storefront API queries are built off of <see cref="QueryRootQuery" />.
    /// </summary>
    public class QueryRootQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="QueryRootQuery" /> constructor accepts no parameters but it will create a root
        /// query builder.
        /// </summary>
        public QueryRootQuery() {
            Query = new StringBuilder("{");
        }

        /// <summary>
        /// List of the shop's articles.
        /// </summary>
        /// <param name="first">
        /// Returns up to the first `n` elements from the list.
        /// </param>
        /// <param name="after">
        /// Returns the elements that come after the specified cursor.
        /// </param>
        /// <param name="last">
        /// Returns up to the last `n` elements from the list.
        /// </param>
        /// <param name="before">
        /// Returns the elements that come before the specified cursor.
        /// </param>
        /// <param name="reverse">
        /// Reverse the order of the underlying list.
        /// </param>
        /// <param name="sortKey">
        /// Sort the underlying list by the given key.
        /// </param>
        /// <param name="query">
        /// Supported filter parameters:
        /// - `author`
        /// - `blog_title`
        /// - `created_at`
        /// - `tag`
        /// - `updated_at`
        /// 
        /// See the detailed [search syntax](https://help.shopify.com/api/getting-started/search-syntax)
        /// for more information about using filters.
        /// </param>
        public QueryRootQuery articles(ArticleConnectionDelegate buildQuery,long? first = null,string after = null,long? last = null,string before = null,bool? reverse = null,ArticleSortKeys? sortKey = null,string queryValue = null,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("articles___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("articles ");

            Arguments args = new Arguments();

            if (first != null) {
                args.Add("first", first);
            }

            if (after != null) {
                args.Add("after", after);
            }

            if (last != null) {
                args.Add("last", last);
            }

            if (before != null) {
                args.Add("before", before);
            }

            if (reverse != null) {
                args.Add("reverse", reverse);
            }

            if (sortKey != null) {
                args.Add("sortKey", sortKey);
            }

            if (queryValue != null) {
                args.Add("query", queryValue);
            }

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new ArticleConnectionQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Find a blog by its handle.
        /// </summary>
        /// <param name="handle">
        /// The handle of the blog.
        /// </param>
        public QueryRootQuery blogByHandle(BlogDelegate buildQuery,string handle,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("blogByHandle___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("blogByHandle ");

            Arguments args = new Arguments();

            args.Add("handle", handle);

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new BlogQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// List of the shop's blogs.
        /// </summary>
        /// <param name="first">
        /// Returns up to the first `n` elements from the list.
        /// </param>
        /// <param name="after">
        /// Returns the elements that come after the specified cursor.
        /// </param>
        /// <param name="last">
        /// Returns up to the last `n` elements from the list.
        /// </param>
        /// <param name="before">
        /// Returns the elements that come before the specified cursor.
        /// </param>
        /// <param name="reverse">
        /// Reverse the order of the underlying list.
        /// </param>
        /// <param name="sortKey">
        /// Sort the underlying list by the given key.
        /// </param>
        /// <param name="query">
        /// Supported filter parameters:
        /// - `created_at`
        /// - `handle`
        /// - `title`
        /// - `updated_at`
        /// 
        /// See the detailed [search syntax](https://help.shopify.com/api/getting-started/search-syntax)
        /// for more information about using filters.
        /// </param>
        public QueryRootQuery blogs(BlogConnectionDelegate buildQuery,long? first = null,string after = null,long? last = null,string before = null,bool? reverse = null,BlogSortKeys? sortKey = null,string queryValue = null,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("blogs___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("blogs ");

            Arguments args = new Arguments();

            if (first != null) {
                args.Add("first", first);
            }

            if (after != null) {
                args.Add("after", after);
            }

            if (last != null) {
                args.Add("last", last);
            }

            if (before != null) {
                args.Add("before", before);
            }

            if (reverse != null) {
                args.Add("reverse", reverse);
            }

            if (sortKey != null) {
                args.Add("sortKey", sortKey);
            }

            if (queryValue != null) {
                args.Add("query", queryValue);
            }

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new BlogConnectionQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Find a collection by its handle.
        /// </summary>
        /// <param name="handle">
        /// The handle of the collection.
        /// </param>
        public QueryRootQuery collectionByHandle(CollectionDelegate buildQuery,string handle,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("collectionByHandle___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("collectionByHandle ");

            Arguments args = new Arguments();

            args.Add("handle", handle);

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new CollectionQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// List of the shop’s collections.
        /// </summary>
        /// <param name="first">
        /// Returns up to the first `n` elements from the list.
        /// </param>
        /// <param name="after">
        /// Returns the elements that come after the specified cursor.
        /// </param>
        /// <param name="last">
        /// Returns up to the last `n` elements from the list.
        /// </param>
        /// <param name="before">
        /// Returns the elements that come before the specified cursor.
        /// </param>
        /// <param name="reverse">
        /// Reverse the order of the underlying list.
        /// </param>
        /// <param name="sortKey">
        /// Sort the underlying list by the given key.
        /// </param>
        /// <param name="query">
        /// Supported filter parameters:
        /// - `collection_type`
        /// - `title`
        /// - `updated_at`
        /// 
        /// See the detailed [search syntax](https://help.shopify.com/api/getting-started/search-syntax)
        /// for more information about using filters.
        /// </param>
        public QueryRootQuery collections(CollectionConnectionDelegate buildQuery,long? first = null,string after = null,long? last = null,string before = null,bool? reverse = null,CollectionSortKeys? sortKey = null,string queryValue = null,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("collections___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("collections ");

            Arguments args = new Arguments();

            if (first != null) {
                args.Add("first", first);
            }

            if (after != null) {
                args.Add("after", after);
            }

            if (last != null) {
                args.Add("last", last);
            }

            if (before != null) {
                args.Add("before", before);
            }

            if (reverse != null) {
                args.Add("reverse", reverse);
            }

            if (sortKey != null) {
                args.Add("sortKey", sortKey);
            }

            if (queryValue != null) {
                args.Add("query", queryValue);
            }

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new CollectionConnectionQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Find a customer by its access token.
        /// </summary>
        /// <param name="customerAccessToken">
        /// The customer access token.
        /// </param>
        public QueryRootQuery customer(CustomerDelegate buildQuery,string customerAccessToken,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("customer___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("customer ");

            Arguments args = new Arguments();

            args.Add("customerAccessToken", customerAccessToken);

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new CustomerQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Returns a specific node by ID.
        /// </summary>
        /// <param name="id">
        /// The ID of the Node to return.
        /// </param>
        public QueryRootQuery node(NodeDelegate buildQuery,string id,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("node___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("node ");

            Arguments args = new Arguments();

            args.Add("id", id);

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new NodeQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Returns the list of nodes with the given IDs.
        /// </summary>
        /// <param name="ids">
        /// The IDs of the Nodes to return.
        /// </param>
        public QueryRootQuery nodes(NodeDelegate buildQuery,List<string> ids,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("nodes___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("nodes ");

            Arguments args = new Arguments();

            args.Add("ids", ids);

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new NodeQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Find a page by its handle.
        /// </summary>
        /// <param name="handle">
        /// The handle of the page.
        /// </param>
        public QueryRootQuery pageByHandle(PageDelegate buildQuery,string handle,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("pageByHandle___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("pageByHandle ");

            Arguments args = new Arguments();

            args.Add("handle", handle);

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new PageQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// List of the shop's pages.
        /// </summary>
        /// <param name="first">
        /// Returns up to the first `n` elements from the list.
        /// </param>
        /// <param name="after">
        /// Returns the elements that come after the specified cursor.
        /// </param>
        /// <param name="last">
        /// Returns up to the last `n` elements from the list.
        /// </param>
        /// <param name="before">
        /// Returns the elements that come before the specified cursor.
        /// </param>
        /// <param name="reverse">
        /// Reverse the order of the underlying list.
        /// </param>
        /// <param name="sortKey">
        /// Sort the underlying list by the given key.
        /// </param>
        /// <param name="query">
        /// Supported filter parameters:
        /// - `created_at`
        /// - `handle`
        /// - `title`
        /// - `updated_at`
        /// 
        /// See the detailed [search syntax](https://help.shopify.com/api/getting-started/search-syntax)
        /// for more information about using filters.
        /// </param>
        public QueryRootQuery pages(PageConnectionDelegate buildQuery,long? first = null,string after = null,long? last = null,string before = null,bool? reverse = null,PageSortKeys? sortKey = null,string queryValue = null,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("pages___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("pages ");

            Arguments args = new Arguments();

            if (first != null) {
                args.Add("first", first);
            }

            if (after != null) {
                args.Add("after", after);
            }

            if (last != null) {
                args.Add("last", last);
            }

            if (before != null) {
                args.Add("before", before);
            }

            if (reverse != null) {
                args.Add("reverse", reverse);
            }

            if (sortKey != null) {
                args.Add("sortKey", sortKey);
            }

            if (queryValue != null) {
                args.Add("query", queryValue);
            }

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new PageConnectionQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Find a product by its handle.
        /// </summary>
        /// <param name="handle">
        /// The handle of the product.
        /// </param>
        public QueryRootQuery productByHandle(ProductDelegate buildQuery,string handle,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("productByHandle___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("productByHandle ");

            Arguments args = new Arguments();

            args.Add("handle", handle);

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new ProductQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Find recommended products related to a given `product_id`.
        /// To learn more about how recommendations are generated, see
        /// [*Showing product recommendations on product pages*](https://help.shopify.com/themes/development/recommended-products).
        /// </summary>
        /// <param name="productId">
        /// The id of the product.
        /// </param>
        public QueryRootQuery productRecommendations(ProductDelegate buildQuery,string productId,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("productRecommendations___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("productRecommendations ");

            Arguments args = new Arguments();

            args.Add("productId", productId);

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new ProductQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Tags added to products.
        /// Additional access scope required: unauthenticated_read_product_tags.
        /// </summary>
        /// <param name="first">
        /// Returns up to the first `n` elements from the list.
        /// </param>
        public QueryRootQuery productTags(StringConnectionDelegate buildQuery,long first,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("productTags___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("productTags ");

            Arguments args = new Arguments();

            args.Add("first", first);

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new StringConnectionQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// List of product types for the shop's products that are published to your app.
        /// </summary>
        /// <param name="first">
        /// Returns up to the first `n` elements from the list.
        /// </param>
        public QueryRootQuery productTypes(StringConnectionDelegate buildQuery,long first,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("productTypes___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("productTypes ");

            Arguments args = new Arguments();

            args.Add("first", first);

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new StringConnectionQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// List of the shop’s products.
        /// </summary>
        /// <param name="first">
        /// Returns up to the first `n` elements from the list.
        /// </param>
        /// <param name="after">
        /// Returns the elements that come after the specified cursor.
        /// </param>
        /// <param name="last">
        /// Returns up to the last `n` elements from the list.
        /// </param>
        /// <param name="before">
        /// Returns the elements that come before the specified cursor.
        /// </param>
        /// <param name="reverse">
        /// Reverse the order of the underlying list.
        /// </param>
        /// <param name="sortKey">
        /// Sort the underlying list by the given key.
        /// </param>
        /// <param name="query">
        /// Supported filter parameters:
        /// - `available_for_sale`
        /// - `created_at`
        /// - `product_type`
        /// - `tag`
        /// - `title`
        /// - `updated_at`
        /// - `variants.price`
        /// - `vendor`
        /// 
        /// See the detailed [search syntax](https://help.shopify.com/api/getting-started/search-syntax)
        /// for more information about using filters.
        /// </param>
        public QueryRootQuery products(ProductConnectionDelegate buildQuery,long? first = null,string after = null,long? last = null,string before = null,bool? reverse = null,ProductSortKeys? sortKey = null,string queryValue = null,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("products___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("products ");

            Arguments args = new Arguments();

            if (first != null) {
                args.Add("first", first);
            }

            if (after != null) {
                args.Add("after", after);
            }

            if (last != null) {
                args.Add("last", last);
            }

            if (before != null) {
                args.Add("before", before);
            }

            if (reverse != null) {
                args.Add("reverse", reverse);
            }

            if (sortKey != null) {
                args.Add("sortKey", sortKey);
            }

            if (queryValue != null) {
                args.Add("query", queryValue);
            }

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new ProductConnectionQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// The list of public Storefront API versions, including supported, release candidate and unstable versions.
        /// </summary>
        public QueryRootQuery publicApiVersions(ApiVersionDelegate buildQuery) {
            Query.Append("publicApiVersions ");

            Query.Append("{");
            buildQuery(new ApiVersionQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// The shop associated with the storefront access token.
        /// </summary>
        public QueryRootQuery shop(ShopDelegate buildQuery) {
            Query.Append("shop ");

            Query.Append("{");
            buildQuery(new ShopQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Will return a GraphQL query.
        /// </summary>
        public override string ToString() {
            return Query.ToString() + "}";
        }
    }
    }
