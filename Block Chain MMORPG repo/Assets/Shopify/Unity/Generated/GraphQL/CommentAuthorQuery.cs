namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void CommentAuthorDelegate(CommentAuthorQuery query);

    /// <summary>
    /// The author of a comment.
    /// </summary>
    public class CommentAuthorQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="CommentAuthorQuery" /> is used to build queries. Typically
        /// <see cref="CommentAuthorQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public CommentAuthorQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// The author's email.
        /// </summary>
        public CommentAuthorQuery email() {
            Query.Append("email ");

            return this;
        }

        /// <summary>
        /// The author’s name.
        /// </summary>
        public CommentAuthorQuery name() {
            Query.Append("name ");

            return this;
        }
    }
    }
