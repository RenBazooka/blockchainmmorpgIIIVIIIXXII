namespace Shopify.Unity {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    /// <summary>
    /// The valid units of measurement for a unit price measurement.
    /// </summary>
    public enum UnitPriceMeasurementMeasuredUnit {
        /// <summary>
        /// If the SDK is not up to date with the schema in the Storefront API, it is possible
        /// to have enum values returned that are unknown to the SDK. In this case the value
        /// will actually be UNKNOWN.
        /// </summary>
        UNKNOWN,
        /// <summary>
        /// 100 centiliters equals 1 liter.
        /// </summary>
        CL,
        /// <summary>
        /// 100 centimeters equals 1 meter.
        /// </summary>
        CM,
        /// <summary>
        /// Metric system unit of weight.
        /// </summary>
        G,
        /// <summary>
        /// 1 kilogram equals 1000 grams.
        /// </summary>
        KG,
        /// <summary>
        /// Metric system unit of volume.
        /// </summary>
        L,
        /// <summary>
        /// Metric system unit of length.
        /// </summary>
        M,
        /// <summary>
        /// Metric system unit of area.
        /// </summary>
        M2,
        /// <summary>
        /// 1 cubic meter equals 1000 liters.
        /// </summary>
        M3,
        /// <summary>
        /// 1000 milligrams equals 1 gram.
        /// </summary>
        MG,
        /// <summary>
        /// 1000 milliliters equals 1 liter.
        /// </summary>
        ML,
        /// <summary>
        /// 1000 millimeters equals 1 meter.
        /// </summary>
        MM
    }
    }
