namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void OrderLineItemDelegate(OrderLineItemQuery query);

    /// <summary>
    /// Represents a single line in an order. There is one line item for each distinct product variant.
    /// </summary>
    public class OrderLineItemQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="OrderLineItemQuery" /> is used to build queries. Typically
        /// <see cref="OrderLineItemQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public OrderLineItemQuery(StringBuilder query) {
            Query = query;
        }

        /// <summary>
        /// List of custom attributes associated to the line item.
        /// </summary>
        public OrderLineItemQuery customAttributes(AttributeDelegate buildQuery) {
            Query.Append("customAttributes ");

            Query.Append("{");
            buildQuery(new AttributeQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// The discounts that have been allocated onto the order line item by discount applications.
        /// </summary>
        public OrderLineItemQuery discountAllocations(DiscountAllocationDelegate buildQuery) {
            Query.Append("discountAllocations ");

            Query.Append("{");
            buildQuery(new DiscountAllocationQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// The number of products variants associated to the line item.
        /// </summary>
        public OrderLineItemQuery quantity() {
            Query.Append("quantity ");

            return this;
        }

        /// <summary>
        /// The title of the product combined with title of the variant.
        /// </summary>
        public OrderLineItemQuery title() {
            Query.Append("title ");

            return this;
        }

        /// <summary>
        /// The product variant object associated to the line item.
        /// </summary>
        public OrderLineItemQuery variant(ProductVariantDelegate buildQuery) {
            Query.Append("variant ");

            Query.Append("{");
            buildQuery(new ProductVariantQuery(Query));
            Query.Append("}");

            return this;
        }
    }
    }
