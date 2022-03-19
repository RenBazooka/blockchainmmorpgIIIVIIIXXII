namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void AttributeDelegate(AttributeQuery query);

    /// <summary>
    /// Represents a generic custom attribute.
    /// </summary>
    public class AttributeQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="AttributeQuery" /> is used to build queries. Typically
        /// <see cref="AttributeQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public AttributeQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// Key or name of the attribute.
        /// </summary>
        public AttributeQuery key() {
            Query.Append("key ");

            return this;
        }

        /// <summary>
        /// Value of the attribute.
        /// </summary>
        public AttributeQuery value() {
            Query.Append("value ");

            return this;
        }
    }
    }
