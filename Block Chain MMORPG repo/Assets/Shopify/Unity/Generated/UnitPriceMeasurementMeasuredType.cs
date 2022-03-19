namespace Shopify.Unity {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    /// <summary>
    /// The accepted types of unit of measurement.
    /// </summary>
    public enum UnitPriceMeasurementMeasuredType {
        /// <summary>
        /// If the SDK is not up to date with the schema in the Storefront API, it is possible
        /// to have enum values returned that are unknown to the SDK. In this case the value
        /// will actually be UNKNOWN.
        /// </summary>
        UNKNOWN,
        /// <summary>
        /// Unit of measurements representing areas.
        /// </summary>
        AREA,
        /// <summary>
        /// Unit of measurements representing lengths.
        /// </summary>
        LENGTH,
        /// <summary>
        /// Unit of measurements representing volumes.
        /// </summary>
        VOLUME,
        /// <summary>
        /// Unit of measurements representing weights.
        /// </summary>
        WEIGHT
    }
    }
