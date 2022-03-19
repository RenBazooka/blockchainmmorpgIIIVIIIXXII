namespace Shopify.Unity {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Shopify.Unity.SDK;

    /// <summary>
    /// An object representing exchange of money for a product or service.
    /// </summary>
    public class Transaction : AbstractResponse, ICloneable {
        /// <summary>
        /// <see ref="Transaction" /> Accepts deserialized json data.
        /// <see ref="Transaction" /> Will further parse passed in data.
        /// </summary>
        /// <param name="dataJSON">Deserialized JSON data for Transaction</param>
        public Transaction(Dictionary<string, object> dataJSON) {
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

                    case "amountV2":

                    Data.Add(
                        key,

                        new MoneyV2((Dictionary<string,object>) dataJSON[key])
                    );

                    break;

                    case "kind":

                    Data.Add(
                        key,

                        CastUtils.GetEnumValue<TransactionKind>(dataJSON[key])
                    );

                    break;

                    case "status":

                    Data.Add(
                        key,

                        CastUtils.GetEnumValue<TransactionStatus>(dataJSON[key])
                    );

                    break;

                    case "statusV2":

                    if (dataJSON[key] == null) {
                        Data.Add(key, null);
                    } else {
                        Data.Add(
                            key,

                            CastUtils.GetEnumValue<TransactionStatus>(dataJSON[key])
                        );
                    }

                    break;

                    case "test":

                    Data.Add(
                        key,

                        (bool) dataJSON[key]
                    );

                    break;
                }
            }
        }

        /// \deprecated Use `amountV2` instead
        /// <summary>
        /// The amount of money that the transaction was for.
        /// </summary>
        public decimal amount() {
            return Get<decimal>("amount");
        }

        /// <summary>
        /// The amount of money that the transaction was for.
        /// </summary>
        public MoneyV2 amountV2() {
            return Get<MoneyV2>("amountV2");
        }

        /// <summary>
        /// The kind of the transaction.
        /// </summary>
        public TransactionKind kind() {
            return Get<TransactionKind>("kind");
        }

        /// \deprecated Use `statusV2` instead
        /// <summary>
        /// The status of the transaction.
        /// </summary>
        public TransactionStatus status() {
            return Get<TransactionStatus>("status");
        }

        /// <summary>
        /// The status of the transaction.
        /// </summary>
        public TransactionStatus? statusV2() {
            return Get<TransactionStatus?>("statusV2");
        }

        /// <summary>
        /// Whether the transaction was done in test mode or not.
        /// </summary>
        public bool test() {
            return Get<bool>("test");
        }

        public object Clone() {
            return new Transaction(DataJSON);
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
