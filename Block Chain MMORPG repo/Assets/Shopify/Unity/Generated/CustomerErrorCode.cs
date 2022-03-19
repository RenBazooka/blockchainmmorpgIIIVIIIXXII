namespace Shopify.Unity {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    /// <summary>
    /// Possible error codes that could be returned by CustomerUserError.
    /// </summary>
    public enum CustomerErrorCode {
        /// <summary>
        /// If the SDK is not up to date with the schema in the Storefront API, it is possible
        /// to have enum values returned that are unknown to the SDK. In this case the value
        /// will actually be UNKNOWN.
        /// </summary>
        UNKNOWN,
        /// <summary>
        /// Customer already enabled.
        /// </summary>
        ALREADY_ENABLED,
        /// <summary>
        /// Input value is blank.
        /// </summary>
        BLANK,
        /// <summary>
        /// Input contains HTML tags.
        /// </summary>
        CONTAINS_HTML_TAGS,
        /// <summary>
        /// Input contains URL.
        /// </summary>
        CONTAINS_URL,
        /// <summary>
        /// Customer is disabled.
        /// </summary>
        CUSTOMER_DISABLED,
        /// <summary>
        /// Input value is invalid.
        /// </summary>
        INVALID,
        /// <summary>
        /// Address does not exist.
        /// </summary>
        NOT_FOUND,
        /// <summary>
        /// Input password starts or ends with whitespace.
        /// </summary>
        PASSWORD_STARTS_OR_ENDS_WITH_WHITESPACE,
        /// <summary>
        /// Input value is already taken.
        /// </summary>
        TAKEN,
        /// <summary>
        /// Invalid activation token.
        /// </summary>
        TOKEN_INVALID,
        /// <summary>
        /// Input value is too long.
        /// </summary>
        TOO_LONG,
        /// <summary>
        /// Input value is too short.
        /// </summary>
        TOO_SHORT,
        /// <summary>
        /// Unidentified customer.
        /// </summary>
        UNIDENTIFIED_CUSTOMER
    }
    }
