namespace Shopify.Unity {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    /// <summary>
    /// Specifies the fields required to create a checkout.
    /// </summary>
    public class CheckoutCreateInput : InputBase {
        public const string emailFieldKey = "email";

        public const string lineItemsFieldKey = "lineItems";

        public const string shippingAddressFieldKey = "shippingAddress";

        public const string noteFieldKey = "note";

        public const string customAttributesFieldKey = "customAttributes";

        public const string allowPartialAddressesFieldKey = "allowPartialAddresses";

        public const string presentmentCurrencyCodeFieldKey = "presentmentCurrencyCode";

        /// <summary>
        /// The email with which the customer wants to checkout.
        /// </summary>
        public string email {
            get {
                return (string) Get(emailFieldKey);
            }
            set {
                Set(emailFieldKey, value);
            }
        }

        /// <summary>
        /// A list of line item objects, each one containing information about an item in the checkout.
        /// </summary>
        public List<CheckoutLineItemInput> lineItems {
            get {
                return (List<CheckoutLineItemInput>) Get(lineItemsFieldKey);
            }
            set {
                Set(lineItemsFieldKey, value);
            }
        }

        /// <summary>
        /// The shipping address to where the line items will be shipped.
        /// </summary>
        public MailingAddressInput shippingAddress {
            get {
                return (MailingAddressInput) Get(shippingAddressFieldKey);
            }
            set {
                Set(shippingAddressFieldKey, value);
            }
        }

        /// <summary>
        /// The text of an optional note that a shop owner can attach to the checkout.
        /// </summary>
        public string note {
            get {
                return (string) Get(noteFieldKey);
            }
            set {
                Set(noteFieldKey, value);
            }
        }

        /// <summary>
        /// A list of extra information that is added to the checkout.
        /// </summary>
        public List<AttributeInput> customAttributes {
            get {
                return (List<AttributeInput>) Get(customAttributesFieldKey);
            }
            set {
                Set(customAttributesFieldKey, value);
            }
        }

        /// <summary>
        /// Allows setting partial addresses on a Checkout, skipping the full validation of attributes.
        /// The required attributes are city, province, and country.
        /// Full validation of addresses is still done at complete time.
        /// </summary>
        public bool? allowPartialAddresses {
            get {
                return (bool) Get(allowPartialAddressesFieldKey);
            }
            set {
                Set(allowPartialAddressesFieldKey, value);
            }
        }

        /// <summary>
        /// The three-letter currency code of one of the shop's enabled presentment currencies.
        /// Including this field creates a checkout in the specified currency. By default, new
        /// checkouts are created in the shop's primary currency.
        /// </summary>
        public CurrencyCode? presentmentCurrencyCode {
            get {
                return (CurrencyCode?) Get(presentmentCurrencyCodeFieldKey);
            }
            set {
                Set(presentmentCurrencyCodeFieldKey, value);
            }
        }

        /// <param name="email">
        /// The email with which the customer wants to checkout.
        /// </param>
        /// <param name="lineItems">
        /// A list of line item objects, each one containing information about an item in the checkout.
        /// </param>
        /// <param name="shippingAddress">
        /// The shipping address to where the line items will be shipped.
        /// </param>
        /// <param name="note">
        /// The text of an optional note that a shop owner can attach to the checkout.
        /// </param>
        /// <param name="customAttributes">
        /// A list of extra information that is added to the checkout.
        /// </param>
        /// <param name="allowPartialAddresses">
        /// Allows setting partial addresses on a Checkout, skipping the full validation of attributes.
        /// The required attributes are city, province, and country.
        /// Full validation of addresses is still done at complete time.
        /// </param>
        /// <param name="presentmentCurrencyCode">
        /// The three-letter currency code of one of the shop's enabled presentment currencies.
        /// Including this field creates a checkout in the specified currency. By default, new
        /// checkouts are created in the shop's primary currency.
        /// </param>
        public CheckoutCreateInput(string email = null,List<CheckoutLineItemInput> lineItems = null,MailingAddressInput shippingAddress = null,string note = null,List<AttributeInput> customAttributes = null,bool? allowPartialAddresses = null,CurrencyCode? presentmentCurrencyCode = null) {
            if (email != null) {
                Set(emailFieldKey, email);
            }

            if (lineItems != null) {
                Set(lineItemsFieldKey, lineItems);
            }

            if (shippingAddress != null) {
                Set(shippingAddressFieldKey, shippingAddress);
            }

            if (note != null) {
                Set(noteFieldKey, note);
            }

            if (customAttributes != null) {
                Set(customAttributesFieldKey, customAttributes);
            }

            if (allowPartialAddresses != null) {
                Set(allowPartialAddressesFieldKey, allowPartialAddresses);
            }

            if (presentmentCurrencyCode != null) {
                Set(presentmentCurrencyCodeFieldKey, presentmentCurrencyCode);
            }
        }

        /// <param name="email">
        /// The email with which the customer wants to checkout.
        /// </param>
        /// <param name="lineItems">
        /// A list of line item objects, each one containing information about an item in the checkout.
        /// </param>
        /// <param name="shippingAddress">
        /// The shipping address to where the line items will be shipped.
        /// </param>
        /// <param name="note">
        /// The text of an optional note that a shop owner can attach to the checkout.
        /// </param>
        /// <param name="customAttributes">
        /// A list of extra information that is added to the checkout.
        /// </param>
        /// <param name="allowPartialAddresses">
        /// Allows setting partial addresses on a Checkout, skipping the full validation of attributes.
        /// The required attributes are city, province, and country.
        /// Full validation of addresses is still done at complete time.
        /// </param>
        /// <param name="presentmentCurrencyCode">
        /// The three-letter currency code of one of the shop's enabled presentment currencies.
        /// Including this field creates a checkout in the specified currency. By default, new
        /// checkouts are created in the shop's primary currency.
        /// </param>
        public CheckoutCreateInput(Dictionary<string, object> dataJSON) {
            if (dataJSON.ContainsKey(emailFieldKey)) {
                Set(emailFieldKey, dataJSON[emailFieldKey]);
            }

            if (dataJSON.ContainsKey(lineItemsFieldKey)) {
                Set(lineItemsFieldKey, dataJSON[lineItemsFieldKey]);
            }

            if (dataJSON.ContainsKey(shippingAddressFieldKey)) {
                Set(shippingAddressFieldKey, dataJSON[shippingAddressFieldKey]);
            }

            if (dataJSON.ContainsKey(noteFieldKey)) {
                Set(noteFieldKey, dataJSON[noteFieldKey]);
            }

            if (dataJSON.ContainsKey(customAttributesFieldKey)) {
                Set(customAttributesFieldKey, dataJSON[customAttributesFieldKey]);
            }

            if (dataJSON.ContainsKey(allowPartialAddressesFieldKey)) {
                Set(allowPartialAddressesFieldKey, dataJSON[allowPartialAddressesFieldKey]);
            }

            if (dataJSON.ContainsKey(presentmentCurrencyCodeFieldKey)) {
                Set(presentmentCurrencyCodeFieldKey, dataJSON[presentmentCurrencyCodeFieldKey]);
            }
        }
    }
    }
