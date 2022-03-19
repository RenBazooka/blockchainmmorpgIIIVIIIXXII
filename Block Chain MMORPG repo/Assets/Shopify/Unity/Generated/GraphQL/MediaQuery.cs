namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void MediaDelegate(MediaQuery query);

    /// <summary>
    /// Represents a media interface.
    /// </summary>
    public class MediaQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="MediaQuery" /> is used to build queries. Typically
        /// <see cref="MediaQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public MediaQuery(StringBuilder query) {
            Query = query;

            Query.Append("__typename ");
        }

        /// <summary>
        /// A word or phrase to share the nature or contents of a media.
        /// </summary>
        public MediaQuery alt() {
            Query.Append("alt ");

            return this;
        }

        /// <summary>
        /// The media content type.
        /// </summary>
        public MediaQuery mediaContentType() {
            Query.Append("mediaContentType ");

            return this;
        }

        /// <summary>
        /// The preview image for the media.
        /// </summary>
        public MediaQuery previewImage(ImageDelegate buildQuery) {
            Query.Append("previewImage ");

            Query.Append("{");
            buildQuery(new ImageQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// will allow you to write queries on ExternalVideo.
        /// </summary>
        public MediaQuery onExternalVideo(ExternalVideoDelegate buildQuery) {
            Query.Append("...on ExternalVideo{");
            buildQuery(new ExternalVideoQuery(Query));
            Query.Append("}");
            return this;
        }

        /// <summary>
        /// will allow you to write queries on MediaImage.
        /// </summary>
        public MediaQuery onMediaImage(MediaImageDelegate buildQuery) {
            Query.Append("...on MediaImage{");
            buildQuery(new MediaImageQuery(Query));
            Query.Append("}");
            return this;
        }

        /// <summary>
        /// will allow you to write queries on Model3d.
        /// </summary>
        public MediaQuery onModel3d(Model3dDelegate buildQuery) {
            Query.Append("...on Model3d{");
            buildQuery(new Model3dQuery(Query));
            Query.Append("}");
            return this;
        }

        /// <summary>
        /// will allow you to write queries on Video.
        /// </summary>
        public MediaQuery onVideo(VideoDelegate buildQuery) {
            Query.Append("...on Video{");
            buildQuery(new VideoQuery(Query));
            Query.Append("}");
            return this;
        }
    }
    }
