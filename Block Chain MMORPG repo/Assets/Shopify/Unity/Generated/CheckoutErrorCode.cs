namespace Shopify.Unity {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    /// <summary>
    /// Possible error codes that could be returned by CheckoutUserError.
    /// </summary>
    public enum CheckoutErrorCode {
        /// <summary>
        /// If the SDK is not up to date with the schema in the Storefront API, it is possible
        /// to have enum values returned that are unknown to the SDK. In this case the value
        /// will actually be UNKNOWN.
        /// </summary>
        UNKNOWN,
        /// <summary>
        /// Checkout is already completed.
        /// </summary>
        ALREADY_COMPLETED,
        /// <summary>
        /// Input email contains an invalid domain name.
        /// </summary>
        BAD_DOMAIN,
        /// <summary>
        /// Input value is blank.
        /// </summary>
        BLANK,
        /// <summary>
        /// Cart does not meet discount requirements notice.
        /// </summary>
        CART_DOES_NOT_MEET_DISCOUNT_REQUIREMENTS_NOTICE,
        /// <summary>
        /// Customer already used once per customer discount notice.
        /// </summary>
        CUSTOMER_ALREADY_USED_ONCE_PER_CUSTOMER_DISCOUNT_NOTICE,
        /// <summary>
        /// Discount disabled.
        /// </summary>
        DISCOUNT_DISABLED,
        /// <summary>
        /// Discount expired.
        /// </summary>
        DISCOUNT_EXPIRED,
        /// <summary>
        /// Discount limit reached.
        /// </summary>
        DISCOUNT_LIMIT_REACHED,
        /// <summary>
        /// Discount not found.
        /// </summary>
        DISCOUNT_NOT_FOUND,
        /// <summary>
        /// Checkout is already completed.
        /// </summary>
        EMPTY,
        /// <summary>
        /// Gift card has already been applied.
        /// </summary>
        GIFT_CARD_ALREADY_APPLIED,
        /// <summary>
        /// Gift card code is invalid.
        /// </summary>
        GIFT_CARD_CODE_INVALID,
        /// <summary>
        /// Gift card currency does not match checkout currency.
        /// </summary>
        GIFT_CARD_CURRENCY_MISMATCH,
        /// <summary>
        /// Gift card has no funds left.
        /// </summary>
        GIFT_CARD_DEPLETED,
        /// <summary>
        /// Gift card is disabled.
        /// </summary>
        GIFT_CARD_DISABLED,
        /// <summary>
        /// Gift card is expired.
        /// </summary>
        GIFT_CARD_EXPIRED,
        /// <summary>
        /// Gift card was not found.
        /// </summary>
        GIFT_CARD_NOT_FOUND,
        /// <summary>
        /// Gift card cannot be applied to a checkout that contains a gift card.
        /// </summary>
        GIFT_CARD_UNUSABLE,
        /// <summary>
        /// Input value should be greater than or equal to minimum allowed value.
        /// </summary>
        GREATER_THAN_OR_EQUAL_TO,
        /// <summary>
        /// Input value is invalid.
        /// </summary>
        INVALID,
        /// <summary>
        /// Input Zip is invalid for country provided.
        /// </summary>
        INVALID_FOR_COUNTRY,
        /// <summary>
        /// Input Zip is invalid for country and province provided.
        /// </summary>
        INVALID_FOR_COUNTRY_AND_PROVINCE,
        /// <summary>
        /// Invalid province in country.
        /// </summary>
        INVALID_PROVINCE_IN_COUNTRY,
        /// <summary>
        /// Invalid region in country.
        /// </summary>
        INVALID_REGION_IN_COUNTRY,
        /// <summary>
        /// Invalid state in country.
        /// </summary>
        INVALID_STATE_IN_COUNTRY,
        /// <summary>
        /// Input value should be less than maximum allowed value.
        /// </summary>
        LESS_THAN,
        /// <summary>
        /// Input value should be less or equal to maximum allowed value.
        /// </summary>
        LESS_THAN_OR_EQUAL_TO,
        /// <summary>
        /// Line item was not found in checkout.
        /// </summary>
        LINE_ITEM_NOT_FOUND,
        /// <summary>
        /// Checkout is locked.
        /// </summary>
        LOCKED,
        /// <summary>
        /// Missing payment input.
        /// </summary>
        MISSING_PAYMENT_INPUT,
        /// <summary>
        /// Not enough in stock.
        /// </summary>
        NOT_ENOUGH_IN_STOCK,
        /// <summary>
        /// Input value is not supported.
        /// </summary>
        NOT_SUPPORTED,
        /// <summary>
        /// Input value is not present.
        /// </summary>
        PRESENT,
        /// <summary>
        /// Shipping rate expired.
        /// </summary>
        SHIPPING_RATE_EXPIRED,
        /// <summary>
        /// Input value is too long.
        /// </summary>
        TOO_LONG,
        /// <summary>
        /// The amount of the payment does not match the value to be paid.
        /// </summary>
        TOTAL_PRICE_MISMATCH,
        /// <summary>
        /// Unable to apply discount.
        /// </summary>
        UNABLE_TO_APPLY
    }
    }
