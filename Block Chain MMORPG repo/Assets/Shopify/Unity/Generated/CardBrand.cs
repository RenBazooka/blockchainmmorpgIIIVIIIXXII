namespace Shopify.Unity {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    /// <summary>
    /// Card brand, such as Visa or Mastercard, which can be used for payments.
    /// </summary>
    public enum CardBrand {
        /// <summary>
        /// If the SDK is not up to date with the schema in the Storefront API, it is possible
        /// to have enum values returned that are unknown to the SDK. In this case the value
        /// will actually be UNKNOWN.
        /// </summary>
        UNKNOWN,
        /// <summary>
        /// American Express
        /// </summary>
        AMERICAN_EXPRESS,
        /// <summary>
        /// Diners Club
        /// </summary>
        DINERS_CLUB,
        /// <summary>
        /// Discover
        /// </summary>
        DISCOVER,
        /// <summary>
        /// JCB
        /// </summary>
        JCB,
        /// <summary>
        /// Mastercard
        /// </summary>
        MASTERCARD,
        /// <summary>
        /// Visa
        /// </summary>
        VISA
    }
    }
