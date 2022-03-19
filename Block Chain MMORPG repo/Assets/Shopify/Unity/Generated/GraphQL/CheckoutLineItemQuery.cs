namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void CheckoutLineItemDelegate(CheckoutLineItemQuery query);

    /// <summary>
    /// A single line item in the checkout, grouped by variant and attributes.
    /// </summary>
    public class CheckoutLineItemQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="CheckoutLineItemQuery" /> is used to build queries. Typically
        /// <see cref="CheckoutLineItemQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public CheckoutLineItemQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// Extra information in the form of an array of Key-Value pairs about the line item.
        /// </summary>
        public CheckoutLineItemQuery customAttributes(AttributeDelegate buildQuery) {
            Query.Append("customAttributes ");

            Query.Append("{");
            buildQuery(new AttributeQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// The discounts that have been allocated onto the checkout line item by discount applications.
        /// </summary>
        public CheckoutLineItemQuery discountAllocations(DiscountAllocationDelegate buildQuery) {
            Query.Append("discountAllocations ");

            Query.Append("{");
            buildQuery(new DiscountAllocationQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// Globally unique identifier.
        /// </summary>
        public CheckoutLineItemQuery id() {
            Query.Append("id ");

            return this;
        }

        /// <summary>
        /// The quantity of the line item.
        /// </summary>
        public CheckoutLineItemQuery quantity() {
            Query.Append("quantity ");

            return this;
        }

        /// <summary>
        /// Title of the line item. Defaults to the product's title.
        /// </summary>
        public CheckoutLineItemQuery title() {
            Query.Append("title ");

            return this;
        }

        /// <summary>
        /// Product variant of the line item.
        /// </summary>
        public CheckoutLineItemQuery variant(ProductVariantDelegate buildQuery) {
            Query.Append("variant ");

            Query.Append("{");
            buildQuery(new ProductVariantQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
