namespace Shopify.Unity {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    /// <summary>
    /// The possible content types for a media object.
    /// </summary>
    public enum MediaContentType {
        /// <summary>
        /// If the SDK is not up to date with the schema in the Storefront API, it is possible
        /// to have enum values returned that are unknown to the SDK. In this case the value
        /// will actually be UNKNOWN.
        /// </summary>
        UNKNOWN,
        /// <summary>
        /// An externally hosted video.
        /// </summary>
        EXTERNAL_VIDEO,
        /// <summary>
        /// A Shopify hosted image.
        /// </summary>
        IMAGE,
        /// <summary>
        /// A 3d model.
        /// </summary>
        MODEL_3D,
        /// <summary>
        /// A Shopify hosted video.
        /// </summary>
        VIDEO
    }
    }
