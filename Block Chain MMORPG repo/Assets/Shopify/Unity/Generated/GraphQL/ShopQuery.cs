namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void ShopDelegate(ShopQuery query);

    /// <summary>
    /// Shop represents a collection of the general settings and information about the shop.
    /// </summary>
    public class ShopQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="ShopQuery" /> is used to build queries. Typically
        /// <see cref="ShopQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public ShopQuery(StringBuilder query) {
            Query = query;
        }

        /// \deprecated Use `QueryRoot.articles` instead.
        /// <summary>
        /// List of the shop' articles.
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
        public ShopQuery articles(ArticleConnectionDelegate buildQuery,long? first = null,string after = null,long? last = null,string before = null,bool? reverse = null,ArticleSortKeys? sortKey = null,string queryValue = null,string alias = null) {
            Log.DeprecatedQueryField("Shop", "articles", "Use `QueryRoot.articles` instead.");

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

        /// \deprecated Use `QueryRoot.blogs` instead.
        /// <summary>
        /// List of the shop' blogs.
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
        public ShopQuery blogs(BlogConnectionDelegate buildQuery,long? first = null,string after = null,long? last = null,string before = null,bool? reverse = null,BlogSortKeys? sortKey = null,string queryValue = null,string alias = null) {
            Log.DeprecatedQueryField("Shop", "blogs", "Use `QueryRoot.blogs` instead.");

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

        /// \deprecated Use `QueryRoot.collectionByHandle` instead.
        /// <summary>
        /// Find a collection by its handle.
        /// </summary>
        /// <param name="handle">
        /// The handle of the collection.
        /// </param>
        public ShopQuery collectionByHandle(CollectionDelegate buildQuery,string handle,string alias = null) {
            Log.DeprecatedQueryField("Shop", "collectionByHandle", "Use `QueryRoot.collectionByHandle` instead.");

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

        /// \deprecated Use `QueryRoot.collections` instead.
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
        public ShopQuery collections(CollectionConnectionDelegate buildQuery,long? first = null,string after = null,long? last = null,string before = null,bool? reverse = null,CollectionSortKeys? sortKey = null,string queryValue = null,string alias = null) {
            Log.DeprecatedQueryField("Shop", "collections", "Use `QueryRoot.collections` instead.");

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

        /// \deprecated Use `paymentSettings` instead
        /// <summary>
        /// The three-letter code for the currency that the shop accepts.
        /// </summary>
        public ShopQuery currencyCode() {
            Log.DeprecatedQueryField("Shop", "currencyCode", "Use `paymentSettings` instead");

            Query.Append("currencyCode ");

            return this;
        }

        /// <summary>
        /// A description of the shop.
        /// </summary>
        public ShopQuery description() {
            Query.Append("description ");

            return this;
        }

        /// <summary>
        /// A string representing the way currency is formatted when the currency isn’t specified.
        /// </summary>
        public ShopQuery moneyFormat() {
            Query.Append("moneyFormat ");

            return this;
        }

        /// <summary>
        /// The shop’s name.
        /// </summary>
        public ShopQuery name() {
            Query.Append("name ");

            return this;
        }

        /// <summary>
        /// Settings related to payments.
        /// </summary>
        public ShopQuery paymentSettings(PaymentSettingsDelegate buildQuery) {
            Query.Append("paymentSettings ");

            Query.Append("{");
            buildQuery(new PaymentSettingsQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// The shop’s primary domain.
        /// </summary>
        public ShopQuery primaryDomain(DomainDelegate buildQuery) {
            Query.Append("primaryDomain ");

            Query.Append("{");
            buildQuery(new DomainQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// The shop’s privacy policy.
        /// </summary>
        public ShopQuery privacyPolicy(ShopPolicyDelegate buildQuery) {
            Query.Append("privacyPolicy ");

            Query.Append("{");
            buildQuery(new ShopPolicyQuery(Query));
            Query.Append("}");

            return this;
        }

        /// \deprecated Use `QueryRoot.productByHandle` instead.
        /// <summary>
        /// Find a product by its handle.
        /// </summary>
        /// <param name="handle">
        /// The handle of the product.
        /// </param>
        public ShopQuery productByHandle(ProductDelegate buildQuery,string handle,string alias = null) {
            Log.DeprecatedQueryField("Shop", "productByHandle", "Use `QueryRoot.productByHandle` instead.");

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

        /// \deprecated Use `QueryRoot.productTags` instead.
        /// <summary>
        /// A list of tags that have been added to products.
        /// Additional access scope required: unauthenticated_read_product_tags.
        /// </summary>
        /// <param name="first">
        /// Returns up to the first `n` elements from the list.
        /// </param>
        public ShopQuery productTags(StringConnectionDelegate buildQuery,long first,string alias = null) {
            Log.DeprecatedQueryField("Shop", "productTags", "Use `QueryRoot.productTags` instead.");

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

        /// \deprecated Use `QueryRoot.productTypes` instead.
        /// <summary>
        /// List of the shop’s product types.
        /// </summary>
        /// <param name="first">
        /// Returns up to the first `n` elements from the list.
        /// </param>
        public ShopQuery productTypes(StringConnectionDelegate buildQuery,long first,string alias = null) {
            Log.DeprecatedQueryField("Shop", "productTypes", "Use `QueryRoot.productTypes` instead.");

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

        /// \deprecated Use `QueryRoot.products` instead.
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
        public ShopQuery products(ProductConnectionDelegate buildQuery,long? first = null,string after = null,long? last = null,string before = null,bool? reverse = null,ProductSortKeys? sortKey = null,string queryValue = null,string alias = null) {
            Log.DeprecatedQueryField("Shop", "products", "Use `QueryRoot.products` instead.");

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
        /// The shop’s refund policy.
        /// </summary>
        public ShopQuery refundPolicy(ShopPolicyDelegate buildQuery) {
            Query.Append("refundPolicy ");

            Query.Append("{");
            buildQuery(new ShopPolicyQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Countries that the shop ships to.
        /// </summary>
        public ShopQuery shipsToCountries() {
            Query.Append("shipsToCountries ");

            return this;
        }

        /// \deprecated Use `paymentSettings` instead
        /// <summary>
        /// The shop’s Shopify Payments account id.
        /// </summary>
        public ShopQuery shopifyPaymentsAccountId() {
            Log.DeprecatedQueryField("Shop", "shopifyPaymentsAccountId", "Use `paymentSettings` instead");

            Query.Append("shopifyPaymentsAccountId ");

            return this;
        }

        /// <summary>
        /// The shop’s terms of service.
        /// </summary>
        public ShopQuery termsOfService(ShopPolicyDelegate buildQuery) {
            Query.Append("termsOfService ");

            Query.Append("{");
            buildQuery(new ShopPolicyQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
