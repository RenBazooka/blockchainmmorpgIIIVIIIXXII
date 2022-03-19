namespace Shopify.Unity {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    /// <summary>
    /// Specifies the input fields required to activate a customer.
    /// </summary>
    public class CustomerActivateInput : InputBase {
        public const string activationTokenFieldKey = "activationToken";

        public const string passwordFieldKey = "password";

        /// <summary>
        /// The activation token required to activate the customer.
        /// </summary>
        public string activationToken {
            get {
                return (string) Get(activationTokenFieldKey);
            }
            set {
                Set(activationTokenFieldKey, value);
            }
        }

        /// <summary>
        /// New password that will be set during activation.
        /// </summary>
        public string password {
            get {
                return (string) Get(passwordFieldKey);
            }
            set {
                Set(passwordFieldKey, value);
            }
        }

        /// <param name="activationToken">
        /// The activation token required to activate the customer.
        /// </param>
        /// <param name="password">
        /// New password that will be set during activation.
        /// </param>
        public CustomerActivateInput(string activationToken,string password) {
            Set(activationTokenFieldKey, activationToken);

            Set(passwordFieldKey, password);
        }

        /// <param name="activationToken">
        /// The activation token required to activate the customer.
        /// </param>
        /// <param name="password">
        /// New password that will be set during activation.
        /// </param>
        public CustomerActivateInput(Dictionary<string, object> dataJSON) {
            try {
                Set(activationTokenFieldKey, dataJSON[activationTokenFieldKey]);

                Set(passwordFieldKey, dataJSON[passwordFieldKey]);
            } catch {
                throw;
            }
        }
    }
    }
