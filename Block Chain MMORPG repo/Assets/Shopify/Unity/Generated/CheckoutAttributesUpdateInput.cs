namespace Shopify.Unity {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    /// <summary>
    /// Specifies the fields required to update a checkout's attributes.
    /// </summary>
    public class CheckoutAttributesUpdateInput : InputBase {
        public const string noteFieldKey = "note";

        public const string customAttributesFieldKey = "customAttributes";

        public const string allowPartialAddressesFieldKey = "allowPartialAddresses";

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
        /// Full validation of the addresses is still done at complete time.
        /// </summary>
        public bool? allowPartialAddresses {
            get {
                return (bool) Get(allowPartialAddressesFieldKey);
            }
            set {
                Set(allowPartialAddressesFieldKey, value);
            }
        }

        /// <param name="note">
        /// The text of an optional note that a shop owner can attach to the checkout.
        /// </param>
        /// <param name="customAttributes">
        /// A list of extra information that is added to the checkout.
        /// </param>
        /// <param name="allowPartialAddresses">
        /// Allows setting partial addresses on a Checkout, skipping the full validation of attributes.
        /// The required attributes are city, province, and country.
        /// Full validation of the addresses is still done at complete time.
        /// </param>
        public CheckoutAttributesUpdateInput(string note = null,List<AttributeInput> customAttributes = null,bool? allowPartialAddresses = null) {
            if (note != null) {
                Set(noteFieldKey, note);
            }

            if (customAttributes != null) {
                Set(customAttributesFieldKey, customAttributes);
            }

            if (allowPartialAddresses != null) {
                Set(allowPartialAddressesFieldKey, allowPartialAddresses);
            }
        }

        /// <param name="note">
        /// The text of an optional note that a shop owner can attach to the checkout.
        /// </param>
        /// <param name="customAttributes">
        /// A list of extra information that is added to the checkout.
        /// </param>
        /// <param name="allowPartialAddresses">
        /// Allows setting partial addresses on a Checkout, skipping the full validation of attributes.
        /// The required attributes are city, province, and country.
        /// Full validation of the addresses is still done at complete time.
        /// </param>
        public CheckoutAttributesUpdateInput(Dictionary<string, object> dataJSON) {
            if (dataJSON.ContainsKey(noteFieldKey)) {
                Set(noteFieldKey, dataJSON[noteFieldKey]);
            }

            if (dataJSON.ContainsKey(customAttributesFieldKey)) {
                Set(customAttributesFieldKey, dataJSON[customAttributesFieldKey]);
            }

            if (dataJSON.ContainsKey(allowPartialAddressesFieldKey)) {
                Set(allowPartialAddressesFieldKey, dataJSON[allowPartialAddressesFieldKey]);
            }
        }
    }
    }
