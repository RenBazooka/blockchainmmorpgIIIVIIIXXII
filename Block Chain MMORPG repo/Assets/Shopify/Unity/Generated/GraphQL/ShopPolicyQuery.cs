namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void ShopPolicyDelegate(ShopPolicyQuery query);

    /// <summary>
    /// Policy that a merchant has configured for their store, such as their refund or privacy policy.
    /// </summary>
    public class ShopPolicyQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="ShopPolicyQuery" /> is used to build queries. Typically
        /// <see cref="ShopPolicyQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public ShopPolicyQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// Policy text, maximum size of 64kb.
        /// </summary>
        public ShopPolicyQuery body() {
            Query.Append("body ");

            return this;
        }

        /// <summary>
        /// Policy’s handle.
        /// </summary>
        public ShopPolicyQuery handle() {
            Query.Append("handle ");

            return this;
        }

        /// <summary>
        /// Globally unique identifier.
        /// </summary>
        public ShopPolicyQuery id() {
            Query.Append("id ");

            return this;
        }

        /// <summary>
        /// Policy’s title.
        /// </summary>
        public ShopPolicyQuery title() {
            Query.Append("title ");

            return this;
        }

        /// <summary>
        /// Public URL to the policy.
        /// </summary>
        public ShopPolicyQuery url() {
            Query.Append("url ");

            return this;
        }
    }
    }
