namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void MailingAddressConnectionDelegate(MailingAddressConnectionQuery query);

    /// <summary>
    /// An auto-generated type for paginating through multiple MailingAddresses.
    /// </summary>
    public class MailingAddressConnectionQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="MailingAddressConnectionQuery" /> is used to build queries. Typically
        /// <see cref="MailingAddressConnectionQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public MailingAddressConnectionQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// A list of edges.
        /// </summary>
        public MailingAddressConnectionQuery edges(MailingAddressEdgeDelegate buildQuery) {
            Query.Append("edges ");

            Query.Append("{");
            buildQuery(new MailingAddressEdgeQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Information to aid in pagination.
        /// </summary>
        public MailingAddressConnectionQuery pageInfo(PageInfoDelegate buildQuery) {
            Query.Append("pageInfo ");

            Query.Append("{");
            buildQuery(new PageInfoQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
