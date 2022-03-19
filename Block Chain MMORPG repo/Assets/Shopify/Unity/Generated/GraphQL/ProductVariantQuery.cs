namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void ProductVariantDelegate(ProductVariantQuery query);

    /// <summary>
    /// A product variant represents a different version of a product, such as differing sizes or differing colors.
    /// </summary>
    public class ProductVariantQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="ProductVariantQuery" /> is used to build queries. Typically
        /// <see cref="ProductVariantQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public ProductVariantQuery(StringBuilder query) {
            Query = query;
        }

        /// \deprecated Use `availableForSale` instead
        /// <summary>
        /// Indicates if the product variant is in stock.
        /// </summary>
        public ProductVariantQuery available() {
            Log.DeprecatedQueryField("ProductVariant", "available", "Use `availableForSale` instead");

            Query.Append("available ");

            return this;
        }

        /// <summary>
        /// Indicates if the product variant is available for sale.
        /// </summary>
        public ProductVariantQuery availableForSale() {
            Query.Append("availableForSale ");

            return this;
        }

        /// \deprecated Use `compareAtPriceV2` instead
        /// <summary>
        /// The compare at price of the variant. This can be used to mark a variant as on sale, when `compareAtPrice` is higher than `price`.
        /// </summary>
        public ProductVariantQuery compareAtPrice() {
            Log.DeprecatedQueryField("ProductVariant", "compareAtPrice", "Use `compareAtPriceV2` instead");

            Query.Append("compareAtPrice ");

            return this;
        }

        /// <summary>
        /// The compare at price of the variant. This can be used to mark a variant as on sale, when `compareAtPriceV2` is higher than `priceV2`.
        /// </summary>
        public ProductVariantQuery compareAtPriceV2(MoneyV2Delegate buildQuery) {
            Query.Append("compareAtPriceV2 ");

            Query.Append("{");
            buildQuery(new MoneyV2Query(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Globally unique identifier.
        /// </summary>
        public ProductVariantQuery id() {
            Query.Append("id ");

            return this;
        }

        /// <summary>
        /// Image associated with the product variant. This field falls back to the product image if no image is available.
        /// </summary>
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
        public ProductVariantQuery image(ImageDelegate buildQuery,long? maxWidth = null,long? maxHeight = null,CropRegion? crop = null,long? scale = null,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("image___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("image ");

            Arguments args = new Arguments();

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
            buildQuery(new ImageQuery(Query));
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
        public ProductVariantQuery metafield(MetafieldDelegate buildQuery,string namespaceValue,string key,string alias = null) {
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
        public ProductVariantQuery metafields(MetafieldConnectionDelegate buildQuery,string namespaceValue = null,long? first = null,string after = null,long? last = null,string before = null,bool? reverse = null,string alias = null) {
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
        /// List of prices and compare-at prices in the presentment currencies for this shop.
        /// </summary>
        /// <param name="presentmentCurrencies">
        /// The presentment currencies prices should return in.
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
        public ProductVariantQuery presentmentPrices(ProductVariantPricePairConnectionDelegate buildQuery,List<CurrencyCode> presentmentCurrencies = null,long? first = null,string after = null,long? last = null,string before = null,bool? reverse = null,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("presentmentPrices___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("presentmentPrices ");

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
            buildQuery(new ProductVariantPricePairConnectionQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// List of unit prices in the presentment currencies for this shop.
        /// </summary>
        /// <param name="presentmentCurrencies">
        /// Specify the currencies in which to return presentment unit prices.
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
        public ProductVariantQuery presentmentUnitPrices(MoneyV2connectionDelegate buildQuery,List<CurrencyCode> presentmentCurrencies = null,long? first = null,string after = null,long? last = null,string before = null,bool? reverse = null,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("presentmentUnitPrices___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("presentmentUnitPrices ");

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
            buildQuery(new MoneyV2connectionQuery(Query));
            Query.Append("}");

            return this;
        }

        /// \deprecated Use `priceV2` instead
        /// <summary>
        /// The product variant’s price.
        /// </summary>
        public ProductVariantQuery price() {
            Log.DeprecatedQueryField("ProductVariant", "price", "Use `priceV2` instead");

            Query.Append("price ");

            return this;
        }

        /// <summary>
        /// The product variant’s price.
        /// </summary>
        public ProductVariantQuery priceV2(MoneyV2Delegate buildQuery) {
            Query.Append("priceV2 ");

            Query.Append("{");
            buildQuery(new MoneyV2Query(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// The product object that the product variant belongs to.
        /// </summary>
        public ProductVariantQuery product(ProductDelegate buildQuery) {
            Query.Append("product ");

            Query.Append("{");
            buildQuery(new ProductQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Whether a customer needs to provide a shipping address when placing an order for the product variant.
        /// </summary>
        public ProductVariantQuery requiresShipping() {
            Query.Append("requiresShipping ");

            return this;
        }

        /// <summary>
        /// List of product options applied to the variant.
        /// </summary>
        public ProductVariantQuery selectedOptions(SelectedOptionDelegate buildQuery) {
            Query.Append("selectedOptions ");

            Query.Append("{");
            buildQuery(new SelectedOptionQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// The SKU (stock keeping unit) associated with the variant.
        /// </summary>
        public ProductVariantQuery sku() {
            Query.Append("sku ");

            return this;
        }

        /// <summary>
        /// The product variant’s title.
        /// </summary>
        public ProductVariantQuery title() {
            Query.Append("title ");

            return this;
        }

        /// <summary>
        /// The unit price value for the variant based on the variant's measurement.
        /// </summary>
        public ProductVariantQuery unitPrice(MoneyV2Delegate buildQuery) {
            Query.Append("unitPrice ");

            Query.Append("{");
            buildQuery(new MoneyV2Query(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// The unit price measurement for the variant.
        /// </summary>
        public ProductVariantQuery unitPriceMeasurement(UnitPriceMeasurementDelegate buildQuery) {
            Query.Append("unitPriceMeasurement ");

            Query.Append("{");
            buildQuery(new UnitPriceMeasurementQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// The weight of the product variant in the unit system specified with `weight_unit`.
        /// </summary>
        public ProductVariantQuery weight() {
            Query.Append("weight ");

            return this;
        }

        /// <summary>
        /// Unit of measurement for weight.
        /// </summary>
        public ProductVariantQuery weightUnit() {
            Query.Append("weightUnit ");

            return this;
        }
    }
    }
