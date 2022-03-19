namespace Shopify.Unity {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    /// <summary>
    /// Specifies the input fields required for a selected option.
    /// </summary>
    public class SelectedOptionInput : InputBase {
        public const string nameFieldKey = "name";

        public const string valueFieldKey = "value";

        /// <summary>
        /// The product option’s name.
        /// </summary>
        public string name {
            get {
                return (string) Get(nameFieldKey);
            }
            set {
                Set(nameFieldKey, value);
            }
        }

        /// <summary>
        /// The product option’s value.
        /// </summary>
        public string value {
            get {
                return (string) Get(valueFieldKey);
            }
            set {
                Set(valueFieldKey, value);
            }
        }

        /// <param name="name">
        /// The product option’s name.
        /// </param>
        /// <param name="value">
        /// The product option’s value.
        /// </param>
        public SelectedOptionInput(string name,string value) {
            Set(nameFieldKey, name);

            Set(valueFieldKey, value);
        }

        /// <param name="name">
        /// The product option’s name.
        /// </param>
        /// <param name="value">
        /// The product option’s value.
        /// </param>
        public SelectedOptionInput(Dictionary<string, object> dataJSON) {
            try {
                Set(nameFieldKey, dataJSON[nameFieldKey]);

                Set(valueFieldKey, dataJSON[valueFieldKey]);
            } catch {
                throw;
            }
        }
    }
    }
