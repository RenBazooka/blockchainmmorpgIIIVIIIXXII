namespace Shopify.Unity {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    /// <summary>
    /// The different kinds of order transactions.
    /// </summary>
    public enum TransactionKind {
        /// <summary>
        /// If the SDK is not up to date with the schema in the Storefront API, it is possible
        /// to have enum values returned that are unknown to the SDK. In this case the value
        /// will actually be UNKNOWN.
        /// </summary>
        UNKNOWN,
        /// <summary>
        /// An amount reserved against the cardholder's funding source.
        /// Money does not change hands until the authorization is captured.
        /// </summary>
        AUTHORIZATION,
        /// <summary>
        /// A transfer of the money that was reserved during the authorization stage.
        /// </summary>
        CAPTURE,
        /// <summary>
        /// Money returned to the customer when they have paid too much.
        /// </summary>
        CHANGE,
        /// <summary>
        /// An authorization for a payment taken with an EMV credit card reader.
        /// </summary>
        EMV_AUTHORIZATION,
        /// <summary>
        /// An authorization and capture performed together in a single step.
        /// </summary>
        SALE
    }
    }
