namespace Shopify.Unity {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    /// <summary>
    /// Specifies the fields required to reset a customer’s password.
    /// </summary>
    public class CustomerResetInput : InputBase {
        public const string resetTokenFieldKey = "resetToken";

        public const string passwordFieldKey = "password";

        /// <summary>
        /// The reset token required to reset the customer’s password.
        /// </summary>
        public string resetToken {
            get {
                return (string) Get(resetTokenFieldKey);
            }
            set {
                Set(resetTokenFieldKey, value);
            }
        }

        /// <summary>
        /// New password that will be set as part of the reset password process.
        /// </summary>
        public string password {
            get {
                return (string) Get(passwordFieldKey);
            }
            set {
                Set(passwordFieldKey, value);
            }
        }

        /// <param name="resetToken">
        /// The reset token required to reset the customer’s password.
        /// </param>
        /// <param name="password">
        /// New password that will be set as part of the reset password process.
        /// </param>
        public CustomerResetInput(string resetToken,string password) {
            Set(resetTokenFieldKey, resetToken);

            Set(passwordFieldKey, password);
        }

        /// <param name="resetToken">
        /// The reset token required to reset the customer’s password.
        /// </param>
        /// <param name="password">
        /// New password that will be set as part of the reset password process.
        /// </param>
        public CustomerResetInput(Dictionary<string, object> dataJSON) {
            try {
                Set(resetTokenFieldKey, dataJSON[resetTokenFieldKey]);

                Set(passwordFieldKey, dataJSON[passwordFieldKey]);
            } catch {
                throw;
            }
        }
    }
    }
