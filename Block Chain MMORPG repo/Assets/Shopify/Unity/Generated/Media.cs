namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// Represents a media interface.
    /// </summary>
    public interface Media {
        /// <summary>
        /// A word or phrase to share the nature or contents of a media.
        /// </summary>
        string alt();

        /// <summary>
        /// The media content type.
        /// </summary>
        MediaContentType mediaContentType();

        /// <summary>
        /// The preview image for the media.
        /// </summary>
        Image previewImage();
    }

    /// <summary>
    /// UnknownMedia is a response object.
    /// With <see cref="UnknownMedia.Create" /> you'll be able instantiate objects implementing Media.
    /// <c>UnknownMedia.Create</c> will return one of the following types:
    /// <list type="bullet">
    /// <item><description><see cref="ExternalVideo" /></description></item>
    /// <item><description><see cref="MediaImage" /></description></item>
    /// <item><description><see cref="Model3d" /></description></item>
    /// <item><description><see cref="Video" /></description></item>
    /// </list>
    /// </summary>
    public class UnknownMedia : AbstractResponse, ICloneable, Media {
        /// <summary>
        /// Instantiate objects implementing <see cref="Media" />. Possible types are:
        /// <list type="bullet">
        /// <item><description><see cref="ExternalVideo" /></description></item>
        /// <item><description><see cref="MediaImage" /></description></item>
        /// <item><description><see cref="Model3d" /></description></item>
        /// <item><description><see cref="Video" /></description></item>
        /// </list>
        /// </summary>
        public static Media Create(Dictionary<string, object> dataJSON) {
            string typeName = (string) dataJSON["__typename"];

            switch(typeName) {
                case "ExternalVideo":
                return new ExternalVideo(dataJSON);

                case "MediaImage":
                return new MediaImage(dataJSON);

                case "Model3d":
                return new Model3d(dataJSON);

                case "Video":
                return new Video(dataJSON);

                default:
                return new UnknownMedia(dataJSON);
            }
        }

        /// <summary>
        /// <see ref="UnknownMedia" /> Accepts deserialized json data.
        /// <see ref="UnknownMedia" /> Will further parse passed in data.
        /// </summary>
        /// <param name="dataJSON">Deserialized JSON data for Media</param>
        public UnknownMedia(Dictionary<string, object> dataJSON) {
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
            return new UnknownMedia(DataJSON);
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
