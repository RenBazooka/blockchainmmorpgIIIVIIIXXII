namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void MoneyV2Delegate(MoneyV2Query query);

    /// <summary>
    /// A monetary value with currency.
    /// 
    /// To format currencies, combine this type's amount and currencyCode fields with your client's locale.
    /// 
    /// For example, in JavaScript you could use Intl.NumberFormat:
    /// 
    /// ```js
    /// new Intl.NumberFormat(locale, {
    /// style: 'currency',
    /// currency: currencyCode
    /// }).format(amount);
    /// ```
    /// 
    /// Other formatting libraries include:
    /// 
    /// * iOS - [NumberFormatter](https://developer.apple.com/documentation/foundation/numberformatter)
    /// * Android - [NumberFormat](https://developer.android.com/reference/java/text/NumberFormat.html)
    /// * PHP - [NumberFormatter](http://php.net/manual/en/class.numberformatter.php)
    /// 
    /// For a more general solution, the [Unicode CLDR number formatting database] is available with many implementations
    /// (such as [TwitterCldr](https://github.com/twitter/twitter-cldr-rb)).
    /// </summary>
    public class MoneyV2Query {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="MoneyV2Query" /> is used to build queries. Typically
        /// <see cref="MoneyV2Query" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public MoneyV2Query(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// Decimal money amount.
        /// </summary>
        public MoneyV2Query amount() {
            Query.Append("amount ");

            return this;
        }

        /// <summary>
        /// Currency of the money.
        /// </summary>
        public MoneyV2Query currencyCode() {
            Query.Append("currencyCode ");

            return this;
        }
    }
    }
