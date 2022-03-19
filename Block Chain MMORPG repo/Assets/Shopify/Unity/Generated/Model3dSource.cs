namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// Represents a source for a Shopify hosted 3d model.
    /// </summary>
    public class Model3dSource : AbstractResponse, ICloneable {
        /// <summary>
        /// <see ref="Model3dSource" /> Accepts deserialized json data.
        /// <see ref="Model3dSource" /> Will further parse passed in data.
        /// </summary>
        /// <param name="dataJSON">Deserialized JSON data for Model3dSource</param>
        public Model3dSource(Dictionary<string, object> dataJSON) {
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
                    case "filesize":

                    Data.Add(
                        key,

                        (long) dataJSON[key]
                    );

                    break;

                    case "format":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
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
                }
            }
        }

        /// <summary>
        /// The filesize of the 3d model.
        /// </summary>
        public long filesize() {
            return Get<long>("filesize");
        }

        /// <summary>
        /// The format of the 3d model.
        /// </summary>
        public string format() {
            return Get<string>("format");
        }

        /// <summary>
        /// The MIME type of the 3d model.
        /// </summary>
        public string mimeType() {
            return Get<string>("mimeType");
        }

        /// <summary>
        /// The URL of the 3d model.
        /// </summary>
        public string url() {
            return Get<string>("url");
        }

        public object Clone() {
            return new Model3dSource(DataJSON);
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
