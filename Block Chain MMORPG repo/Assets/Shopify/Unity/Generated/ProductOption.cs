namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// Product property names like "Size", "Color", and "Material" that the customers can select.
    /// Variants are selected based on permutations of these options.
    /// 255 characters limit each.
    /// </summary>
    public class ProductOption : AbstractResponse, ICloneable, Node {
        /// <summary>
        /// <see ref="ProductOption" /> Accepts deserialized json data.
        /// <see ref="ProductOption" /> Will further parse passed in data.
        /// </summary>
        /// <param name="dataJSON">Deserialized JSON data for ProductOption</param>
        public ProductOption(Dictionary<string, object> dataJSON) {
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
                    case "id":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
                    );

                    break;

                    case "name":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
                    );

                    break;

                    case "values":

                    Data.Add(
                        key,

                        CastUtils.CastList<List<string>>((IList) dataJSON[key])
                    );

                    break;
                }
            }
        }

        /// <summary>
        /// Globally unique identifier.
        /// </summary>
        public string id() {
            return Get<string>("id");
        }

        /// <summary>
        /// The product option’s name.
        /// </summary>
        public string name() {
            return Get<string>("name");
        }

        /// <summary>
        /// The corresponding value to the product option name.
        /// </summary>
        public List<string> values() {
            return Get<List<string>>("values");
        }

        public object Clone() {
            return new ProductOption(DataJSON);
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
