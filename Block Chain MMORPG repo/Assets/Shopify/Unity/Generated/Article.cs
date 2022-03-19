namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// An article in an online store blog.
    /// </summary>
    public class Article : AbstractResponse, ICloneable, Node {
        /// <summary>
        /// <see ref="Article" /> Accepts deserialized json data.
        /// <see ref="Article" /> Will further parse passed in data.
        /// </summary>
        /// <param name="dataJSON">Deserialized JSON data for Article</param>
        public Article(Dictionary<string, object> dataJSON) {
            DataJSON = dataJSON;
            Data = new Dictionary<string,object>();

            foreach (string key in dataJSON.Keys) {
                string fieldName = key;
                Regex regexAlias = new Regex("^(.+)___.+$");
                Match match = regexAlias.Match(key);

                if (match.Success) {
                    fieldName = match.Groups[1].Value;
                }

                switch(fieldName) {
                    case "author":

                    Data.Add(
                        key,

                        new ArticleAuthor((Dictionary<string,object>) dataJSON[key])
                    );

                    break;

                    case "authorV2":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new ArticleAuthor((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "blog":

                    Data.Add(
                        key,

                        new Blog((Dictionary<string,object>) dataJSON[key])
                    );

                    break;

                    case "comments":

                    Data.Add(
                        key,

                        new CommentConnection((Dictionary<string,object>) dataJSON[key])
                    );

                    break;

                    case "content":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
                    );

                    break;

                    case "contentHtml":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
                    );

                    break;

                    case "excerpt":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            (string) dataJSON[key]
                        );
                    }

                    break;

                    case "excerptHtml":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            (string) dataJSON[key]
                        );
                    }

                    break;

                    case "handle":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
                    );

                    break;

                    case "id":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
                    );

                    break;

                    case "image":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new Image((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "publishedAt":

                    Data.Add(
                        key,

                        Convert.ToDateTime(dataJSON[key])
                    );

                    break;

                    case "seo":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new Seo((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "tags":

                    Data.Add(
                        key,

                        CastUtils.CastList<List<string>>((IList) dataJSON[key])
                    );

                    break;

                    case "title":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
                    );

                    break;

                    case "url":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
                    );

                    break;
                }
            }
        }

        /// \deprecated Use `authorV2` instead
        /// <summary>
        /// The article's author.
        /// </summary>
        public ArticleAuthor author() {
            return Get<ArticleAuthor>("author");
        }

        /// <summary>
        /// The article's author.
        /// </summary>
        public ArticleAuthor authorV2() {
            return Get<ArticleAuthor>("authorV2");
        }

        /// <summary>
        /// The blog that the article belongs to.
        /// </summary>
        public Blog blog() {
            return Get<Blog>("blog");
        }

        /// <summary>
        /// List of comments posted on the article.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public CommentConnection comments(string alias = null) {
            return Get<CommentConnection>("comments", alias);
        }

        /// <summary>
        /// Stripped content of the article, single line with HTML tags removed.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public string content(string alias = null) {
            return Get<string>("content", alias);
        }

        /// <summary>
        /// The content of the article, complete with HTML formatting.
        /// </summary>
        public string contentHtml() {
            return Get<string>("contentHtml");
        }

        /// <summary>
        /// Stripped excerpt of the article, single line with HTML tags removed.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public string excerpt(string alias = null) {
            return Get<string>("excerpt", alias);
        }

        /// <summary>
        /// The excerpt of the article, complete with HTML formatting.
        /// </summary>
        public string excerptHtml() {
            return Get<string>("excerptHtml");
        }

        /// <summary>
        /// A human-friendly unique string for the Article automatically generated from its title.
        /// </summary>
        public string handle() {
            return Get<string>("handle");
        }

        /// <summary>
        /// Globally unique identifier.
        /// </summary>
        public string id() {
            return Get<string>("id");
        }

        /// <summary>
        /// The image associated with the article.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public Image image(string alias = null) {
            return Get<Image>("image", alias);
        }

        /// <summary>
        /// The date and time when the article was published.
        /// </summary>
        public DateTime? publishedAt() {
            return Get<DateTime?>("publishedAt");
        }

        /// <summary>
        /// The article’s SEO information.
        /// </summary>
        public Seo seo() {
            return Get<Seo>("seo");
        }

        /// <summary>
        /// A categorization that a article can be tagged with.
        /// </summary>
        public List<string> tags() {
            return Get<List<string>>("tags");
        }

        /// <summary>
        /// The article’s name.
        /// </summary>
        public string title() {
            return Get<string>("title");
        }

        /// <summary>
        /// The url pointing to the article accessible from the web.
        /// </summary>
        public string url() {
            return Get<string>("url");
        }

        public object Clone() {
            return new Article(DataJSON);
        }

        private static List<Node> DataToNodeList(object data) {
            var objects = (List<object>)data;
            var nodes = new List<Node>();

            foreach (var obj in objects) {
                if (obj == null) continue;
                nodes.Add(UnknownNode.Create((Dictionary<string,object>) obj));
            }

            return nodes;
        }
    }
    }
