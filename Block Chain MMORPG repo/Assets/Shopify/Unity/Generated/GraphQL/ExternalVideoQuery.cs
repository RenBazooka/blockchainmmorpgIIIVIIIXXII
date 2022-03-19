namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void ExternalVideoDelegate(ExternalVideoQuery query);

    /// <summary>
    /// Represents a video hosted outside of Shopify.
    /// </summary>
    public class ExternalVideoQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="ExternalVideoQuery" /> is used to build queries. Typically
        /// <see cref="ExternalVideoQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public ExternalVideoQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// A word or phrase to share the nature or contents of a media.
        /// </summary>
        public ExternalVideoQuery alt() {
            Query.Append("alt ");

            return this;
        }

        /// <summary>
        /// The URL.
        /// </summary>
        public ExternalVideoQuery embeddedUrl() {
            Query.Append("embeddedUrl ");

            return this;
        }

        /// <summary>
        /// Globally unique identifier.
        /// </summary>
        public ExternalVideoQuery id() {
            Query.Append("id ");

            return this;
        }

        /// <summary>
        /// The media content type.
        /// </summary>
        public ExternalVideoQuery mediaContentType() {
            Query.Append("mediaContentType ");

            return this;
        }

        /// <summary>
        /// The preview image for the media.
        /// </summary>
        public ExternalVideoQuery previewImage(ImageDelegate buildQuery) {
            Query.Append("previewImage ");

            Query.Append("{");
            buildQuery(new ImageQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
