namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// An auto-generated type for paginating through multiple ProductVariantPricePairs.
    /// . ProductVariantPricePairConnection can be cast to <c>List<ProductVariantPricePair></c>.
    /// </summary>
    public class ProductVariantPricePairConnection : AbstractResponse, ICloneable, IEnumerable {
        /// <summary>
        /// Adds the ability to cast ProductVariantPricePairConnection to <c>List<ProductVariantPricePair></c>.
        /// </summary>
        public static explicit operator List<ProductVariantPricePair>(ProductVariantPricePairConnection connection) {
            if (connection.Nodes == null) {
                connection.Nodes = new List<ProductVariantPricePair>();

                foreach(ProductVariantPricePairEdge edge in connection.edges()) {
                    connection.Nodes.Add(edge.node());
                }
            }

            return connection.Nodes;
        }

        /// <summary>
        /// <see ref="ProductVariantPricePairConnection" /> Accepts deserialized json data.
        /// <see ref="ProductVariantPricePairConnection" /> Will further parse passed in data.
        /// </summary>
        /// <param name="dataJSON">Deserialized JSON data for ProductVariantPricePairConnection</param>
        public ProductVariantPricePairConnection(Dictionary<string, object> dataJSON) {
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
                    case "edges":

                    Data.Add(
                        key,

                        CastUtils.CastList<List<ProductVariantPricePairEdge>>((IList) dataJSON[key])
                    );

                    break;

                    case "pageInfo":

                    Data.Add(
                        key,

                        new PageInfo((Dictionary<string,object>) dataJSON[key])
                    );

                    break;
                }
            }
        }

        protected List<ProductVariantPricePair> Nodes;

        public IEnumerator GetEnumerator() {
            return (IEnumerator) this;
        }

        /// <summary>
        /// A list of edges.
        /// </summary>
        public List<ProductVariantPricePairEdge> edges() {
            return Get<List<ProductVariantPricePairEdge>>("edges");
        }

        /// <summary>
        /// Information to aid in pagination.
        /// </summary>
        public PageInfo pageInfo() {
            return Get<PageInfo>("pageInfo");
        }

        public object Clone() {
            return new ProductVariantPricePairConnection(DataJSON);
        }

        /// <summary>
        /// This is a utility function that allows you to append newly queried data from a connection into this one.
        /// The passed in Connection will be appended into this Connection. The <c>edges</c> will receive
        /// all new <c>nodes</c>, and both the <c>cursors</c> and <c>pageInfo</c> will be updated based on the passed Connection.
        /// </summary>
        /// <param name="connection"><see ref="ProductVariantPricePairConnection" /> response</param>
        public void AddFromConnection(ProductVariantPricePairConnection connection) {
            connection.Nodes = null;

            List<ProductVariantPricePairEdge> clonedList = new List<ProductVariantPricePairEdge>();

            foreach(ProductVariantPricePairEdge edge in connection.edges()) {
                clonedList.Add((ProductVariantPricePairEdge) edge.Clone());
            }

            if (Data.ContainsKey("edges")) {
                edges().AddRange(clonedList);
                Data["pageInfo"] = connection.pageInfo().Clone();
            } else {
                Data["edges"] = clonedList;
                Data["pageInfo"] = connection.pageInfo().Clone();
            }
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
