namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void Model3dSourceDelegate(Model3dSourceQuery query);

    /// <summary>
    /// Represents a source for a Shopify hosted 3d model.
    /// </summary>
    public class Model3dSourceQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="Model3dSourceQuery" /> is used to build queries. Typically
        /// <see cref="Model3dSourceQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public Model3dSourceQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// The filesize of the 3d model.
        /// </summary>
        public Model3dSourceQuery filesize() {
            Query.Append("filesize ");

            return this;
        }

        /// <summary>
        /// The format of the 3d model.
        /// </summary>
        public Model3dSourceQuery format() {
            Query.Append("format ");

            return this;
        }

        /// <summary>
        /// The MIME type of the 3d model.
        /// </summary>
        public Model3dSourceQuery mimeType() {
            Query.Append("mimeType ");

            return this;
        }

        /// <summary>
        /// The URL of the 3d model.
        /// </summary>
        public Model3dSourceQuery url() {
            Query.Append("url ");

            return this;
        }
    }
    }
