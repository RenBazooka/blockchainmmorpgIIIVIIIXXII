namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void DisplayableErrorDelegate(DisplayableErrorQuery query);

    /// <summary>
    /// Represents an error in the input of a mutation.
    /// </summary>
    public class DisplayableErrorQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="DisplayableErrorQuery" /> is used to build queries. Typically
        /// <see cref="DisplayableErrorQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public DisplayableErrorQuery(StringBuilder query) {
            Query = query;

            Query.Append("__typename ");
        }

        /// <summary>
        /// Path to the input field which caused the error.
        /// </summary>
        public DisplayableErrorQuery field() {
            Query.Append("field ");

            return this;
        }

        /// <summary>
        /// The error message.
        /// </summary>
        public DisplayableErrorQuery message() {
            Query.Append("message ");

            return this;
        }

        /// <summary>
        /// will allow you to write queries on CheckoutUserError.
        /// </summary>
        public DisplayableErrorQuery onCheckoutUserError(CheckoutUserErrorDelegate buildQuery) {
            Query.Append("...on CheckoutUserError{");
            buildQuery(new CheckoutUserErrorQuery(Query));
            Query.Append("}");
            return this;
        }

        /// <summary>
        /// will allow you to write queries on CustomerUserError.
        /// </summary>
        public DisplayableErrorQuery onCustomerUserError(CustomerUserErrorDelegate buildQuery) {
            Query.Append("...on CustomerUserError{");
            buildQuery(new CustomerUserErrorQuery(Query));
            Query.Append("}");
            return this;
        }

        /// <summary>
        /// will allow you to write queries on UserError.
        /// </summary>
        public DisplayableErrorQuery onUserError(UserErrorDelegate buildQuery) {
            Query.Append("...on UserError{");
            buildQuery(new UserErrorQuery(Query));
            Query.Append("}");
            return this;
        }
    }
    }
