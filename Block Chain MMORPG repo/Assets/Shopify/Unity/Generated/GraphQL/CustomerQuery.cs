namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void CustomerDelegate(CustomerQuery query);

    /// <summary>
    /// A customer represents a customer account with the shop. Customer accounts store contact information for the customer, saving logged-in customers the trouble of having to provide it at every checkout.
    /// </summary>
    public class CustomerQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="CustomerQuery" /> is used to build queries. Typically
        /// <see cref="CustomerQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public CustomerQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// Indicates whether the customer has consented to be sent marketing material via email.
        /// </summary>
        public CustomerQuery acceptsMarketing() {
            Query.Append("acceptsMarketing ");

            return this;
        }

        /// <summary>
        /// A list of addresses for the customer.
        /// </summary>
        /// <param name="first">
        /// Returns up to the first `n` elements from the list.
        /// </param>
        /// <param name="after">
        /// Returns the elements that come after the specified cursor.
        /// </param>
        /// <param name="last">
        /// Returns up to the last `n` elements from the list.
        /// </param>
        /// <param name="before">
        /// Returns the elements that come before the specified cursor.
        /// </param>
        /// <param name="reverse">
        /// Reverse the order of the underlying list.
        /// </param>
        public CustomerQuery addresses(MailingAddressConnectionDelegate buildQuery,long? first = null,string after = null,long? last = null,string before = null,bool? reverse = null,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("addresses___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("addresses ");

            Arguments args = new Arguments();

            if (first != null) {
                args.Add("first", first);
            }

            if (after != null) {
                args.Add("after", after);
            }

            if (last != null) {
                args.Add("last", last);
            }

            if (before != null) {
                args.Add("before", before);
            }

            if (reverse != null) {
                args.Add("reverse", reverse);
            }

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new MailingAddressConnectionQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// The date and time when the customer was created.
        /// </summary>
        public CustomerQuery createdAt() {
            Query.Append("createdAt ");

            return this;
        }

        /// <summary>
        /// The customer’s default address.
        /// </summary>
        public CustomerQuery defaultAddress(MailingAddressDelegate buildQuery) {
            Query.Append("defaultAddress ");

            Query.Append("{");
            buildQuery(new MailingAddressQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// The customer’s name, email or phone number.
        /// </summary>
        public CustomerQuery displayName() {
            Query.Append("displayName ");

            return this;
        }

        /// <summary>
        /// The customer’s email address.
        /// </summary>
        public CustomerQuery email() {
            Query.Append("email ");

            return this;
        }

        /// <summary>
        /// The customer’s first name.
        /// </summary>
        public CustomerQuery firstName() {
            Query.Append("firstName ");

            return this;
        }

        /// <summary>
        /// A unique identifier for the customer.
        /// </summary>
        public CustomerQuery id() {
            Query.Append("id ");

            return this;
        }

        /// <summary>
        /// The customer's most recently updated, incomplete checkout.
        /// </summary>
        public CustomerQuery lastIncompleteCheckout(CheckoutDelegate buildQuery) {
            Query.Append("lastIncompleteCheckout ");

            Query.Append("{");
            buildQuery(new CheckoutQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// The customer’s last name.
        /// </summary>
        public CustomerQuery lastName() {
            Query.Append("lastName ");

            return this;
        }

        /// <summary>
        /// The orders associated with the customer.
        /// </summary>
        /// <param name="first">
        /// Returns up to the first `n` elements from the list.
        /// </param>
        /// <param name="after">
        /// Returns the elements that come after the specified cursor.
        /// </param>
        /// <param name="last">
        /// Returns up to the last `n` elements from the list.
        /// </param>
        /// <param name="before">
        /// Returns the elements that come before the specified cursor.
        /// </param>
        /// <param name="reverse">
        /// Reverse the order of the underlying list.
        /// </param>
        /// <param name="sortKey">
        /// Sort the underlying list by the given key.
        /// </param>
        /// <param name="query">
        /// Supported filter parameters:
        /// - `processed_at`
        /// 
        /// See the detailed [search syntax](https://help.shopify.com/api/getting-started/search-syntax)
        /// for more information about using filters.
        /// </param>
        public CustomerQuery orders(OrderConnectionDelegate buildQuery,long? first = null,string after = null,long? last = null,string before = null,bool? reverse = null,OrderSortKeys? sortKey = null,string queryValue = null,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("orders___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("orders ");

            Arguments args = new Arguments();

            if (first != null) {
                args.Add("first", first);
            }

            if (after != null) {
                args.Add("after", after);
            }

            if (last != null) {
                args.Add("last", last);
            }

            if (before != null) {
                args.Add("before", before);
            }

            if (reverse != null) {
                args.Add("reverse", reverse);
            }

            if (sortKey != null) {
                args.Add("sortKey", sortKey);
            }

            if (queryValue != null) {
                args.Add("query", queryValue);
            }

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new OrderConnectionQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// The customer’s phone number.
        /// </summary>
        public CustomerQuery phone() {
            Query.Append("phone ");

            return this;
        }

        /// <summary>
        /// A comma separated list of tags that have been added to the customer.
        /// Additional access scope required: unauthenticated_read_customer_tags.
        /// </summary>
        public CustomerQuery tags() {
            Query.Append("tags ");

            return this;
        }

        /// <summary>
        /// The date and time when the customer information was updated.
        /// </summary>
        public CustomerQuery updatedAt() {
            Query.Append("updatedAt ");

            return this;
        }
    }
    }
