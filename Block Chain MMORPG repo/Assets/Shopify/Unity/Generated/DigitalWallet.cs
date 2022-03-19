namespace Shopify.Unity {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    /// <summary>
    /// Digital wallet, such as Apple Pay, which can be used for accelerated checkouts.
    /// </summary>
    public enum DigitalWallet {
        /// <summary>
        /// If the SDK is not up to date with the schema in the Storefront API, it is possible
        /// to have enum values returned that are unknown to the SDK. In this case the value
        /// will actually be UNKNOWN.
        /// </summary>
        UNKNOWN,
        /// <summary>
        /// Android Pay.
        /// </summary>
        ANDROID_PAY,
        /// <summary>
        /// Apple Pay.
        /// </summary>
        APPLE_PAY,
        /// <summary>
        /// Google Pay.
        /// </summary>
        GOOGLE_PAY,
        /// <summary>
        /// Shopify Pay.
        /// </summary>
        SHOPIFY_PAY
    }
    }
