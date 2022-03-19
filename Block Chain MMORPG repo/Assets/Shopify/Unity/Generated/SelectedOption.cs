namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// Properties used by customers to select a product variant.
    /// Products can have multiple options, like different sizes or colors.
    /// </summary>
    public class SelectedOption : AbstractResponse, ICloneable {
        /// <summary>
        /// <see ref="SelectedOption" /> Accepts deserialized json data.
        /// <see ref="SelectedOption" /> Will further parse passed in data.
        /// </summary>
        /// <param name="dataJSON">Deserialized JSON data for SelectedOption</param>
        public SelectedOption(Dictionary<string, object> dataJSON) {
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
                    case "name":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
                    );

                    break;

                    case "value":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
                    );

                    break;
                }
            }
        }

        /// <summary>
        /// The product option’s name.
        /// </summary>
        public string name() {
            return Get<string>("name");
        }

        /// <summary>
        /// The product option’s value.
        /// </summary>
        public string value() {
            return Get<string>("value");
        }

        public object Clone() {
            return new SelectedOption(DataJSON);
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
