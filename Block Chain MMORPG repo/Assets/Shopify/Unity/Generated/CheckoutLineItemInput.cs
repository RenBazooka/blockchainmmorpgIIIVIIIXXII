namespace Shopify.Unity {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    /// <summary>
    /// Specifies the input fields to create a line item on a checkout.
    /// </summary>
    public class CheckoutLineItemInput : InputBase {
        public const string customAttributesFieldKey = "customAttributes";

        public const string quantityFieldKey = "quantity";

        public const string variantIdFieldKey = "variantId";

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

        /// <summary>
        /// The quantity of the line item.
        /// </summary>
        public long quantity {
            get {
                return (long) Get(quantityFieldKey);
            }
            set {
                Set(quantityFieldKey, value);
            }
        }

        /// <summary>
        /// The identifier of the product variant for the line item.
        /// </summary>
        public string variantId {
            get {
                return (string) Get(variantIdFieldKey);
            }
            set {
                Set(variantIdFieldKey, value);
            }
        }

        /// <param name="customAttributes">
        /// Extra information in the form of an array of Key-Value pairs about the line item.
        /// </param>
        /// <param name="quantity">
        /// The quantity of the line item.
        /// </param>
        /// <param name="variantId">
        /// The identifier of the product variant for the line item.
        /// </param>
        public CheckoutLineItemInput(long quantity,string variantId,List<AttributeInput> customAttributes = null) {
            Set(quantityFieldKey, quantity);

            Set(variantIdFieldKey, variantId);

            if (customAttributes != null) {
                Set(customAttributesFieldKey, customAttributes);
            }
        }

        /// <param name="customAttributes">
        /// Extra information in the form of an array of Key-Value pairs about the line item.
        /// </param>
        /// <param name="quantity">
        /// The quantity of the line item.
        /// </param>
        /// <param name="variantId">
        /// The identifier of the product variant for the line item.
        /// </param>
        public CheckoutLineItemInput(Dictionary<string, object> dataJSON) {
            try {
                Set(quantityFieldKey, dataJSON[quantityFieldKey]);

                Set(variantIdFieldKey, dataJSON[variantIdFieldKey]);
            } catch {
                throw;
            }

            if (dataJSON.ContainsKey(customAttributesFieldKey)) {
                Set(customAttributesFieldKey, dataJSON[customAttributesFieldKey]);
            }
        }
    }
    }
