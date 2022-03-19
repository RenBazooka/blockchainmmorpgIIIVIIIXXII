namespace Shopify.Unity {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    /// <summary>
    /// Which lines on the order that the discount is allocated over, of the type
    /// defined by the Discount Application's target_type.
    /// </summary>
    public enum DiscountApplicationTargetSelection {
        /// <summary>
        /// If the SDK is not up to date with the schema in the Storefront API, it is possible
        /// to have enum values returned that are unknown to the SDK. In this case the value
        /// will actually be UNKNOWN.
        /// </summary>
        UNKNOWN,
        /// <summary>
        /// The discount is allocated onto all the lines.
        /// </summary>
        ALL,
        /// <summary>
        /// The discount is allocated onto only the lines it is entitled for.
        /// </summary>
        ENTITLED,
        /// <summary>
        /// The discount is allocated onto explicitly chosen lines.
        /// </summary>
        EXPLICIT
    }
    }
