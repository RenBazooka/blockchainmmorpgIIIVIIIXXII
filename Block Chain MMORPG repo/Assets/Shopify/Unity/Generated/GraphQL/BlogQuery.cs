namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void BlogDelegate(BlogQuery query);

    /// <summary>
    /// An online store blog.
    /// </summary>
    public class BlogQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="BlogQuery" /> is used to build queries. Typically
        /// <see cref="BlogQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public BlogQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// Find an article by its handle.
        /// </summary>
        /// <param name="handle">
        /// The handle of the article.
        /// </param>
        public BlogQuery articleByHandle(ArticleDelegate buildQuery,string handle,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("articleByHandle___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("articleByHandle ");

            Arguments args = new Arguments();

            args.Add("handle", handle);

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new ArticleQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// List of the blog's articles.
        /// </summary>
        /// <param name="first">
        /// Returns up to the first `n` elements from the list.
        /// </param>
        /// <param name="after">
        /// Returns the elements that come after the specified cursor.
        /// </param>
        /// <param name="last">
        /// Returns up to the last `n` elements from the list.
        /// </param>
        /// <param name="before">
        /// Returns the elements that come before the specified cursor.
        /// </param>
        /// <param name="reverse">
        /// Reverse the order of the underlying list.
        /// </param>
        /// <param name="sortKey">
        /// Sort the underlying list by the given key.
        /// </param>
        /// <param name="query">
        /// Supported filter parameters:
        /// - `author`
        /// - `blog_title`
        /// - `created_at`
        /// - `tag`
        /// - `updated_at`
        /// 
        /// See the detailed [search syntax](https://help.shopify.com/api/getting-started/search-syntax)
        /// for more information about using filters.
        /// </param>
        public BlogQuery articles(ArticleConnectionDelegate buildQuery,long? first = null,string after = null,long? last = null,string before = null,bool? reverse = null,ArticleSortKeys? sortKey = null,string queryValue = null,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("articles___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("articles ");

            Arguments args = new Arguments();

            if (first != null) {
                args.Add("first", first);
            }

            if (after != null) {
                args.Add("after", after);
            }

            if (last != null) {
                args.Add("last", last);
            }

            if (before != null) {
                args.Add("before", before);
            }

            if (reverse != null) {
                args.Add("reverse", reverse);
            }

            if (sortKey != null) {
                args.Add("sortKey", sortKey);
            }

            if (queryValue != null) {
                args.Add("query", queryValue);
            }

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new ArticleConnectionQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// The authors who have contributed to the blog.
        /// </summary>
        public BlogQuery authors(ArticleAuthorDelegate buildQuery) {
            Query.Append("authors ");

            Query.Append("{");
            buildQuery(new ArticleAuthorQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// A human-friendly unique string for the Blog automatically generated from its title.
        /// </summary>
        public BlogQuery handle() {
            Query.Append("handle ");

            return this;
        }

        /// <summary>
        /// Globally unique identifier.
        /// </summary>
        public BlogQuery id() {
            Query.Append("id ");

            return this;
        }

        /// <summary>
        /// The blogs’s title.
        /// </summary>
        public BlogQuery title() {
            Query.Append("title ");

            return this;
        }

        /// <summary>
        /// The url pointing to the blog accessible from the web.
        /// </summary>
        public BlogQuery url() {
            Query.Append("url ");

            return this;
        }
    }
    }
