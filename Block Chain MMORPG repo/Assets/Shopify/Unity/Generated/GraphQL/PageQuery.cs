namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void PageDelegate(PageQuery query);

    /// <summary>
    /// Shopify merchants can create pages to hold static HTML content. Each Page object represents a custom page on the online store.
    /// </summary>
    public class PageQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="PageQuery" /> is used to build queries. Typically
        /// <see cref="PageQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public PageQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// The description of the page, complete with HTML formatting.
        /// </summary>
        public PageQuery body() {
            Query.Append("body ");

            return this;
        }

        /// <summary>
        /// Summary of the page body.
        /// </summary>
        public PageQuery bodySummary() {
            Query.Append("bodySummary ");

            return this;
        }

        /// <summary>
        /// The timestamp of the page creation.
        /// </summary>
        public PageQuery createdAt() {
            Query.Append("createdAt ");

            return this;
        }

        /// <summary>
        /// A human-friendly unique string for the page automatically generated from its title.
        /// </summary>
        public PageQuery handle() {
            Query.Append("handle ");

            return this;
        }

        /// <summary>
        /// Globally unique identifier.
        /// </summary>
        public PageQuery id() {
            Query.Append("id ");

            return this;
        }

        /// <summary>
        /// The title of the page.
        /// </summary>
        public PageQuery title() {
            Query.Append("title ");

            return this;
        }

        /// <summary>
        /// The timestamp of the latest page update.
        /// </summary>
        public PageQuery updatedAt() {
            Query.Append("updatedAt ");

            return this;
        }

        /// <summary>
        /// The url pointing to the page accessible from the web.
        /// </summary>
        public PageQuery url() {
            Query.Append("url ");

            return this;
        }
    }
    }
