namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// A resource that the metafield belongs to.
    /// </summary>
    public interface MetafieldParentResource {}

    /// <summary>
    /// A resource that the metafield belongs to.
    /// </summary>
    public class UnknownMetafieldParentResource : AbstractResponse, ICloneable, MetafieldParentResource {
        /// <summary>
        /// Instantiate objects implementing <see cref="MetafieldParentResource" />. Possible types are:
        /// <list type="bullet">
        /// <item><description><see cref="Product" /></description></item>
        /// <item><description><see cref="ProductVariant" /></description></item>
        /// </list>
        /// </summary>
        public static MetafieldParentResource Create(Dictionary<string, object> dataJSON) {
            string typeName = (string) dataJSON["__typename"];

            switch(typeName) {
                case "Product":
                return new Product(dataJSON) as MetafieldParentResource;

                case "ProductVariant":
                return new ProductVariant(dataJSON) as MetafieldParentResource;

                default:
                return new UnknownMetafieldParentResource();
            }
        }

        public object Clone() {
            return new UnknownMetafieldParentResource();
        }
    }
    }
