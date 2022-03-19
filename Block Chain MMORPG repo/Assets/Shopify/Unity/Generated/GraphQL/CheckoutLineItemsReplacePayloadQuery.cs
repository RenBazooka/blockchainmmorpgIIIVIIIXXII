namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void CheckoutLineItemsReplacePayloadDelegate(CheckoutLineItemsReplacePayloadQuery query);

    /// <summary>
    /// Return type for `checkoutLineItemsReplace` mutation.
    /// </summary>
    public class CheckoutLineItemsReplacePayloadQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="CheckoutLineItemsReplacePayloadQuery" /> is used to build queries. Typically
        /// <see cref="CheckoutLineItemsReplacePayloadQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public CheckoutLineItemsReplacePayloadQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// The updated checkout object.
        /// </summary>
        public CheckoutLineItemsReplacePayloadQuery checkout(CheckoutDelegate buildQuery) {
            Query.Append("checkout ");

            Query.Append("{");
            buildQuery(new CheckoutQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// List of errors that occurred executing the mutation.
        /// </summary>
        public CheckoutLineItemsReplacePayloadQuery userErrors(CheckoutUserErrorDelegate buildQuery) {
            Query.Append("userErrors ");

            Query.Append("{");
            buildQuery(new CheckoutUserErrorQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
