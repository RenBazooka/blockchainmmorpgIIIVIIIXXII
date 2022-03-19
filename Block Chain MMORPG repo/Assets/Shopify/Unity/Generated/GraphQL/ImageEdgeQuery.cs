namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void ImageEdgeDelegate(ImageEdgeQuery query);

    /// <summary>
    /// An auto-generated type which holds one Image and a cursor during pagination.
    /// </summary>
    public class ImageEdgeQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="ImageEdgeQuery" /> is used to build queries. Typically
        /// <see cref="ImageEdgeQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public ImageEdgeQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// A cursor for use in pagination.
        /// </summary>
        public ImageEdgeQuery cursor() {
            Query.Append("cursor ");

            return this;
        }

        /// <summary>
        /// The item at the end of ImageEdge.
        /// </summary>
        public ImageEdgeQuery node(ImageDelegate buildQuery) {
            Query.Append("node ");

            Query.Append("{");
            buildQuery(new ImageQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
