namespace Shopify.Unity {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    /// <summary>
    /// Metafield value types.
    /// </summary>
    public enum MetafieldValueType {
        /// <summary>
        /// If the SDK is not up to date with the schema in the Storefront API, it is possible
        /// to have enum values returned that are unknown to the SDK. In this case the value
        /// will actually be UNKNOWN.
        /// </summary>
        UNKNOWN,
        /// <summary>
        /// An integer metafield.
        /// </summary>
        INTEGER,
        /// <summary>
        /// A json string metafield.
        /// </summary>
        JSON_STRING,
        /// <summary>
        /// A string metafield.
        /// </summary>
        STRING
    }
    }
