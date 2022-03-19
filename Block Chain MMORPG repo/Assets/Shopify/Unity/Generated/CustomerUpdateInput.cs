namespace Shopify.Unity {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    /// <summary>
    /// Specifies the fields required to update the Customer information.
    /// </summary>
    public class CustomerUpdateInput : InputBase {
        public const string firstNameFieldKey = "firstName";

        public const string lastNameFieldKey = "lastName";

        public const string emailFieldKey = "email";

        public const string phoneFieldKey = "phone";

        public const string passwordFieldKey = "password";

        public const string acceptsMarketingFieldKey = "acceptsMarketing";

        /// <summary>
        /// The customer’s first name.
        /// </summary>
        public string firstName {
            get {
                return (string) Get(firstNameFieldKey);
            }
            set {
                Set(firstNameFieldKey, value);
            }
        }

        /// <summary>
        /// The customer’s last name.
        /// </summary>
        public string lastName {
            get {
                return (string) Get(lastNameFieldKey);
            }
            set {
                Set(lastNameFieldKey, value);
            }
        }

        /// <summary>
        /// The customer’s email.
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
        /// A unique phone number for the customer.
        /// 
        /// Formatted using E.164 standard. For example, _+16135551111_. To remove the phone number, specify `null`.
        /// </summary>
        public string phone {
            get {
                return (string) Get(phoneFieldKey);
            }
            set {
                Set(phoneFieldKey, value);
            }
        }

        /// <summary>
        /// The login password used by the customer.
        /// </summary>
        public string password {
            get {
                return (string) Get(passwordFieldKey);
            }
            set {
                Set(passwordFieldKey, value);
            }
        }

        /// <summary>
        /// Indicates whether the customer has consented to be sent marketing material via email.
        /// </summary>
        public bool? acceptsMarketing {
            get {
                return (bool) Get(acceptsMarketingFieldKey);
            }
            set {
                Set(acceptsMarketingFieldKey, value);
            }
        }

        /// <param name="firstName">
        /// The customer’s first name.
        /// </param>
        /// <param name="lastName">
        /// The customer’s last name.
        /// </param>
        /// <param name="email">
        /// The customer’s email.
        /// </param>
        /// <param name="phone">
        /// A unique phone number for the customer.
        /// 
        /// Formatted using E.164 standard. For example, _+16135551111_. To remove the phone number, specify `null`.
        /// </param>
        /// <param name="password">
        /// The login password used by the customer.
        /// </param>
        /// <param name="acceptsMarketing">
        /// Indicates whether the customer has consented to be sent marketing material via email.
        /// </param>
        public CustomerUpdateInput(string firstName = null,string lastName = null,string email = null,string phone = null,string password = null,bool? acceptsMarketing = null) {
            if (firstName != null) {
                Set(firstNameFieldKey, firstName);
            }

            if (lastName != null) {
                Set(lastNameFieldKey, lastName);
            }

            if (email != null) {
                Set(emailFieldKey, email);
            }

            if (phone != null) {
                Set(phoneFieldKey, phone);
            }

            if (password != null) {
                Set(passwordFieldKey, password);
            }

            if (acceptsMarketing != null) {
                Set(acceptsMarketingFieldKey, acceptsMarketing);
            }
        }

        /// <param name="firstName">
        /// The customer’s first name.
        /// </param>
        /// <param name="lastName">
        /// The customer’s last name.
        /// </param>
        /// <param name="email">
        /// The customer’s email.
        /// </param>
        /// <param name="phone">
        /// A unique phone number for the customer.
        /// 
        /// Formatted using E.164 standard. For example, _+16135551111_. To remove the phone number, specify `null`.
        /// </param>
        /// <param name="password">
        /// The login password used by the customer.
        /// </param>
        /// <param name="acceptsMarketing">
        /// Indicates whether the customer has consented to be sent marketing material via email.
        /// </param>
        public CustomerUpdateInput(Dictionary<string, object> dataJSON) {
            if (dataJSON.ContainsKey(firstNameFieldKey)) {
                Set(firstNameFieldKey, dataJSON[firstNameFieldKey]);
            }

            if (dataJSON.ContainsKey(lastNameFieldKey)) {
                Set(lastNameFieldKey, dataJSON[lastNameFieldKey]);
            }

            if (dataJSON.ContainsKey(emailFieldKey)) {
                Set(emailFieldKey, dataJSON[emailFieldKey]);
            }

            if (dataJSON.ContainsKey(phoneFieldKey)) {
                Set(phoneFieldKey, dataJSON[phoneFieldKey]);
            }

            if (dataJSON.ContainsKey(passwordFieldKey)) {
                Set(passwordFieldKey, dataJSON[passwordFieldKey]);
            }

            if (dataJSON.ContainsKey(acceptsMarketingFieldKey)) {
                Set(acceptsMarketingFieldKey, dataJSON[acceptsMarketingFieldKey]);
            }
        }
    }
    }
