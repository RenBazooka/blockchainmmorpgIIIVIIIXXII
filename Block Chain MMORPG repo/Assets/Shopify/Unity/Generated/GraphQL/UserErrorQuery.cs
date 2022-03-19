namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void UserErrorDelegate(UserErrorQuery query);

    /// <summary>
    /// Represents an error in the input of a mutation.
    /// </summary>
    public class UserErrorQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="UserErrorQuery" /> is used to build queries. Typically
        /// <see cref="UserErrorQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public UserErrorQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// Path to the input field which caused the error.
        /// </summary>
        public UserErrorQuery field() {
            Query.Append("field ");

            return this;
        }

        /// <summary>
        /// The error message.
        /// </summary>
        public UserErrorQuery message() {
            Query.Append("message ");

            return this;
        }
    }
    }
