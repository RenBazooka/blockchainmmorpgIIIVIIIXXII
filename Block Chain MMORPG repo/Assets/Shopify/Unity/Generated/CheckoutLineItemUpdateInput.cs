namespace Shopify.Unity {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    /// <summary>
    /// Specifies the input fields to update a line item on the checkout.
    /// </summary>
    public class CheckoutLineItemUpdateInput : InputBase {
        public const string idFieldKey = "id";

        public const string variantIdFieldKey = "variantId";

        public const string quantityFieldKey = "quantity";

        public const string customAttributesFieldKey = "customAttributes";

        /// <summary>
        /// The identifier of the line item.
        /// </summary>
        public string id {
            get {
                return (string) Get(idFieldKey);
            }
            set {
                Set(idFieldKey, value);
            }
        }

        /// <summary>
        /// The variant identifier of the line item.
        /// </summary>
        public string variantId {
            get {
                return (string) Get(variantIdFieldKey);
            }
            set {
                Set(variantIdFieldKey, value);
            }
        }

        /// <summary>
        /// The quantity of the line item.
        /// </summary>
        public long? quantity {
            get {
                return (long) Get(quantityFieldKey);
            }
            set {
                Set(quantityFieldKey, value);
            }
        }

        /// <summary>
        /// Extra information in the form of an array of Key-Value pairs about the line item.
        /// </summary>
        public List<AttributeInput> customAttributes {
            get {
                return (List<AttributeInput>) Get(customAttributesFieldKey);
            }
            set {
                Set(customAttributesFieldKey, value);
            }
        }

        /// <param name="id">
        /// The identifier of the line item.
        /// </param>
        /// <param name="variantId">
        /// The variant identifier of the line item.
        /// </param>
        /// <param name="quantity">
        /// The quantity of the line item.
        /// </param>
        /// <param name="customAttributes">
        /// Extra information in the form of an array of Key-Value pairs about the line item.
        /// </param>
        public CheckoutLineItemUpdateInput(string id = null,string variantId = null,long? quantity = null,List<AttributeInput> customAttributes = null) {
            if (id != null) {
                Set(idFieldKey, id);
            }

            if (variantId != null) {
                Set(variantIdFieldKey, variantId);
            }

            if (quantity != null) {
                Set(quantityFieldKey, quantity);
            }

            if (customAttributes != null) {
                Set(customAttributesFieldKey, customAttributes);
            }
        }

        /// <param name="id">
        /// The identifier of the line item.
        /// </param>
        /// <param name="variantId">
        /// The variant identifier of the line item.
        /// </param>
        /// <param name="quantity">
        /// The quantity of the line item.
        /// </param>
        /// <param name="customAttributes">
        /// Extra information in the form of an array of Key-Value pairs about the line item.
        /// </param>
        public CheckoutLineItemUpdateInput(Dictionary<string, object> dataJSON) {
            if (dataJSON.ContainsKey(idFieldKey)) {
                Set(idFieldKey, dataJSON[idFieldKey]);
            }

            if (dataJSON.ContainsKey(variantIdFieldKey)) {
                Set(variantIdFieldKey, dataJSON[variantIdFieldKey]);
            }

            if (dataJSON.ContainsKey(quantityFieldKey)) {
                Set(quantityFieldKey, dataJSON[quantityFieldKey]);
            }

            if (dataJSON.ContainsKey(customAttributesFieldKey)) {
                Set(customAttributesFieldKey, dataJSON[customAttributesFieldKey]);
            }
        }
    }
    }
