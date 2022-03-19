namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// Metafields represent custom metadata attached to a resource. Metafields can be sorted into namespaces and are
    /// comprised of keys, values, and value types.
    /// </summary>
    public class Metafield : AbstractResponse, ICloneable, Node {
        /// <summary>
        /// <see ref="Metafield" /> Accepts deserialized json data.
        /// <see ref="Metafield" /> Will further parse passed in data.
        /// </summary>
        /// <param name="dataJSON">Deserialized JSON data for Metafield</param>
        public Metafield(Dictionary<string, object> dataJSON) {
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
                    case "description":

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

                    case "key":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
                    );

                    break;

                    case "namespace":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
                    );

                    break;

                    case "parentResource":

                    Data.Add(
                        key,

                        UnknownMetafieldParentResource.Create((Dictionary<string,object>) dataJSON[key])
                    );

                    break;

                    case "value":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
                    );

                    break;

                    case "valueType":

                    Data.Add(
                        key,

                        CastUtils.GetEnumValue<MetafieldValueType>(dataJSON[key])
                    );

                    break;
                }
            }
        }

        /// <summary>
        /// The description of a metafield.
        /// </summary>
        public string description() {
            return Get<string>("description");
        }

        /// <summary>
        /// Globally unique identifier.
        /// </summary>
        public string id() {
            return Get<string>("id");
        }

        /// <summary>
        /// The key name for a metafield.
        /// </summary>
        public string key() {
            return Get<string>("key");
        }

        /// <summary>
        /// The namespace for a metafield.
        /// </summary>
        public string namespaceValue() {
            return Get<string>("namespace");
        }

        /// <summary>
        /// The parent object that the metafield belongs to.
        /// </summary>
        public MetafieldParentResource parentResource() {
            return Get<MetafieldParentResource>("parentResource");
        }

        /// <summary>
        /// The value of a metafield.
        /// </summary>
        public string value() {
            return Get<string>("value");
        }

        /// <summary>
        /// Represents the metafield value type.
        /// </summary>
        public MetafieldValueType valueType() {
            return Get<MetafieldValueType>("valueType");
        }

        public object Clone() {
            return new Metafield(DataJSON);
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
