namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// The price value (fixed or percentage) for a discount application.
    /// </summary>
    public interface PricingValue {}

    /// <summary>
    /// The price value (fixed or percentage) for a discount application.
    /// </summary>
    public class UnknownPricingValue : AbstractResponse, ICloneable, PricingValue {
        /// <summary>
        /// Instantiate objects implementing <see cref="PricingValue" />. Possible types are:
        /// <list type="bullet">
        /// <item><description><see cref="MoneyV2" /></description></item>
        /// <item><description><see cref="PricingPercentageValue" /></description></item>
        /// </list>
        /// </summary>
        public static PricingValue Create(Dictionary<string, object> dataJSON) {
            string typeName = (string) dataJSON["__typename"];

            switch(typeName) {
                case "MoneyV2":
                return new MoneyV2(dataJSON) as PricingValue;

                case "PricingPercentageValue":
                return new PricingPercentageValue(dataJSON) as PricingValue;

                default:
                return new UnknownPricingValue();
            }
        }

        public object Clone() {
            return new UnknownPricingValue();
        }
    }
    }
