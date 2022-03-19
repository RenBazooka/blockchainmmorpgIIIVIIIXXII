namespace Shopify.Unity {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    /// <summary>
    /// Specifies the input fields required for an attribute.
    /// </summary>
    public class AttributeInput : InputBase {
        public const string keyFieldKey = "key";

        public const string valueFieldKey = "value";

        /// <summary>
        /// Key or name of the attribute.
        /// </summary>
        public string key {
            get {
                return (string) Get(keyFieldKey);
            }
            set {
                Set(keyFieldKey, value);
            }
        }

        /// <summary>
        /// Value of the attribute.
        /// </summary>
        public string value {
            get {
                return (string) Get(valueFieldKey);
            }
            set {
                Set(valueFieldKey, value);
            }
        }

        /// <param name="key">
        /// Key or name of the attribute.
        /// </param>
        /// <param name="value">
        /// Value of the attribute.
        /// </param>
        public AttributeInput(string key,string value) {
            Set(keyFieldKey, key);

            Set(valueFieldKey, value);
        }

        /// <param name="key">
        /// Key or name of the attribute.
        /// </param>
        /// <param name="value">
        /// Value of the attribute.
        /// </param>
        public AttributeInput(Dictionary<string, object> dataJSON) {
            try {
                Set(keyFieldKey, dataJSON[keyFieldKey]);

                Set(valueFieldKey, dataJSON[valueFieldKey]);
            } catch {
                throw;
            }
        }
    }
    }
