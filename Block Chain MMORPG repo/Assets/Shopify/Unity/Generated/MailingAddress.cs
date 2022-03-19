namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// Represents a mailing address for customers and shipping.
    /// </summary>
    public class MailingAddress : AbstractResponse, ICloneable, Node {
        /// <summary>
        /// <see ref="MailingAddress" /> Accepts deserialized json data.
        /// <see ref="MailingAddress" /> Will further parse passed in data.
        /// </summary>
        /// <param name="dataJSON">Deserialized JSON data for MailingAddress</param>
        public MailingAddress(Dictionary<string, object> dataJSON) {
            DataJSON = dataJSON;
            Data = new Dictionary<string,object>();

            foreach (string key in dataJSON.Keys) {
                string fieldName = key;
                Regex regexAlias = new Regex("^(.+)___.+$");
                Match match = regexAlias.Match(key);

                if (match.Success) {
                    fieldName = match.Groups[1].Value;
                }

                switch(fieldName) {
                    case "address1":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            (string) dataJSON[key]
                        );
                    }

                    break;

                    case "address2":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            (string) dataJSON[key]
                        );
                    }

                    break;

                    case "city":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            (string) dataJSON[key]
                        );
                    }

                    break;

                    case "company":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            (string) dataJSON[key]
                        );
                    }

                    break;

                    case "country":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            (string) dataJSON[key]
                        );
                    }

                    break;

                    case "countryCode":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            (string) dataJSON[key]
                        );
                    }

                    break;

                    case "countryCodeV2":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            CastUtils.GetEnumValue<CountryCode>(dataJSON[key])
                        );
                    }

                    break;

                    case "firstName":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            (string) dataJSON[key]
                        );
                    }

                    break;

                    case "formatted":

                    Data.Add(
                        key,

                        CastUtils.CastList<List<string>>((IList) dataJSON[key])
                    );

                    break;

                    case "formattedArea":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            (string) dataJSON[key]
                        );
                    }

                    break;

                    case "id":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
                    );

                    break;

                    case "lastName":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            (string) dataJSON[key]
                        );
                    }

                    break;

                    case "latitude":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            (double) dataJSON[key]
                        );
                    }

                    break;

                    case "longitude":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            (double) dataJSON[key]
                        );
                    }

                    break;

                    case "name":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            (string) dataJSON[key]
                        );
                    }

                    break;

                    case "phone":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            (string) dataJSON[key]
                        );
                    }

                    break;

                    case "province":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            (string) dataJSON[key]
                        );
                    }

                    break;

                    case "provinceCode":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            (string) dataJSON[key]
                        );
                    }

                    break;

                    case "zip":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            (string) dataJSON[key]
                        );
                    }

                    break;
                }
            }
        }

        /// <summary>
        /// The first line of the address. Typically the street address or PO Box number.
        /// </summary>
        public string address1() {
            return Get<string>("address1");
        }

        /// <summary>
        /// The second line of the address. Typically the number of the apartment, suite, or unit.
        /// </summary>
        public string address2() {
            return Get<string>("address2");
        }

        /// <summary>
        /// The name of the city, district, village, or town.
        /// </summary>
        public string city() {
            return Get<string>("city");
        }

        /// <summary>
        /// The name of the customer's company or organization.
        /// </summary>
        public string company() {
            return Get<string>("company");
        }

        /// <summary>
        /// The name of the country.
        /// </summary>
        public string country() {
            return Get<string>("country");
        }

        /// \deprecated Use `countryCodeV2` instead
        /// <summary>
        /// The two-letter code for the country of the address.
        /// 
        /// For example, US.
        /// </summary>
        public string countryCode() {
            return Get<string>("countryCode");
        }

        /// <summary>
        /// The two-letter code for the country of the address.
        /// 
        /// For example, US.
        /// </summary>
        public CountryCode? countryCodeV2() {
            return Get<CountryCode?>("countryCodeV2");
        }

        /// <summary>
        /// The first name of the customer.
        /// </summary>
        public string firstName() {
            return Get<string>("firstName");
        }

        /// <summary>
        /// A formatted version of the address, customized by the provided arguments.
        /// </summary>
        /// <param name="alias">
        /// If the original field queried was queried using an alias, then pass the matching string.
        /// </param>
        public List<string> formatted(string alias = null) {
            return Get<List<string>>("formatted", alias);
        }

        /// <summary>
        /// A comma-separated list of the values for city, province, and country.
        /// </summary>
        public string formattedArea() {
            return Get<string>("formattedArea");
        }

        /// <summary>
        /// Globally unique identifier.
        /// </summary>
        public string id() {
            return Get<string>("id");
        }

        /// <summary>
        /// The last name of the customer.
        /// </summary>
        public string lastName() {
            return Get<string>("lastName");
        }

        /// <summary>
        /// The latitude coordinate of the customer address.
        /// </summary>
        public double? latitude() {
            return Get<double?>("latitude");
        }

        /// <summary>
        /// The longitude coordinate of the customer address.
        /// </summary>
        public double? longitude() {
            return Get<double?>("longitude");
        }

        /// <summary>
        /// The full name of the customer, based on firstName and lastName.
        /// </summary>
        public string name() {
            return Get<string>("name");
        }

        /// <summary>
        /// A unique phone number for the customer.
        /// 
        /// Formatted using E.164 standard. For example, _+16135551111_.
        /// </summary>
        public string phone() {
            return Get<string>("phone");
        }

        /// <summary>
        /// The region of the address, such as the province, state, or district.
        /// </summary>
        public string province() {
            return Get<string>("province");
        }

        /// <summary>
        /// The two-letter code for the region.
        /// 
        /// For example, ON.
        /// </summary>
        public string provinceCode() {
            return Get<string>("provinceCode");
        }

        /// <summary>
        /// The zip or postal code of the address.
        /// </summary>
        public string zip() {
            return Get<string>("zip");
        }

        public object Clone() {
            return new MailingAddress(DataJSON);
        }

        private static List<Node> DataToNodeList(object data) {
            var objects = (List<object>)data;
            var nodes = new List<Node>();

            foreach (var obj in objects) {
                if (obj == null) continue;
                nodes.Add(UnknownNode.Create((Dictionary<string,object>) obj));
            }

            return nodes;
        }
    }
    }
