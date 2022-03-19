namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void VideoSourceDelegate(VideoSourceQuery query);

    /// <summary>
    /// Represents a source for a Shopify hosted video.
    /// </summary>
    public class VideoSourceQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="VideoSourceQuery" /> is used to build queries. Typically
        /// <see cref="VideoSourceQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public VideoSourceQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// The format of the video source.
        /// </summary>
        public VideoSourceQuery format() {
            Query.Append("format ");

            return this;
        }

        /// <summary>
        /// The height of the video.
        /// </summary>
        public VideoSourceQuery height() {
            Query.Append("height ");

            return this;
        }

        /// <summary>
        /// The video MIME type.
        /// </summary>
        public VideoSourceQuery mimeType() {
            Query.Append("mimeType ");

            return this;
        }

        /// <summary>
        /// The URL of the video.
        /// </summary>
        public VideoSourceQuery url() {
            Query.Append("url ");

            return this;
        }

        /// <summary>
        /// The width of the video.
        /// </summary>
        public VideoSourceQuery width() {
            Query.Append("width ");

            return this;
        }
    }
    }
