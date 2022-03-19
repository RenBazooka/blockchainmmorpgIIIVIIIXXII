namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void AppliedGiftCardDelegate(AppliedGiftCardQuery query);

    /// <summary>
    /// Details about the gift card used on the checkout.
    /// </summary>
    public class AppliedGiftCardQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="AppliedGiftCardQuery" /> is used to build queries. Typically
        /// <see cref="AppliedGiftCardQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public AppliedGiftCardQuery(StringBuilder query) {
            Query = query;
        }

        /// \deprecated Use `amountUsedV2` instead
        /// <summary>
        /// The amount that was taken from the gift card by applying it.
        /// </summary>
        public AppliedGiftCardQuery amountUsed() {
            Log.DeprecatedQueryField("AppliedGiftCard", "amountUsed", "Use `amountUsedV2` instead");

            Query.Append("amountUsed ");

            return this;
        }

        /// <summary>
        /// The amount that was taken from the gift card by applying it.
        /// </summary>
        public AppliedGiftCardQuery amountUsedV2(MoneyV2Delegate buildQuery) {
            Query.Append("amountUsedV2 ");

            Query.Append("{");
            buildQuery(new MoneyV2Query(Query));
            Query.Append("}");

            return this;
        }

        /// \deprecated Use `balanceV2` instead
        /// <summary>
        /// The amount left on the gift card.
        /// </summary>
        public AppliedGiftCardQuery balance() {
            Log.DeprecatedQueryField("AppliedGiftCard", "balance", "Use `balanceV2` instead");

            Query.Append("balance ");

            return this;
        }

        /// <summary>
        /// The amount left on the gift card.
        /// </summary>
        public AppliedGiftCardQuery balanceV2(MoneyV2Delegate buildQuery) {
            Query.Append("balanceV2 ");

            Query.Append("{");
            buildQuery(new MoneyV2Query(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Globally unique identifier.
        /// </summary>
        public AppliedGiftCardQuery id() {
            Query.Append("id ");

            return this;
        }

        /// <summary>
        /// The last characters of the gift card.
        /// </summary>
        public AppliedGiftCardQuery lastCharacters() {
            Query.Append("lastCharacters ");

            return this;
        }

        /// <summary>
        /// The amount that was applied to the checkout in its currency.
        /// </summary>
        public AppliedGiftCardQuery presentmentAmountUsed(MoneyV2Delegate buildQuery) {
            Query.Append("presentmentAmountUsed ");

            Query.Append("{");
            buildQuery(new MoneyV2Query(Query));
            Query.Append("}");

            return this;
        }
    }
    }
