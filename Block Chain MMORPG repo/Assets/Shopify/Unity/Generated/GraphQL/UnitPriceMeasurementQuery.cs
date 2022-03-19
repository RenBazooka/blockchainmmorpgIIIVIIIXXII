namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void UnitPriceMeasurementDelegate(UnitPriceMeasurementQuery query);

    /// <summary>
    /// The measurement used to calculate a unit price for a product variant (e.g. $9.99 / 100ml).
    /// </summary>
    public class UnitPriceMeasurementQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="UnitPriceMeasurementQuery" /> is used to build queries. Typically
        /// <see cref="UnitPriceMeasurementQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public UnitPriceMeasurementQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// The type of unit of measurement for the unit price measurement.
        /// </summary>
        public UnitPriceMeasurementQuery measuredType() {
            Query.Append("measuredType ");

            return this;
        }

        /// <summary>
        /// The quantity unit for the unit price measurement.
        /// </summary>
        public UnitPriceMeasurementQuery quantityUnit() {
            Query.Append("quantityUnit ");

            return this;
        }

        /// <summary>
        /// The quantity value for the unit price measurement.
        /// </summary>
        public UnitPriceMeasurementQuery quantityValue() {
            Query.Append("quantityValue ");

            return this;
        }

        /// <summary>
        /// The reference unit for the unit price measurement.
        /// </summary>
        public UnitPriceMeasurementQuery referenceUnit() {
            Query.Append("referenceUnit ");

            return this;
        }

        /// <summary>
        /// The reference value for the unit price measurement.
        /// </summary>
        public UnitPriceMeasurementQuery referenceValue() {
            Query.Append("referenceValue ");

            return this;
        }
    }
    }
