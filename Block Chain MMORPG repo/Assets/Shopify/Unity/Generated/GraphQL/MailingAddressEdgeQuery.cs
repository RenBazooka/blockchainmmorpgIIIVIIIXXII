namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void MailingAddressEdgeDelegate(MailingAddressEdgeQuery query);

    /// <summary>
    /// An auto-generated type which holds one MailingAddress and a cursor during pagination.
    /// </summary>
    public class MailingAddressEdgeQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="MailingAddressEdgeQuery" /> is used to build queries. Typically
        /// <see cref="MailingAddressEdgeQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public MailingAddressEdgeQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// A cursor for use in pagination.
        /// </summary>
        public MailingAddressEdgeQuery cursor() {
            Query.Append("cursor ");

            return this;
        }

        /// <summary>
        /// The item at the end of MailingAddressEdge.
        /// </summary>
        public MailingAddressEdgeQuery node(MailingAddressDelegate buildQuery) {
            Query.Append("node ");

            Query.Append("{");
            buildQuery(new MailingAddressQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
