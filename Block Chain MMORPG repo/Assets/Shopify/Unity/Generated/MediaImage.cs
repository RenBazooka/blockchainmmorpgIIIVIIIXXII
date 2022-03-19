namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// Represents a Shopify hosted image.
    /// </summary>
    public class MediaImage : AbstractResponse, ICloneable, Media, Node {
        /// <summary>
        /// <see ref="MediaImage" /> Accepts deserialized json data.
        /// <see ref="MediaImage" /> Will further parse passed in data.
        /// </summary>
        /// <param name="dataJSON">Deserialized JSON data for MediaImage</param>
        public MediaImage(Dictionary<string, object> dataJSON) {
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
                    case "alt":

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

                    case "mediaContentType":

                    Data.Add(
                        key,

                        CastUtils.GetEnumValue<MediaContentType>(dataJSON[key])
                    );

                    break;

                    case "previewImage":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new Image((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;
                }
            }
        }

        /// <summary>
        /// A word or phrase to share the nature or contents of a media.
        /// </summary>
        public string alt() {
            return Get<string>("alt");
        }

        /// <summary>
        /// Globally unique identifier.
        /// </summary>
        public string id() {
            return Get<string>("id");
        }

        /// <summary>
        /// The image for the media.
        /// </summary>
        public Image image() {
            return Get<Image>("image");
        }

        /// <summary>
        /// The media content type.
        /// </summary>
        public MediaContentType mediaContentType() {
            return Get<MediaContentType>("mediaContentType");
        }

        /// <summary>
        /// The preview image for the media.
        /// </summary>
        public Image previewImage() {
            return Get<Image>("previewImage");
        }

        public object Clone() {
            return new MediaImage(DataJSON);
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
