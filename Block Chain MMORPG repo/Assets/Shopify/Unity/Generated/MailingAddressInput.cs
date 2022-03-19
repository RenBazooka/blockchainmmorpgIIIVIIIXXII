namespace Shopify.Unity {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    /// <summary>
    /// Specifies the fields accepted to create or update a mailing address.
    /// </summary>
    public class MailingAddressInput : InputBase {
        public const string address1FieldKey = "address1";

        public const string address2FieldKey = "address2";

        public const string cityFieldKey = "city";

        public const string companyFieldKey = "company";

        public const string countryFieldKey = "country";

        public const string firstNameFieldKey = "firstName";

        public const string lastNameFieldKey = "lastName";

        public const string phoneFieldKey = "phone";

        public const string provinceFieldKey = "province";

        public const string zipFieldKey = "zip";

        /// <summary>
        /// The first line of the address. Typically the street address or PO Box number.
        /// </summary>
        public string address1 {
            get {
                return (string) Get(address1FieldKey);
            }
            set {
                Set(address1FieldKey, value);
            }
        }

        /// <summary>
        /// The second line of the address. Typically the number of the apartment, suite, or unit.
        /// </summary>
        public string address2 {
            get {
                return (string) Get(address2FieldKey);
            }
            set {
                Set(address2FieldKey, value);
            }
        }

        /// <summary>
        /// The name of the city, district, village, or town.
        /// </summary>
        public string city {
            get {
                return (string) Get(cityFieldKey);
            }
            set {
                Set(cityFieldKey, value);
            }
        }

        /// <summary>
        /// The name of the customer's company or organization.
        /// </summary>
        public string company {
            get {
                return (string) Get(companyFieldKey);
            }
            set {
                Set(companyFieldKey, value);
            }
        }

        /// <summary>
        /// The name of the country.
        /// </summary>
        public string country {
            get {
                return (string) Get(countryFieldKey);
            }
            set {
                Set(countryFieldKey, value);
            }
        }

        /// <summary>
        /// The first name of the customer.
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
        /// The last name of the customer.
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
        /// A unique phone number for the customer.
        /// 
        /// Formatted using E.164 standard. For example, _+16135551111_.
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
        /// The region of the address, such as the province, state, or district.
        /// </summary>
        public string province {
            get {
                return (string) Get(provinceFieldKey);
            }
            set {
                Set(provinceFieldKey, value);
            }
        }

        /// <summary>
        /// The zip or postal code of the address.
        /// </summary>
        public string zip {
            get {
                return (string) Get(zipFieldKey);
            }
            set {
                Set(zipFieldKey, value);
            }
        }

        /// <param name="address1">
        /// The first line of the address. Typically the street address or PO Box number.
        /// </param>
        /// <param name="address2">
        /// The second line of the address. Typically the number of the apartment, suite, or unit.
        /// </param>
        /// <param name="city">
        /// The name of the city, district, village, or town.
        /// </param>
        /// <param name="company">
        /// The name of the customer's company or organization.
        /// </param>
        /// <param name="country">
        /// The name of the country.
        /// </param>
        /// <param name="firstName">
        /// The first name of the customer.
        /// </param>
        /// <param name="lastName">
        /// The last name of the customer.
        /// </param>
        /// <param name="phone">
        /// A unique phone number for the customer.
        /// 
        /// Formatted using E.164 standard. For example, _+16135551111_.
        /// </param>
        /// <param name="province">
        /// The region of the address, such as the province, state, or district.
        /// </param>
        /// <param name="zip">
        /// The zip or postal code of the address.
        /// </param>
        public MailingAddressInput(string address1 = null,string address2 = null,string city = null,string company = null,string country = null,string firstName = null,string lastName = null,string phone = null,string province = null,string zip = null) {
            if (address1 != null) {
                Set(address1FieldKey, address1);
            }

            if (address2 != null) {
                Set(address2FieldKey, address2);
            }

            if (city != null) {
                Set(cityFieldKey, city);
            }

            if (company != null) {
                Set(companyFieldKey, company);
            }

            if (country != null) {
                Set(countryFieldKey, country);
            }

            if (firstName != null) {
                Set(firstNameFieldKey, firstName);
            }

            if (lastName != null) {
                Set(lastNameFieldKey, lastName);
            }

            if (phone != null) {
                Set(phoneFieldKey, phone);
            }

            if (province != null) {
                Set(provinceFieldKey, province);
            }

            if (zip != null) {
                Set(zipFieldKey, zip);
            }
        }

        /// <param name="address1">
        /// The first line of the address. Typically the street address or PO Box number.
        /// </param>
        /// <param name="address2">
        /// The second line of the address. Typically the number of the apartment, suite, or unit.
        /// </param>
        /// <param name="city">
        /// The name of the city, district, village, or town.
        /// </param>
        /// <param name="company">
        /// The name of the customer's company or organization.
        /// </param>
        /// <param name="country">
        /// The name of the country.
        /// </param>
        /// <param name="firstName">
        /// The first name of the customer.
        /// </param>
        /// <param name="lastName">
        /// The last name of the customer.
        /// </param>
        /// <param name="phone">
        /// A unique phone number for the customer.
        /// 
        /// Formatted using E.164 standard. For example, _+16135551111_.
        /// </param>
        /// <param name="province">
        /// The region of the address, such as the province, state, or district.
        /// </param>
        /// <param name="zip">
        /// The zip or postal code of the address.
        /// </param>
        public MailingAddressInput(Dictionary<string, object> dataJSON) {
            if (dataJSON.ContainsKey(address1FieldKey)) {
                Set(address1FieldKey, dataJSON[address1FieldKey]);
            }

            if (dataJSON.ContainsKey(address2FieldKey)) {
                Set(address2FieldKey, dataJSON[address2FieldKey]);
            }

            if (dataJSON.ContainsKey(cityFieldKey)) {
                Set(cityFieldKey, dataJSON[cityFieldKey]);
            }

            if (dataJSON.ContainsKey(companyFieldKey)) {
                Set(companyFieldKey, dataJSON[companyFieldKey]);
            }

            if (dataJSON.ContainsKey(countryFieldKey)) {
                Set(countryFieldKey, dataJSON[countryFieldKey]);
            }

            if (dataJSON.ContainsKey(firstNameFieldKey)) {
                Set(firstNameFieldKey, dataJSON[firstNameFieldKey]);
            }

            if (dataJSON.ContainsKey(lastNameFieldKey)) {
                Set(lastNameFieldKey, dataJSON[lastNameFieldKey]);
            }

            if (dataJSON.ContainsKey(phoneFieldKey)) {
                Set(phoneFieldKey, dataJSON[phoneFieldKey]);
            }

            if (dataJSON.ContainsKey(provinceFieldKey)) {
                Set(provinceFieldKey, dataJSON[provinceFieldKey]);
            }

            if (dataJSON.ContainsKey(zipFieldKey)) {
                Set(zipFieldKey, dataJSON[zipFieldKey]);
            }
        }
    }
    }
