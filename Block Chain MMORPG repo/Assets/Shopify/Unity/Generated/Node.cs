namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// An object with an ID to support global identification.
    /// </summary>
    public interface Node {
        /// <summary>
        /// Globally unique identifier.
        /// </summary>
        string id();
    }

    /// <summary>
    /// UnknownNode is a response object.
    /// With <see cref="UnknownNode.Create" /> you'll be able instantiate objects implementing Node.
    /// <c>UnknownNode.Create</c> will return one of the following types:
    /// <list type="bullet">
    /// <item><description><see cref="AppliedGiftCard" /></description></item>
    /// <item><description><see cref="Article" /></description></item>
    /// <item><description><see cref="Blog" /></description></item>
    /// <item><description><see cref="Checkout" /></description></item>
    /// <item><description><see cref="CheckoutLineItem" /></description></item>
    /// <item><description><see cref="Collection" /></description></item>
    /// <item><description><see cref="Comment" /></description></item>
    /// <item><description><see cref="ExternalVideo" /></description></item>
    /// <item><description><see cref="MailingAddress" /></description></item>
    /// <item><description><see cref="MediaImage" /></description></item>
    /// <item><description><see cref="Metafield" /></description></item>
    /// <item><description><see cref="Model3d" /></description></item>
    /// <item><description><see cref="Order" /></description></item>
    /// <item><description><see cref="Page" /></description></item>
    /// <item><description><see cref="Payment" /></description></item>
    /// <item><description><see cref="Product" /></description></item>
    /// <item><description><see cref="ProductOption" /></description></item>
    /// <item><description><see cref="ProductVariant" /></description></item>
    /// <item><description><see cref="ShopPolicy" /></description></item>
    /// <item><description><see cref="Video" /></description></item>
    /// </list>
    /// </summary>
    public class UnknownNode : AbstractResponse, ICloneable, Node {
        /// <summary>
        /// Instantiate objects implementing <see cref="Node" />. Possible types are:
        /// <list type="bullet">
        /// <item><description><see cref="AppliedGiftCard" /></description></item>
        /// <item><description><see cref="Article" /></description></item>
        /// <item><description><see cref="Blog" /></description></item>
        /// <item><description><see cref="Checkout" /></description></item>
        /// <item><description><see cref="CheckoutLineItem" /></description></item>
        /// <item><description><see cref="Collection" /></description></item>
        /// <item><description><see cref="Comment" /></description></item>
        /// <item><description><see cref="ExternalVideo" /></description></item>
        /// <item><description><see cref="MailingAddress" /></description></item>
        /// <item><description><see cref="MediaImage" /></description></item>
        /// <item><description><see cref="Metafield" /></description></item>
        /// <item><description><see cref="Model3d" /></description></item>
        /// <item><description><see cref="Order" /></description></item>
        /// <item><description><see cref="Page" /></description></item>
        /// <item><description><see cref="Payment" /></description></item>
        /// <item><description><see cref="Product" /></description></item>
        /// <item><description><see cref="ProductOption" /></description></item>
        /// <item><description><see cref="ProductVariant" /></description></item>
        /// <item><description><see cref="ShopPolicy" /></description></item>
        /// <item><description><see cref="Video" /></description></item>
        /// </list>
        /// </summary>
        public static Node Create(Dictionary<string, object> dataJSON) {
            string typeName = (string) dataJSON["__typename"];

            switch(typeName) {
                case "AppliedGiftCard":
                return new AppliedGiftCard(dataJSON);

                case "Article":
                return new Article(dataJSON);

                case "Blog":
                return new Blog(dataJSON);

                case "Checkout":
                return new Checkout(dataJSON);

                case "CheckoutLineItem":
                return new CheckoutLineItem(dataJSON);

                case "Collection":
                return new Collection(dataJSON);

                case "Comment":
                return new Comment(dataJSON);

                case "ExternalVideo":
                return new ExternalVideo(dataJSON);

                case "MailingAddress":
                return new MailingAddress(dataJSON);

                case "MediaImage":
                return new MediaImage(dataJSON);

                case "Metafield":
                return new Metafield(dataJSON);

                case "Model3d":
                return new Model3d(dataJSON);

                case "Order":
                return new Order(dataJSON);

                case "Page":
                return new Page(dataJSON);

                case "Payment":
                return new Payment(dataJSON);

                case "Product":
                return new Product(dataJSON);

                case "ProductOption":
                return new ProductOption(dataJSON);

                case "ProductVariant":
                return new ProductVariant(dataJSON);

                case "ShopPolicy":
                return new ShopPolicy(dataJSON);

                case "Video":
                return new Video(dataJSON);

                default:
                return new UnknownNode(dataJSON);
            }
        }

        /// <summary>
        /// <see ref="UnknownNode" /> Accepts deserialized json data.
        /// <see ref="UnknownNode" /> Will further parse passed in data.
        /// </summary>
        /// <param name="dataJSON">Deserialized JSON data for Node</param>
        public UnknownNode(Dictionary<string, object> dataJSON) {
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
                    case "id":

                    Data.Add(
                        key,

                        (string) dataJSON[key]
                    );

                    break;
                }
            }
        }

        /// <summary>
        /// Globally unique identifier.
        /// </summary>
        public string id() {
            return Get<string>("id");
        }

        public object Clone() {
            return new UnknownNode(DataJSON);
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
