namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// Represents information about the metafields associated to the specified resource.
    /// </summary>
    public interface HasMetafields {
        /// <summary>
        /// The metafield associated with the resource.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        Metafield metafield(string alias = null);

        /// <summary>
        /// A paginated list of metafields associated with the resource.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        MetafieldConnection metafields(string alias = null);
    }

    /// <summary>
    /// UnknownHasMetafields is a response object.
    /// With <see cref="UnknownHasMetafields.Create" /> you'll be able instantiate objects implementing HasMetafields.
    /// <c>UnknownHasMetafields.Create</c> will return one of the following types:
    /// <list type="bullet">
    /// <item><description><see cref="Product" /></description></item>
    /// <item><description><see cref="ProductVariant" /></description></item>
    /// </list>
    /// </summary>
    public class UnknownHasMetafields : AbstractResponse, ICloneable, HasMetafields {
        /// <summary>
        /// Instantiate objects implementing <see cref="HasMetafields" />. Possible types are:
        /// <list type="bullet">
        /// <item><description><see cref="Product" /></description></item>
        /// <item><description><see cref="ProductVariant" /></description></item>
        /// </list>
        /// </summary>
        public static HasMetafields Create(Dictionary<string, object> dataJSON) {
            string typeName = (string) dataJSON["__typename"];

            switch(typeName) {
                case "Product":
                return new Product(dataJSON);

                case "ProductVariant":
                return new ProductVariant(dataJSON);

                default:
                return new UnknownHasMetafields(dataJSON);
            }
        }

        /// <summary>
        /// <see ref="UnknownHasMetafields" /> Accepts deserialized json data.
        /// <see ref="UnknownHasMetafields" /> Will further parse passed in data.
        /// </summary>
        /// <param name="dataJSON">Deserialized JSON data for HasMetafields</param>
        public UnknownHasMetafields(Dictionary<string, object> dataJSON) {
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
                    case "metafield":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            new Metafield((Dictionary<string,object>) dataJSON[key])
                        );
                    }

                    break;

                    case "metafields":

                    Data.Add(
                        key,

                        new MetafieldConnection((Dictionary<string,object>) dataJSON[key])
                    );

                    break;
                }
            }
        }

        /// <summary>
        /// The metafield associated with the resource.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public Metafield metafield(string alias = null) {
            return Get<Metafield>("metafield", alias);
        }

        /// <summary>
        /// A paginated list of metafields associated with the resource.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public MetafieldConnection metafields(string alias = null) {
            return Get<MetafieldConnection>("metafields", alias);
        }

        public object Clone() {
            return new UnknownHasMetafields(DataJSON);
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
