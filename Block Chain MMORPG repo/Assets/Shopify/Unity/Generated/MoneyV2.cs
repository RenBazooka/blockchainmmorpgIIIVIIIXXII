namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

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
    public class MoneyV2 : AbstractResponse, ICloneable {
        /// <summary>
        /// <see ref="MoneyV2" /> Accepts deserialized json data.
        /// <see ref="MoneyV2" /> Will further parse passed in data.
        /// </summary>
        /// <param name="dataJSON">Deserialized JSON data for MoneyV2</param>
        public MoneyV2(Dictionary<string, object> dataJSON) {
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
                    case "amount":

                    Data.Add(
                        key,

                        Convert.ToDecimal(dataJSON[key])
                    );

                    break;

                    case "currencyCode":

                    Data.Add(
                        key,

                        CastUtils.GetEnumValue<CurrencyCode>(dataJSON[key])
                    );

                    break;
                }
            }
        }

        /// <summary>
        /// Decimal money amount.
        /// </summary>
        public decimal amount() {
            return Get<decimal>("amount");
        }

        /// <summary>
        /// Currency of the money.
        /// </summary>
        public CurrencyCode currencyCode() {
            return Get<CurrencyCode>("currencyCode");
        }

        public object Clone() {
            return new MoneyV2(DataJSON);
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
