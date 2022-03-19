namespace Shopify.Unity {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    /// <summary>
    /// Units of measurement for weight.
    /// </summary>
    public enum WeightUnit {
        /// <summary>
        /// If the SDK is not up to date with the schema in the Storefront API, it is possible
        /// to have enum values returned that are unknown to the SDK. In this case the value
        /// will actually be UNKNOWN.
        /// </summary>
        UNKNOWN,
        /// <summary>
        /// Metric system unit of mass.
        /// </summary>
        GRAMS,
        /// <summary>
        /// 1 kilogram equals 1000 grams.
        /// </summary>
        KILOGRAMS,
        /// <summary>
        /// Imperial system unit of mass.
        /// </summary>
        OUNCES,
        /// <summary>
        /// 1 pound equals 16 ounces.
        /// </summary>
        POUNDS
    }
    }
