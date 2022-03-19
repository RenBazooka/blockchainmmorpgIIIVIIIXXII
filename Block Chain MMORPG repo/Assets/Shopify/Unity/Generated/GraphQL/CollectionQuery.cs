namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void CollectionDelegate(CollectionQuery query);

    /// <summary>
    /// A collection represents a grouping of products that a shop owner can create to organize them or make their shops easier to browse.
    /// </summary>
    public class CollectionQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="CollectionQuery" /> is used to build queries. Typically
        /// <see cref="CollectionQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public CollectionQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// Stripped description of the collection, single line with HTML tags removed.
        /// </summary>
        /// <param name="truncateAt">
        /// Truncates string after the given length.
        /// </param>
        public CollectionQuery description(long? truncateAt = null,string alias = null) {
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
        /// The description of the collection, complete with HTML formatting.
        /// </summary>
        public CollectionQuery descriptionHtml() {
            Query.Append("descriptionHtml ");

            return this;
        }

        /// <summary>
        /// A human-friendly unique string for the collection automatically generated from its title.
        /// Limit of 255 characters.
        /// </summary>
        public CollectionQuery handle() {
            Query.Append("handle ");

            return this;
        }

        /// <summary>
        /// Globally unique identifier.
        /// </summary>
        public CollectionQuery id() {
            Query.Append("id ");

            return this;
        }

        /// <summary>
        /// Image associated with the collection.
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
        public CollectionQuery image(ImageDelegate buildQuery,long? maxWidth = null,long? maxHeight = null,CropRegion? crop = null,long? scale = null,string alias = null) {
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
        /// List of products in the collection.
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
        public CollectionQuery products(ProductConnectionDelegate buildQuery,long? first = null,string after = null,long? last = null,string before = null,bool? reverse = null,ProductCollectionSortKeys? sortKey = null,string alias = null) {
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

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new ProductConnectionQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// The collection’s name. Limit of 255 characters.
        /// </summary>
        public CollectionQuery title() {
            Query.Append("title ");

            return this;
        }

        /// <summary>
        /// The date and time when the collection was last modified.
        /// </summary>
        public CollectionQuery updatedAt() {
            Query.Append("updatedAt ");

            return this;
        }
    }
    }
