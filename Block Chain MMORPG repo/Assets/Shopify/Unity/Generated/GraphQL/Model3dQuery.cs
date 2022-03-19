namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void Model3dDelegate(Model3dQuery query);

    /// <summary>
    /// Represents a Shopify hosted 3D model.
    /// </summary>
    public class Model3dQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="Model3dQuery" /> is used to build queries. Typically
        /// <see cref="Model3dQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public Model3dQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// A word or phrase to share the nature or contents of a media.
        /// </summary>
        public Model3dQuery alt() {
            Query.Append("alt ");

            return this;
        }

        /// <summary>
        /// Globally unique identifier.
        /// </summary>
        public Model3dQuery id() {
            Query.Append("id ");

            return this;
        }

        /// <summary>
        /// The media content type.
        /// </summary>
        public Model3dQuery mediaContentType() {
            Query.Append("mediaContentType ");

            return this;
        }

        /// <summary>
        /// The preview image for the media.
        /// </summary>
        public Model3dQuery previewImage(ImageDelegate buildQuery) {
            Query.Append("previewImage ");

            Query.Append("{");
            buildQuery(new ImageQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// The sources for a 3d model.
        /// </summary>
        public Model3dQuery sources(Model3dSourceDelegate buildQuery) {
            Query.Append("sources ");

            Query.Append("{");
            buildQuery(new Model3dSourceQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
