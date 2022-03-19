namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// Represents a source for a Shopify hosted video.
    /// </summary>
    public class VideoSource : AbstractResponse, ICloneable {
        /// <summary>
        /// <see ref="VideoSource" /> Accepts deserialized json data.
        /// <see ref="VideoSource" /> Will further parse passed in data.
        /// </summary>
        /// <param name="dataJSON">Deserialized JSON data for VideoSource</param>
        public VideoSource(Dictionary<string, object> dataJSON) {
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
                    case "format":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
                    );

                    break;

                    case "height":

                    Data.Add(
                        key,

                        (long) dataJSON[key]
                    );

                    break;

                    case "mimeType":

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

                    case "width":

                    Data.Add(
                        key,

                        (long) dataJSON[key]
                    );

                    break;
                }
            }
        }

        /// <summary>
        /// The format of the video source.
        /// </summary>
        public string format() {
            return Get<string>("format");
        }

        /// <summary>
        /// The height of the video.
        /// </summary>
        public long height() {
            return Get<long>("height");
        }

        /// <summary>
        /// The video MIME type.
        /// </summary>
        public string mimeType() {
            return Get<string>("mimeType");
        }

        /// <summary>
        /// The URL of the video.
        /// </summary>
        public string url() {
            return Get<string>("url");
        }

        /// <summary>
        /// The width of the video.
        /// </summary>
        public long width() {
            return Get<long>("width");
        }

        public object Clone() {
            return new VideoSource(DataJSON);
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
