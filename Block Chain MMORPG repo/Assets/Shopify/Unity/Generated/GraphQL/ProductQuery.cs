namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void ProductDelegate(ProductQuery query);

    /// <summary>
    /// A product represents an individual item for sale in a Shopify store. Products are often physical, but they don't have to be.
    /// For example, a digital download (such as a movie, music or ebook file) also qualifies as a product, as do services (such as equipment rental, work for hire, customization of another product or an extended warranty).
    /// </summary>
    public class ProductQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="ProductQuery" /> is used to build queries. Typically
        /// <see cref="ProductQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public ProductQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// Indicates if at least one product variant is available for sale.
        /// </summary>
        public ProductQuery availableForSale() {
            Query.Append("availableForSale ");

            return this;
        }

        /// <summary>
        /// List of collections a product belongs to.
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
        public ProductQuery collections(CollectionConnectionDelegate buildQuery,long? first = null,string after = null,long? last = null,string before = null,bool? reverse = null,string alias = null) {
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

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new CollectionConnectionQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// The date and time when the product was created.
        /// </summary>
        public ProductQuery createdAt() {
            Query.Append("createdAt ");

            return this;
        }

        /// <summary>
        /// Stripped description of the product, single line with HTML tags removed.
        /// </summary>
        /// <param name="truncateAt">
        /// Truncates string after the given length.
        /// </param>
        public ProductQuery description(long? truncateAt = null,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("description___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("description ");

            Arguments args = new Arguments();

            if (truncateAt != null) {
                args.Add("truncateAt", truncateAt);
            }

            Query.Append(args.ToString());

            return this;
        }

        /// <summary>
        /// The description of the product, complete with HTML formatting.
        /// </summary>
        public ProductQuery descriptionHtml() {
            Query.Append("descriptionHtml ");

            return this;
        }

        /// <summary>
        /// A human-friendly unique string for the Product automatically generated from its title.
        /// They are used by the Liquid templating language to refer to objects.
        /// </summary>
        public ProductQuery handle() {
            Query.Append("handle ");

            return this;
        }

        /// <summary>
        /// Globally unique identifier.
        /// </summary>
        public ProductQuery id() {
            Query.Append("id ");

            return this;
        }

        /// <summary>
        /// List of images associated with the product.
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
        /// <param name="maxWidth">
        /// Image width in pixels between 1 and 2048. This argument is deprecated: Use `maxWidth` on `Image.transformedSrc` instead.
        /// </param>
        /// <param name="maxHeight">
        /// Image height in pixels between 1 and 2048. This argument is deprecated: Use `maxHeight` on `Image.transformedSrc` instead.
        /// </param>
        /// <param name="crop">
        /// Crops the image according to the specified region. This argument is deprecated: Use `crop` on `Image.transformedSrc` instead.
        /// </param>
        /// <param name="scale">
        /// Image size multiplier for high-resolution retina displays. Must be between 1 and 3. This argument is deprecated: Use `scale` on `Image.transformedSrc` instead.
        /// </param>
        public ProductQuery images(ImageConnectionDelegate buildQuery,long? first = null,string after = null,long? last = null,string before = null,bool? reverse = null,ProductImageSortKeys? sortKey = null,long? maxWidth = null,long? maxHeight = null,CropRegion? crop = null,long? scale = null,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("images___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("images ");

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

            if (maxWidth != null) {
                args.Add("maxWidth", maxWidth);
            }

            if (maxHeight != null) {
                args.Add("maxHeight", maxHeight);
            }

            if (crop != null) {
                args.Add("crop", crop);
            }

            if (scale != null) {
                args.Add("scale", scale);
            }

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new ImageConnectionQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// The media associated with the product.
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
        public ProductQuery media(MediaConnectionDelegate buildQuery,long? first = null,string after = null,long? last = null,string before = null,bool? reverse = null,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("media___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("media ");

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

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new MediaConnectionQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// The metafield associated with the resource.
        /// </summary>
        /// <param name="namespace">
        /// Container for a set of metafields (maximum of 20 characters).
        /// </param>
        /// <param name="key">
        /// Identifier for the metafield (maximum of 30 characters).
        /// </param>
        public ProductQuery metafield(MetafieldDelegate buildQuery,string namespaceValue,string key,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("metafield___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("metafield ");

            Arguments args = new Arguments();

            args.Add("namespace", namespaceValue);

            args.Add("key", key);

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new MetafieldQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// A paginated list of metafields associated with the resource.
        /// </summary>
        /// <param name="namespace">
        /// Container for a set of metafields (maximum of 20 characters).
        /// </param>
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
        public ProductQuery metafields(MetafieldConnectionDelegate buildQuery,string namespaceValue = null,long? first = null,string after = null,long? last = null,string before = null,bool? reverse = null,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("metafields___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("metafields ");

            Arguments args = new Arguments();

            if (namespaceValue != null) {
                args.Add("namespace", namespaceValue);
            }

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

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new MetafieldConnectionQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// The online store URL for the product.
        /// A value of `null` indicates that the product is not published to the Online Store sales channel.
        /// </summary>
        public ProductQuery onlineStoreUrl() {
            Query.Append("onlineStoreUrl ");

            return this;
        }

        /// <summary>
        /// List of product options.
        /// </summary>
        /// <param name="first">
        /// Truncate the array result to this size.
        /// </param>
        public ProductQuery options(ProductOptionDelegate buildQuery,long? first = null,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("options___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("options ");

            Arguments args = new Arguments();

            if (first != null) {
                args.Add("first", first);
            }

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new ProductOptionQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// List of price ranges in the presentment currencies for this shop.
        /// </summary>
        /// <param name="presentmentCurrencies">
        /// Specifies the presentment currencies to return a price range in.
        /// </param>
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
        public ProductQuery presentmentPriceRanges(ProductPriceRangeConnectionDelegate buildQuery,List<CurrencyCode> presentmentCurrencies = null,long? first = null,string after = null,long? last = null,string before = null,bool? reverse = null,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("presentmentPriceRanges___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("presentmentPriceRanges ");

            Arguments args = new Arguments();

            if (presentmentCurrencies != null) {
                args.Add("presentmentCurrencies", presentmentCurrencies);
            }

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

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new ProductPriceRangeConnectionQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// The price range.
        /// </summary>
        public ProductQuery priceRange(ProductPriceRangeDelegate buildQuery) {
            Query.Append("priceRange ");

            Query.Append("{");
            buildQuery(new ProductPriceRangeQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// A categorization that a product can be tagged with, commonly used for filtering and searching.
        /// </summary>
        public ProductQuery productType() {
            Query.Append("productType ");

            return this;
        }

        /// <summary>
        /// The date and time when the product was published to the channel.
        /// </summary>
        public ProductQuery publishedAt() {
            Query.Append("publishedAt ");

            return this;
        }

        /// <summary>
        /// A comma separated list of tags that have been added to the product.
        /// Additional access scope required for private apps: unauthenticated_read_product_tags.
        /// </summary>
        public ProductQuery tags() {
            Query.Append("tags ");

            return this;
        }

        /// <summary>
        /// The product’s title.
        /// </summary>
        public ProductQuery title() {
            Query.Append("title ");

            return this;
        }

        /// <summary>
        /// The date and time when the product was last modified.
        /// A product's `updatedAt` value can change for different reasons. For example, if an order
        /// is placed for a product that has inventory tracking set up, then the inventory adjustment
        /// is counted as an update.
        /// </summary>
        public ProductQuery updatedAt() {
            Query.Append("updatedAt ");

            return this;
        }

        /// <summary>
        /// Find a product’s variant based on its selected options.
        /// This is useful for converting a user’s selection of product options into a single matching variant.
        /// If there is not a variant for the selected options, `null` will be returned.
        /// </summary>
        /// <param name="selectedOptions">
        /// The input fields used for a selected option.
        /// </param>
        public ProductQuery variantBySelectedOptions(ProductVariantDelegate buildQuery,List<SelectedOptionInput> selectedOptions,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("variantBySelectedOptions___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("variantBySelectedOptions ");

            Arguments args = new Arguments();

            args.Add("selectedOptions", selectedOptions);

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new ProductVariantQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// List of the product’s variants.
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
        public ProductQuery variants(ProductVariantConnectionDelegate buildQuery,long? first = null,string after = null,long? last = null,string before = null,bool? reverse = null,ProductVariantSortKeys? sortKey = null,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("variants___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("variants ");

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

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new ProductVariantConnectionQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// The product’s vendor name.
        /// </summary>
        public ProductQuery vendor() {
            Query.Append("vendor ");

            return this;
        }
    }
    }
