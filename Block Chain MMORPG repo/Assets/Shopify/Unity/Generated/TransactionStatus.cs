namespace Shopify.Unity {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    /// <summary>
    /// Transaction statuses describe the status of a transaction.
    /// </summary>
    public enum TransactionStatus {
        /// <summary>
        /// If the SDK is not up to date with the schema in the Storefront API, it is possible
        /// to have enum values returned that are unknown to the SDK. In this case the value
        /// will actually be UNKNOWN.
        /// </summary>
        UNKNOWN,
        /// <summary>
        /// There was an error while processing the transaction.
        /// </summary>
        ERROR,
        /// <summary>
        /// The transaction failed.
        /// </summary>
        FAILURE,
        /// <summary>
        /// The transaction is pending.
        /// </summary>
        PENDING,
        /// <summary>
        /// The transaction succeeded.
        /// </summary>
        SUCCESS
    }
    }
