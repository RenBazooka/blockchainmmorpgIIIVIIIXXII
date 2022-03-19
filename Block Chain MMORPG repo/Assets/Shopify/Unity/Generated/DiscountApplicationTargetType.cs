namespace Shopify.Unity {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    /// <summary>
    /// The type of line (i.e. line item or shipping line) on an order that the discount is applicable towards.
    /// </summary>
    public enum DiscountApplicationTargetType {
        /// <summary>
        /// If the SDK is not up to date with the schema in the Storefront API, it is possible
        /// to have enum values returned that are unknown to the SDK. In this case the value
        /// will actually be UNKNOWN.
        /// </summary>
        UNKNOWN,
        /// <summary>
        /// The discount applies onto line items.
        /// </summary>
        LINE_ITEM,
        /// <summary>
        /// The discount applies onto shipping lines.
        /// </summary>
        SHIPPING_LINE
    }
    }
