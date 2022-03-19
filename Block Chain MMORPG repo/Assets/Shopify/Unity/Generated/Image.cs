namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// Represents an image resource.
    /// </summary>
    public class Image : AbstractResponse, ICloneable {
        /// <summary>
        /// <see ref="Image" /> Accepts deserialized json data.
        /// <see ref="Image" /> Will further parse passed in data.
        /// </summary>
        /// <param name="dataJSON">Deserialized JSON data for Image</param>
        public Image(Dictionary<string, object> dataJSON) {
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
                    case "altText":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            (string) dataJSON[key]
                        );
                    }

                    break;

                    case "id":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            (string) dataJSON[key]
                        );
                    }

                    break;

                    case "originalSrc":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
                    );

                    break;

                    case "src":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
                    );

                    break;

                    case "transformedSrc":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
                    );

                    break;
                }
            }
        }

        /// <summary>
        /// A word or phrase to share the nature or contents of an image.
        /// </summary>
        public string altText() {
            return Get<string>("altText");
        }

        /// <summary>
        /// A unique identifier for the image.
        /// </summary>
        public string id() {
            return Get<string>("id");
        }

        /// <summary>
        /// The location of the original image as a URL.
        /// 
        /// If there are any existing transformations in the original source URL, they will remain and not be stripped.
        /// </summary>
        public string originalSrc() {
            return Get<string>("originalSrc");
        }

        /// \deprecated Previously an image had a single `src` field. This could either return the original image
        /// location or a URL that contained transformations such as sizing or scale.
        /// 
        /// These transformations were specified by arguments on the parent field.
        /// 
        /// Now an image has two distinct URL fields: `originalSrc` and `transformedSrc`.
        /// 
        /// * `originalSrc` - the original unmodified image URL
        /// * `transformedSrc` - the image URL with the specified transformations included
        /// 
        /// To migrate to the new fields, image transformations should be moved from the parent field to `transformedSrc`.
        /// 
        /// Before:
        /// ```graphql
        /// {
        /// shop {
        /// productImages(maxWidth: 200, scale: 2) {
        /// edges {
        /// node {
        /// src
        /// }
        /// }
        /// }
        /// }
        /// }
        /// ```
        /// 
        /// After:
        /// ```graphql
        /// {
        /// shop {
        /// productImages {
        /// edges {
        /// node {
        /// transformedSrc(maxWidth: 200, scale: 2)
        /// }
        /// }
        /// }
        /// }
        /// }
        /// ```
        /// <summary>
        /// The location of the image as a URL.
        /// </summary>
        public string src() {
            return Get<string>("src");
        }

        /// <summary>
        /// The location of the transformed image as a URL.
        /// 
        /// All transformation arguments are considered "best-effort". If they can be applied to an image, they will be.
        /// Otherwise any transformations which an image type does not support will be ignored.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public string transformedSrc(string alias = null) {
            return Get<string>("transformedSrc", alias);
        }

        public object Clone() {
            return new Image(DataJSON);
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
