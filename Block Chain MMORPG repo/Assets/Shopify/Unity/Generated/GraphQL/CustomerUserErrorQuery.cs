namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void CustomerUserErrorDelegate(CustomerUserErrorQuery query);

    /// <summary>
    /// Represents an error that happens during execution of a customer mutation.
    /// </summary>
    public class CustomerUserErrorQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="CustomerUserErrorQuery" /> is used to build queries. Typically
        /// <see cref="CustomerUserErrorQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public CustomerUserErrorQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// Error code to uniquely identify the error.
        /// </summary>
        public CustomerUserErrorQuery code() {
            Query.Append("code ");

            return this;
        }

        /// <summary>
        /// Path to the input field which caused the error.
        /// </summary>
        public CustomerUserErrorQuery field() {
            Query.Append("field ");

            return this;
        }

        /// <summary>
        /// The error message.
        /// </summary>
        public CustomerUserErrorQuery message() {
            Query.Append("message ");

            return this;
        }
    }
    }
