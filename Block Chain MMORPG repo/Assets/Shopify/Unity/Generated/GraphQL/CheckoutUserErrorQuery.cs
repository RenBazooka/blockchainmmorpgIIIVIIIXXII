namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void CheckoutUserErrorDelegate(CheckoutUserErrorQuery query);

    /// <summary>
    /// Represents an error that happens during execution of a checkout mutation.
    /// </summary>
    public class CheckoutUserErrorQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="CheckoutUserErrorQuery" /> is used to build queries. Typically
        /// <see cref="CheckoutUserErrorQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public CheckoutUserErrorQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// Error code to uniquely identify the error.
        /// </summary>
        public CheckoutUserErrorQuery code() {
            Query.Append("code ");

            return this;
        }

        /// <summary>
        /// Path to the input field which caused the error.
        /// </summary>
        public CheckoutUserErrorQuery field() {
            Query.Append("field ");

            return this;
        }

        /// <summary>
        /// The error message.
        /// </summary>
        public CheckoutUserErrorQuery message() {
            Query.Append("message ");

            return this;
        }
    }
    }
