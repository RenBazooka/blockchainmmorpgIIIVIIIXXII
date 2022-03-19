namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// The measurement used to calculate a unit price for a product variant (e.g. $9.99 / 100ml).
    /// </summary>
    public class UnitPriceMeasurement : AbstractResponse, ICloneable {
        /// <summary>
        /// <see ref="UnitPriceMeasurement" /> Accepts deserialized json data.
        /// <see ref="UnitPriceMeasurement" /> Will further parse passed in data.
        /// </summary>
        /// <param name="dataJSON">Deserialized JSON data for UnitPriceMeasurement</param>
        public UnitPriceMeasurement(Dictionary<string, object> dataJSON) {
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
                    case "measuredType":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            CastUtils.GetEnumValue<UnitPriceMeasurementMeasuredType>(dataJSON[key])
                        );
                    }

                    break;

                    case "quantityUnit":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            CastUtils.GetEnumValue<UnitPriceMeasurementMeasuredUnit>(dataJSON[key])
                        );
                    }

                    break;

                    case "quantityValue":

                    Data.Add(
                        key,

                        (double) dataJSON[key]
                    );

                    break;

                    case "referenceUnit":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            CastUtils.GetEnumValue<UnitPriceMeasurementMeasuredUnit>(dataJSON[key])
                        );
                    }

                    break;

                    case "referenceValue":

                    Data.Add(
                        key,

                        (long) dataJSON[key]
                    );

                    break;
                }
            }
        }

        /// <summary>
        /// The type of unit of measurement for the unit price measurement.
        /// </summary>
        public UnitPriceMeasurementMeasuredType? measuredType() {
            return Get<UnitPriceMeasurementMeasuredType?>("measuredType");
        }

        /// <summary>
        /// The quantity unit for the unit price measurement.
        /// </summary>
        public UnitPriceMeasurementMeasuredUnit? quantityUnit() {
            return Get<UnitPriceMeasurementMeasuredUnit?>("quantityUnit");
        }

        /// <summary>
        /// The quantity value for the unit price measurement.
        /// </summary>
        public double quantityValue() {
            return Get<double>("quantityValue");
        }

        /// <summary>
        /// The reference unit for the unit price measurement.
        /// </summary>
        public UnitPriceMeasurementMeasuredUnit? referenceUnit() {
            return Get<UnitPriceMeasurementMeasuredUnit?>("referenceUnit");
        }

        /// <summary>
        /// The reference value for the unit price measurement.
        /// </summary>
        public long referenceValue() {
            return Get<long>("referenceValue");
        }

        public object Clone() {
            return new UnitPriceMeasurement(DataJSON);
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
