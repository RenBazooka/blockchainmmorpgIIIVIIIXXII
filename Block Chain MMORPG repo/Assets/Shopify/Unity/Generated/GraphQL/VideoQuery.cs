namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void VideoDelegate(VideoQuery query);

    /// <summary>
    /// Represents a Shopify hosted video.
    /// </summary>
    public class VideoQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="VideoQuery" /> is used to build queries. Typically
        /// <see cref="VideoQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public VideoQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// A word or phrase to share the nature or contents of a media.
        /// </summary>
        public VideoQuery alt() {
            Query.Append("alt ");

            return this;
        }

        /// <summary>
        /// Globally unique identifier.
        /// </summary>
        public VideoQuery id() {
            Query.Append("id ");

            return this;
        }

        /// <summary>
        /// The media content type.
        /// </summary>
        public VideoQuery mediaContentType() {
            Query.Append("mediaContentType ");

            return this;
        }

        /// <summary>
        /// The preview image for the media.
        /// </summary>
        public VideoQuery previewImage(ImageDelegate buildQuery) {
            Query.Append("previewImage ");

            Query.Append("{");
            buildQuery(new ImageQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// The sources for a video.
        /// </summary>
        public VideoQuery sources(VideoSourceDelegate buildQuery) {
            Query.Append("sources ");

            Query.Append("{");
            buildQuery(new VideoSourceQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
