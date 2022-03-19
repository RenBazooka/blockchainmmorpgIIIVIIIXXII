namespace Shopify.Unity {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    /// <summary>
    /// The set of valid sort keys for the Article query.
    /// </summary>
    public enum ArticleSortKeys {
        /// <summary>
        /// If the SDK is not up to date with the schema in the Storefront API, it is possible
        /// to have enum values returned that are unknown to the SDK. In this case the value
        /// will actually be UNKNOWN.
        /// </summary>
        UNKNOWN,
        /// <summary>
        /// Sort by the `author` value.
        /// </summary>
        AUTHOR,
        /// <summary>
        /// Sort by the `blog_title` value.
        /// </summary>
        BLOG_TITLE,
        /// <summary>
        /// Sort by the `id` value.
        /// </summary>
        ID,
        /// <summary>
        /// Sort by the `published_at` value.
        /// </summary>
        PUBLISHED_AT,
        /// <summary>
        /// During a search (i.e. when the `query` parameter has been specified on the connection) this sorts the
        /// results by relevance to the search term(s). When no search query is specified, this sort key is not
        /// deterministic and should not be used.
        /// </summary>
        RELEVANCE,
        /// <summary>
        /// Sort by the `title` value.
        /// </summary>
        TITLE,
        /// <summary>
        /// Sort by the `updated_at` value.
        /// </summary>
        UPDATED_AT
    }
    }
