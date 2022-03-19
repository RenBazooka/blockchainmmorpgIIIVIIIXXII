namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void CreditCardDelegate(CreditCardQuery query);

    /// <summary>
    /// Credit card information used for a payment.
    /// </summary>
    public class CreditCardQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="CreditCardQuery" /> is used to build queries. Typically
        /// <see cref="CreditCardQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public CreditCardQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// The brand of the credit card.
        /// </summary>
        public CreditCardQuery brand() {
            Query.Append("brand ");

            return this;
        }

        /// <summary>
        /// The expiry month of the credit card.
        /// </summary>
        public CreditCardQuery expiryMonth() {
            Query.Append("expiryMonth ");

            return this;
        }

        /// <summary>
        /// The expiry year of the credit card.
        /// </summary>
        public CreditCardQuery expiryYear() {
            Query.Append("expiryYear ");

            return this;
        }

        /// <summary>
        /// The credit card's BIN number.
        /// </summary>
        public CreditCardQuery firstDigits() {
            Query.Append("firstDigits ");

            return this;
        }

        /// <summary>
        /// The first name of the card holder.
        /// </summary>
        public CreditCardQuery firstName() {
            Query.Append("firstName ");

            return this;
        }

        /// <summary>
        /// The last 4 digits of the credit card.
        /// </summary>
        public CreditCardQuery lastDigits() {
            Query.Append("lastDigits ");

            return this;
        }

        /// <summary>
        /// The last name of the card holder.
        /// </summary>
        public CreditCardQuery lastName() {
            Query.Append("lastName ");

            return this;
        }

        /// <summary>
        /// The masked credit card number with only the last 4 digits displayed.
        /// </summary>
        public CreditCardQuery maskedNumber() {
            Query.Append("maskedNumber ");

            return this;
        }
    }
    }
