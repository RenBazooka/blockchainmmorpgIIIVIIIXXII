namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// Script discount applications capture the intentions of a discount that
    /// was created by a Shopify Script.
    /// </summary>
    public class ScriptDiscountApplication : AbstractResponse, ICloneable, DiscountApplication {
        /// <summary>
        /// <see ref="ScriptDiscountApplication" /> Accepts deserialized json data.
        /// <see ref="ScriptDiscountApplication" /> Will further parse passed in data.
        /// </summary>
        /// <param name="dataJSON">Deserialized JSON data for ScriptDiscountApplication</param>
        public ScriptDiscountApplication(Dictionary<string, object> dataJSON) {
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
                    case "allocationMethod":

                    Data.Add(
                        key,

                        CastUtils.GetEnumValue<DiscountApplicationAllocationMethod>(dataJSON[key])
                    );

                    break;

                    case "description":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
                    );

                    break;

                    case "targetSelection":

                    Data.Add(
                        key,

                        CastUtils.GetEnumValue<DiscountApplicationTargetSelection>(dataJSON[key])
                    );

                    break;

                    case "targetType":

                    Data.Add(
                        key,

                        CastUtils.GetEnumValue<DiscountApplicationTargetType>(dataJSON[key])
                    );

                    break;

                    case "title":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
                    );

                    break;

                    case "value":

                    Data.Add(
                        key,

                        UnknownPricingValue.Create((Dictionary<string,object>) dataJSON[key])
                    );

                    break;
                }
            }
        }

        /// <summary>
        /// The method by which the discount's value is allocated to its entitled items.
        /// </summary>
        public DiscountApplicationAllocationMethod allocationMethod() {
            return Get<DiscountApplicationAllocationMethod>("allocationMethod");
        }

        /// \deprecated Use `title` instead
        /// <summary>
        /// The description of the application as defined by the Script.
        /// </summary>
        public string description() {
            return Get<string>("description");
        }

        /// <summary>
        /// Which lines of targetType that the discount is allocated over.
        /// </summary>
        public DiscountApplicationTargetSelection targetSelection() {
            return Get<DiscountApplicationTargetSelection>("targetSelection");
        }

        /// <summary>
        /// The type of line that the discount is applicable towards.
        /// </summary>
        public DiscountApplicationTargetType targetType() {
            return Get<DiscountApplicationTargetType>("targetType");
        }

        /// <summary>
        /// The title of the application as defined by the Script.
        /// </summary>
        public string title() {
            return Get<string>("title");
        }

        /// <summary>
        /// The value of the discount application.
        /// </summary>
        public PricingValue value() {
            return Get<PricingValue>("value");
        }

        public object Clone() {
            return new ScriptDiscountApplication(DataJSON);
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
