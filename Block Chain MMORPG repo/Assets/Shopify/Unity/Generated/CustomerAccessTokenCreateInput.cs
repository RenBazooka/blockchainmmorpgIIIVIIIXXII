namespace Shopify.Unity {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    /// <summary>
    /// Specifies the input fields required to create a customer access token.
    /// </summary>
    public class CustomerAccessTokenCreateInput : InputBase {
        public const string emailFieldKey = "email";

        public const string passwordFieldKey = "password";

        /// <summary>
        /// The email associated to the customer.
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
        /// The login password to be used by the customer.
        /// </summary>
        public string password {
            get {
                return (string) Get(passwordFieldKey);
            }
            set {
                Set(passwordFieldKey, value);
            }
        }

        /// <param name="email">
        /// The email associated to the customer.
        /// </param>
        /// <param name="password">
        /// The login password to be used by the customer.
        /// </param>
        public CustomerAccessTokenCreateInput(string email,string password) {
            Set(emailFieldKey, email);

            Set(passwordFieldKey, password);
        }

        /// <param name="email">
        /// The email associated to the customer.
        /// </param>
        /// <param name="password">
        /// The login password to be used by the customer.
        /// </param>
        public CustomerAccessTokenCreateInput(Dictionary<string, object> dataJSON) {
            try {
                Set(emailFieldKey, dataJSON[emailFieldKey]);

                Set(passwordFieldKey, dataJSON[passwordFieldKey]);
            } catch {
                throw;
            }
        }
    }
    }
