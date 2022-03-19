namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void ImageDelegate(ImageQuery query);

    /// <summary>
    /// Represents an image resource.
    /// </summary>
    public class ImageQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="ImageQuery" /> is used to build queries. Typically
        /// <see cref="ImageQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public ImageQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// A word or phrase to share the nature or contents of an image.
        /// </summary>
        public ImageQuery altText() {
            Query.Append("altText ");

            return this;
        }

        /// <summary>
        /// A unique identifier for the image.
        /// </summary>
        public ImageQuery id() {
            Query.Append("id ");

            return this;
        }

        /// <summary>
        /// The location of the original image as a URL.
        /// 
        /// If there are any existing transformations in the original source URL, they will remain and not be stripped.
        /// </summary>
        public ImageQuery originalSrc() {
            Query.Append("originalSrc ");

            return this;
        }

        /// \deprecated Previously an image had a single `src` field. This could either return the original image
        /// location or a URL that contained transformations such as sizing or scale.
        /// 
        /// These transformations were specified by arguments on the parent field.
        /// 
        /// Now an image has two distinct URL fields: `originalSrc` and `transformedSrc`.
        /// 
        /// * `originalSrc` - the original unmodified image URL
        /// * `transformedSrc` - the image URL with the specified transformations included
        /// 
        /// To migrate to the new fields, image transformations should be moved from the parent field to `transformedSrc`.
        /// 
        /// Before:
        /// ```graphql
        /// {
        /// shop {
        /// productImages(maxWidth: 200, scale: 2) {
        /// edges {
        /// node {
        /// src
        /// }
        /// }
        /// }
        /// }
        /// }
        /// ```
        /// 
        /// After:
        /// ```graphql
        /// {
        /// shop {
        /// productImages {
        /// edges {
        /// node {
        /// transformedSrc(maxWidth: 200, scale: 2)
        /// }
        /// }
        /// }
        /// }
        /// }
        /// ```
        /// <summary>
        /// The location of the image as a URL.
        /// </summary>
        public ImageQuery src() {
            Log.DeprecatedQueryField("Image", "src", "Previously an image had a single `src` field. This could either return the original image\nlocation or a URL that contained transformations such as sizing or scale.\n\nThese transformations were specified by arguments on the parent field.\n\nNow an image has two distinct URL fields: `originalSrc` and `transformedSrc`.\n\n* `originalSrc` - the original unmodified image URL\n* `transformedSrc` - the image URL with the specified transformations included\n\nTo migrate to the new fields, image transformations should be moved from the parent field to `transformedSrc`.\n\nBefore:\n```graphql\n{\n  shop {\n    productImages(maxWidth: 200, scale: 2) {\n      edges {\n        node {\n          src\n        }\n      }\n    }\n  }\n}\n```\n\nAfter:\n```graphql\n{\n  shop {\n    productImages {\n      edges {\n        node {\n          transformedSrc(maxWidth: 200, scale: 2)\n        }\n      }\n    }\n  }\n}\n```\n");

            Query.Append("src ");

            return this;
        }

        /// <summary>
        /// The location of the transformed image as a URL.
        /// 
        /// All transformation arguments are considered "best-effort". If they can be applied to an image, they will be.
        /// Otherwise any transformations which an image type does not support will be ignored.
        /// </summary>
        /// <param name="maxWidth">
        /// Image width in pixels between 1 and 5760.
        /// </param>
        /// <param name="maxHeight">
        /// Image height in pixels between 1 and 5760.
        /// </param>
        /// <param name="crop">
        /// Crops the image according to the specified region.
        /// </param>
        /// <param name="scale">
        /// Image size multiplier for high-resolution retina displays. Must be between 1 and 3.
        /// </param>
        /// <param name="preferredContentType">
        /// Best effort conversion of image into content type (SVG -> PNG, Anything -> JGP, Anything -> WEBP are supported).
        /// </param>
        public ImageQuery transformedSrc(long? maxWidth = null,long? maxHeight = null,CropRegion? crop = null,long? scale = null,ImageContentType? preferredContentType = null,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("transformedSrc___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("transformedSrc ");

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

            if (preferredContentType != null) {
                args.Add("preferredContentType", preferredContentType);
            }

            Query.Append(args.ToString());

            return this;
        }
    }
    }
