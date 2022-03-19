namespace Shopify.Unity {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    /// <summary>
    /// The method by which the discount's value is allocated onto its entitled lines.
    /// </summary>
    public enum DiscountApplicationAllocationMethod {
        /// <summary>
        /// If the SDK is not up to date with the schema in the Storefront API, it is possible
        /// to have enum values returned that are unknown to the SDK. In this case the value
        /// will actually be UNKNOWN.
        /// </summary>
        UNKNOWN,
        /// <summary>
        /// The value is spread across all entitled lines.
        /// </summary>
        ACROSS,
        /// <summary>
        /// The value is applied onto every entitled line.
        /// </summary>
        EACH
    }
    }
