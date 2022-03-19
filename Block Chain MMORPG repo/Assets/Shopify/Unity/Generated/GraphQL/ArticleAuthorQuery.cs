namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void ArticleAuthorDelegate(ArticleAuthorQuery query);

    /// <summary>
    /// The author of an article.
    /// </summary>
    public class ArticleAuthorQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="ArticleAuthorQuery" /> is used to build queries. Typically
        /// <see cref="ArticleAuthorQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public ArticleAuthorQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// The author's bio.
        /// </summary>
        public ArticleAuthorQuery bio() {
            Query.Append("bio ");

            return this;
        }

        /// <summary>
        /// The author’s email.
        /// </summary>
        public ArticleAuthorQuery email() {
            Query.Append("email ");

            return this;
        }

        /// <summary>
        /// The author's first name.
        /// </summary>
        public ArticleAuthorQuery firstName() {
            Query.Append("firstName ");

            return this;
        }

        /// <summary>
        /// The author's last name.
        /// </summary>
        public ArticleAuthorQuery lastName() {
            Query.Append("lastName ");

            return this;
        }

        /// <summary>
        /// The author's full name.
        /// </summary>
        public ArticleAuthorQuery name() {
            Query.Append("name ");

            return this;
        }
    }
    }
