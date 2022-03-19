namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// An online store blog.
    /// </summary>
    public class Blog : AbstractResponse, ICloneable, Node {
        /// <summary>
        /// <see ref="Blog" /> Accepts deserialized json data.
        /// <see ref="Blog" /> Will further parse passed in data.
        /// </summary>
        /// <param name="dataJSON">Deserialized JSON data for Blog</param>
        public Blog(Dictionary<string, object> dataJSON) {
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
                    case "articleByHandle":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new Article((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "articles":

                    Data.Add(
                        key,

                        new ArticleConnection((Dictionary<string,object>) dataJSON[key])
                    );

                    break;

                    case "authors":

                    Data.Add(
                        key,

                        CastUtils.CastList<List<ArticleAuthor>>((IList) dataJSON[key])
                    );

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

        /// <summary>
        /// Find an article by its handle.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public Article articleByHandle(string alias = null) {
            return Get<Article>("articleByHandle", alias);
        }

        /// <summary>
        /// List of the blog's articles.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public ArticleConnection articles(string alias = null) {
            return Get<ArticleConnection>("articles", alias);
        }

        /// <summary>
        /// The authors who have contributed to the blog.
        /// </summary>
        public List<ArticleAuthor> authors() {
            return Get<List<ArticleAuthor>>("authors");
        }

        /// <summary>
        /// A human-friendly unique string for the Blog automatically generated from its title.
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
        /// The blogs’s title.
        /// </summary>
        public string title() {
            return Get<string>("title");
        }

        /// <summary>
        /// The url pointing to the blog accessible from the web.
        /// </summary>
        public string url() {
            return Get<string>("url");
        }

        public object Clone() {
            return new Blog(DataJSON);
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
