namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void CommentDelegate(CommentQuery query);

    /// <summary>
    /// A comment on an article.
    /// </summary>
    public class CommentQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="CommentQuery" /> is used to build queries. Typically
        /// <see cref="CommentQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public CommentQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// The comment’s author.
        /// </summary>
        public CommentQuery author(CommentAuthorDelegate buildQuery) {
            Query.Append("author ");

            Query.Append("{");
            buildQuery(new CommentAuthorQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Stripped content of the comment, single line with HTML tags removed.
        /// </summary>
        /// <param name="truncateAt">
        /// Truncates string after the given length.
        /// </param>
        public CommentQuery content(long? truncateAt = null,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("content___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("content ");

            Arguments args = new Arguments();

            if (truncateAt != null) {
                args.Add("truncateAt", truncateAt);
            }

            Query.Append(args.ToString());

            return this;
        }

        /// <summary>
        /// The content of the comment, complete with HTML formatting.
        /// </summary>
        public CommentQuery contentHtml() {
            Query.Append("contentHtml ");

            return this;
        }

        /// <summary>
        /// Globally unique identifier.
        /// </summary>
        public CommentQuery id() {
            Query.Append("id ");

            return this;
        }
    }
    }
