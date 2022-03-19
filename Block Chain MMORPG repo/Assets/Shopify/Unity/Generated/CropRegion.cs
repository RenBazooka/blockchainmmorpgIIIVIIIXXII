namespace Shopify.Unity {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    /// <summary>
    /// The part of the image that should remain after cropping.
    /// </summary>
    public enum CropRegion {
        /// <summary>
        /// If the SDK is not up to date with the schema in the Storefront API, it is possible
        /// to have enum values returned that are unknown to the SDK. In this case the value
        /// will actually be UNKNOWN.
        /// </summary>
        UNKNOWN,
        /// <summary>
        /// Keep the bottom of the image.
        /// </summary>
        BOTTOM,
        /// <summary>
        /// Keep the center of the image.
        /// </summary>
        CENTER,
        /// <summary>
        /// Keep the left of the image.
        /// </summary>
        LEFT,
        /// <summary>
        /// Keep the right of the image.
        /// </summary>
        RIGHT,
        /// <summary>
        /// Keep the top of the image.
        /// </summary>
        TOP
    }
    }
