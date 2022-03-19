namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void MetafieldDelegate(MetafieldQuery query);

    /// <summary>
    /// Metafields represent custom metadata attached to a resource. Metafields can be sorted into namespaces and are
    /// comprised of keys, values, and value types.
    /// </summary>
    public class MetafieldQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="MetafieldQuery" /> is used to build queries. Typically
        /// <see cref="MetafieldQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public MetafieldQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// The description of a metafield.
        /// </summary>
        public MetafieldQuery description() {
            Query.Append("description ");

            return this;
        }

        /// <summary>
        /// Globally unique identifier.
        /// </summary>
        public MetafieldQuery id() {
            Query.Append("id ");

            return this;
        }

        /// <summary>
        /// The key name for a metafield.
        /// </summary>
        public MetafieldQuery key() {
            Query.Append("key ");

            return this;
        }

        /// <summary>
        /// The namespace for a metafield.
        /// </summary>
        public MetafieldQuery namespaceValue() {
            Query.Append("namespace ");

            return this;
        }

        /// <summary>
        /// The parent object that the metafield belongs to.
        /// </summary>
        public MetafieldQuery parentResource(MetafieldParentResourceDelegate buildQuery) {
            Query.Append("parentResource ");

            Query.Append("{");
            buildQuery(new MetafieldParentResourceQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// The value of a metafield.
        /// </summary>
        public MetafieldQuery value() {
            Query.Append("value ");

            return this;
        }

        /// <summary>
        /// Represents the metafield value type.
        /// </summary>
        public MetafieldQuery valueType() {
            Query.Append("valueType ");

            return this;
        }
    }
    }
