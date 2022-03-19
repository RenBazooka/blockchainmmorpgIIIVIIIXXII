namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// Discount applications capture the intentions of a discount source at
    /// the time of application.
    /// </summary>
    public interface DiscountApplication {
        /// <summary>
        /// The method by which the discount's value is allocated to its entitled items.
        /// </summary>
        DiscountApplicationAllocationMethod allocationMethod();

        /// <summary>
        /// Which lines of targetType that the discount is allocated over.
        /// </summary>
        DiscountApplicationTargetSelection targetSelection();

        /// <summary>
        /// The type of line that the discount is applicable towards.
        /// </summary>
        DiscountApplicationTargetType targetType();

        /// <summary>
        /// The value of the discount application.
        /// </summary>
        PricingValue value();
    }

    /// <summary>
    /// UnknownDiscountApplication is a response object.
    /// With <see cref="UnknownDiscountApplication.Create" /> you'll be able instantiate objects implementing DiscountApplication.
    /// <c>UnknownDiscountApplication.Create</c> will return one of the following types:
    /// <list type="bullet">
    /// <item><description><see cref="AutomaticDiscountApplication" /></description></item>
    /// <item><description><see cref="DiscountCodeApplication" /></description></item>
    /// <item><description><see cref="ManualDiscountApplication" /></description></item>
    /// <item><description><see cref="ScriptDiscountApplication" /></description></item>
    /// </list>
    /// </summary>
    public class UnknownDiscountApplication : AbstractResponse, ICloneable, DiscountApplication {
        /// <summary>
        /// Instantiate objects implementing <see cref="DiscountApplication" />. Possible types are:
        /// <list type="bullet">
        /// <item><description><see cref="AutomaticDiscountApplication" /></description></item>
        /// <item><description><see cref="DiscountCodeApplication" /></description></item>
        /// <item><description><see cref="ManualDiscountApplication" /></description></item>
        /// <item><description><see cref="ScriptDiscountApplication" /></description></item>
        /// </list>
        /// </summary>
        public static DiscountApplication Create(Dictionary<string, object> dataJSON) {
            string typeName = (string) dataJSON["__typename"];

            switch(typeName) {
                case "AutomaticDiscountApplication":
                return new AutomaticDiscountApplication(dataJSON);

                case "DiscountCodeApplication":
                return new DiscountCodeApplication(dataJSON);

                case "ManualDiscountApplication":
                return new ManualDiscountApplication(dataJSON);

                case "ScriptDiscountApplication":
                return new ScriptDiscountApplication(dataJSON);

                default:
                return new UnknownDiscountApplication(dataJSON);
            }
        }

        /// <summary>
        /// <see ref="UnknownDiscountApplication" /> Accepts deserialized json data.
        /// <see ref="UnknownDiscountApplication" /> Will further parse passed in data.
        /// </summary>
        /// <param name="dataJSON">Deserialized JSON data for DiscountApplication</param>
        public UnknownDiscountApplication(Dictionary<string, object> dataJSON) {
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
        /// The value of the discount application.
        /// </summary>
        public PricingValue value() {
            return Get<PricingValue>("value");
        }

        public object Clone() {
            return new UnknownDiscountApplication(DataJSON);
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
