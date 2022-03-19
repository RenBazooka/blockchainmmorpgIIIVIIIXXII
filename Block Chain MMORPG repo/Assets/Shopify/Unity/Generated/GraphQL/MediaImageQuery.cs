namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void MediaImageDelegate(MediaImageQuery query);

    /// <summary>
    /// Represents a Shopify hosted image.
    /// </summary>
    public class MediaImageQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="MediaImageQuery" /> is used to build queries. Typically
        /// <see cref="MediaImageQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public MediaImageQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// A word or phrase to share the nature or contents of a media.
        /// </summary>
        public MediaImageQuery alt() {
            Query.Append("alt ");

            return this;
        }

        /// <summary>
        /// Globally unique identifier.
        /// </summary>
        public MediaImageQuery id() {
            Query.Append("id ");

            return this;
        }

        /// <summary>
        /// The image for the media.
        /// </summary>
        public MediaImageQuery image(ImageDelegate buildQuery) {
            Query.Append("image ");

            Query.Append("{");
            buildQuery(new ImageQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// The media content type.
        /// </summary>
        public MediaImageQuery mediaContentType() {
            Query.Append("mediaContentType ");

            return this;
        }

        /// <summary>
        /// The preview image for the media.
        /// </summary>
        public MediaImageQuery previewImage(ImageDelegate buildQuery) {
            Query.Append("previewImage ");

            Query.Append("{");
            buildQuery(new ImageQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
