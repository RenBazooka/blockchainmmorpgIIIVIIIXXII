namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void MailingAddressDelegate(MailingAddressQuery query);

    /// <summary>
    /// Represents a mailing address for customers and shipping.
    /// </summary>
    public class MailingAddressQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="MailingAddressQuery" /> is used to build queries. Typically
        /// <see cref="MailingAddressQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public MailingAddressQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// The first line of the address. Typically the street address or PO Box number.
        /// </summary>
        public MailingAddressQuery address1() {
            Query.Append("address1 ");

            return this;
        }

        /// <summary>
        /// The second line of the address. Typically the number of the apartment, suite, or unit.
        /// </summary>
        public MailingAddressQuery address2() {
            Query.Append("address2 ");

            return this;
        }

        /// <summary>
        /// The name of the city, district, village, or town.
        /// </summary>
        public MailingAddressQuery city() {
            Query.Append("city ");

            return this;
        }

        /// <summary>
        /// The name of the customer's company or organization.
        /// </summary>
        public MailingAddressQuery company() {
            Query.Append("company ");

            return this;
        }

        /// <summary>
        /// The name of the country.
        /// </summary>
        public MailingAddressQuery country() {
            Query.Append("country ");

            return this;
        }

        /// \deprecated Use `countryCodeV2` instead
        /// <summary>
        /// The two-letter code for the country of the address.
        /// 
        /// For example, US.
        /// </summary>
        public MailingAddressQuery countryCode() {
            Log.DeprecatedQueryField("MailingAddress", "countryCode", "Use `countryCodeV2` instead");

            Query.Append("countryCode ");

            return this;
        }

        /// <summary>
        /// The two-letter code for the country of the address.
        /// 
        /// For example, US.
        /// </summary>
        public MailingAddressQuery countryCodeV2() {
            Query.Append("countryCodeV2 ");

            return this;
        }

        /// <summary>
        /// The first name of the customer.
        /// </summary>
        public MailingAddressQuery firstName() {
            Query.Append("firstName ");

            return this;
        }

        /// <summary>
        /// A formatted version of the address, customized by the provided arguments.
        /// </summary>
        /// <param name="withName">
        /// Whether to include the customer's name in the formatted address.
        /// </param>
        /// <param name="withCompany">
        /// Whether to include the customer's company in the formatted address.
        /// </param>
        public MailingAddressQuery formatted(bool? withName = null,bool? withCompany = null,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("formatted___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("formatted ");

            Arguments args = new Arguments();

            if (withName != null) {
                args.Add("withName", withName);
            }

            if (withCompany != null) {
                args.Add("withCompany", withCompany);
            }

            Query.Append(args.ToString());

            return this;
        }

        /// <summary>
        /// A comma-separated list of the values for city, province, and country.
        /// </summary>
        public MailingAddressQuery formattedArea() {
            Query.Append("formattedArea ");

            return this;
        }

        /// <summary>
        /// Globally unique identifier.
        /// </summary>
        public MailingAddressQuery id() {
            Query.Append("id ");

            return this;
        }

        /// <summary>
        /// The last name of the customer.
        /// </summary>
        public MailingAddressQuery lastName() {
            Query.Append("lastName ");

            return this;
        }

        /// <summary>
        /// The latitude coordinate of the customer address.
        /// </summary>
        public MailingAddressQuery latitude() {
            Query.Append("latitude ");

            return this;
        }

        /// <summary>
        /// The longitude coordinate of the customer address.
        /// </summary>
        public MailingAddressQuery longitude() {
            Query.Append("longitude ");

            return this;
        }

        /// <summary>
        /// The full name of the customer, based on firstName and lastName.
        /// </summary>
        public MailingAddressQuery name() {
            Query.Append("name ");

            return this;
        }

        /// <summary>
        /// A unique phone number for the customer.
        /// 
        /// Formatted using E.164 standard. For example, _+16135551111_.
        /// </summary>
        public MailingAddressQuery phone() {
            Query.Append("phone ");

            return this;
        }

        /// <summary>
        /// The region of the address, such as the province, state, or district.
        /// </summary>
        public MailingAddressQuery province() {
            Query.Append("province ");

            return this;
        }

        /// <summary>
        /// The two-letter code for the region.
        /// 
        /// For example, ON.
        /// </summary>
        public MailingAddressQuery provinceCode() {
            Query.Append("provinceCode ");

            return this;
        }

        /// <summary>
        /// The zip or postal code of the address.
        /// </summary>
        public MailingAddressQuery zip() {
            Query.Append("zip ");

            return this;
        }
    }
    }
