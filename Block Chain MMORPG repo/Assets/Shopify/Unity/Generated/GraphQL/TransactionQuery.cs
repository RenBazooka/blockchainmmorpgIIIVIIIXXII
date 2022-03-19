namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void TransactionDelegate(TransactionQuery query);

    /// <summary>
    /// An object representing exchange of money for a product or service.
    /// </summary>
    public class TransactionQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="TransactionQuery" /> is used to build queries. Typically
        /// <see cref="TransactionQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public TransactionQuery(StringBuilder query) {
            Query = query;
        }

        /// \deprecated Use `amountV2` instead
        /// <summary>
        /// The amount of money that the transaction was for.
        /// </summary>
        public TransactionQuery amount() {
            Log.DeprecatedQueryField("Transaction", "amount", "Use `amountV2` instead");

            Query.Append("amount ");

            return this;
        }

        /// <summary>
        /// The amount of money that the transaction was for.
        /// </summary>
        public TransactionQuery amountV2(MoneyV2Delegate buildQuery) {
            Query.Append("amountV2 ");

            Query.Append("{");
            buildQuery(new MoneyV2Query(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// The kind of the transaction.
        /// </summary>
        public TransactionQuery kind() {
            Query.Append("kind ");

            return this;
        }

        /// \deprecated Use `statusV2` instead
        /// <summary>
        /// The status of the transaction.
        /// </summary>
        public TransactionQuery status() {
            Log.DeprecatedQueryField("Transaction", "status", "Use `statusV2` instead");

            Query.Append("status ");

            return this;
        }

        /// <summary>
        /// The status of the transaction.
        /// </summary>
        public TransactionQuery statusV2() {
            Query.Append("statusV2 ");

            return this;
        }

        /// <summary>
        /// Whether the transaction was done in test mode or not.
        /// </summary>
        public TransactionQuery test() {
            Query.Append("test ");

            return this;
        }
    }
    }
