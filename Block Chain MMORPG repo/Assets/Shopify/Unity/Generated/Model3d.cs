namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// Represents a Shopify hosted 3D model.
    /// </summary>
    public class Model3d : AbstractResponse, ICloneable, Media, Node {
        /// <summary>
        /// <see ref="Model3d" /> Accepts deserialized json data.
        /// <see ref="Model3d" /> Will further parse passed in data.
        /// </summary>
        /// <param name="dataJSON">Deserialized JSON data for Model3d</param>
        public Model3d(Dictionary<string, object> dataJSON) {
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

                    case "sources":

                    Data.Add(
                        key,

                        CastUtils.CastList<List<Model3dSource>>((IList) dataJSON[key])
                    );

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

        /// <summary>
        /// The sources for a 3d model.
        /// </summary>
        public List<Model3dSource> sources() {
            return Get<List<Model3dSource>>("sources");
        }

        public object Clone() {
            return new Model3d(DataJSON);
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
