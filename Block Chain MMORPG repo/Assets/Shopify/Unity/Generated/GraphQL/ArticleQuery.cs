namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void ArticleDelegate(ArticleQuery query);

    /// <summary>
    /// An article in an online store blog.
    /// </summary>
    public class ArticleQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="ArticleQuery" /> is used to build queries. Typically
        /// <see cref="ArticleQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public ArticleQuery(StringBuilder query) {
            Query = query;
        }

        /// \deprecated Use `authorV2` instead
        /// <summary>
        /// The article's author.
        /// </summary>
        public ArticleQuery author(ArticleAuthorDelegate buildQuery) {
            Log.DeprecatedQueryField("Article", "author", "Use `authorV2` instead");

            Query.Append("author ");

            Query.Append("{");
            buildQuery(new ArticleAuthorQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// The article's author.
        /// </summary>
        public ArticleQuery authorV2(ArticleAuthorDelegate buildQuery) {
            Query.Append("authorV2 ");

            Query.Append("{");
            buildQuery(new ArticleAuthorQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// The blog that the article belongs to.
        /// </summary>
        public ArticleQuery blog(BlogDelegate buildQuery) {
            Query.Append("blog ");

            Query.Append("{");
            buildQuery(new BlogQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// List of comments posted on the article.
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
        public ArticleQuery comments(CommentConnectionDelegate buildQuery,long? first = null,string after = null,long? last = null,string before = null,bool? reverse = null,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("comments___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("comments ");

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

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new CommentConnectionQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Stripped content of the article, single line with HTML tags removed.
        /// </summary>
        /// <param name="truncateAt">
        /// Truncates string after the given length.
        /// </param>
        public ArticleQuery content(long? truncateAt = null,string alias = null) {
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
        /// The content of the article, complete with HTML formatting.
        /// </summary>
        public ArticleQuery contentHtml() {
            Query.Append("contentHtml ");

            return this;
        }

        /// <summary>
        /// Stripped excerpt of the article, single line with HTML tags removed.
        /// </summary>
        /// <param name="truncateAt">
        /// Truncates string after the given length.
        /// </param>
        public ArticleQuery excerpt(long? truncateAt = null,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("excerpt___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("excerpt ");

            Arguments args = new Arguments();

            if (truncateAt != null) {
                args.Add("truncateAt", truncateAt);
            }

            Query.Append(args.ToString());

            return this;
        }

        /// <summary>
        /// The excerpt of the article, complete with HTML formatting.
        /// </summary>
        public ArticleQuery excerptHtml() {
            Query.Append("excerptHtml ");

            return this;
        }

        /// <summary>
        /// A human-friendly unique string for the Article automatically generated from its title.
        /// </summary>
        public ArticleQuery handle() {
            Query.Append("handle ");

            return this;
        }

        /// <summary>
        /// Globally unique identifier.
        /// </summary>
        public ArticleQuery id() {
            Query.Append("id ");

            return this;
        }

        /// <summary>
        /// The image associated with the article.
        /// </summary>
        /// <param name="maxWidth">
        /// Image width in pixels between 1 and 2048. This argument is deprecated: Use `maxWidth` on `Image.transformedSrc` instead.
        /// </param>
        /// <param name="maxHeight">
        /// Image height in pixels between 1 and 2048. This argument is deprecated: Use `maxHeight` on `Image.transformedSrc` instead.
        /// </param>
        /// <param name="crop">
        /// Crops the image according to the specified region. This argument is deprecated: Use `crop` on `Image.transformedSrc` instead.
        /// </param>
        /// <param name="scale">
        /// Image size multiplier for high-resolution retina displays. Must be between 1 and 3. This argument is deprecated: Use `scale` on `Image.transformedSrc` instead.
        /// </param>
        public ArticleQuery image(ImageDelegate buildQuery,long? maxWidth = null,long? maxHeight = null,CropRegion? crop = null,long? scale = null,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("image___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("image ");

            Arguments args = new Arguments();

            if (maxWidth != null) {
                args.Add("maxWidth", maxWidth);
            }

            if (maxHeight != null) {
                args.Add("maxHeight", maxHeight);
            }

            if (crop != null) {
                args.Add("crop", crop);
            }

            if (scale != null) {
                args.Add("scale", scale);
            }

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new ImageQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// The date and time when the article was published.
        /// </summary>
        public ArticleQuery publishedAt() {
            Query.Append("publishedAt ");

            return this;
        }

        /// <summary>
        /// The article’s SEO information.
        /// </summary>
        public ArticleQuery seo(SeoDelegate buildQuery) {
            Query.Append("seo ");

            Query.Append("{");
            buildQuery(new SeoQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// A categorization that a article can be tagged with.
        /// </summary>
        public ArticleQuery tags() {
            Query.Append("tags ");

            return this;
        }

        /// <summary>
        /// The article’s name.
        /// </summary>
        public ArticleQuery title() {
            Query.Append("title ");

            return this;
        }

        /// <summary>
        /// The url pointing to the article accessible from the web.
        /// </summary>
        public ArticleQuery url() {
            Query.Append("url ");

            return this;
        }
    }
    }
