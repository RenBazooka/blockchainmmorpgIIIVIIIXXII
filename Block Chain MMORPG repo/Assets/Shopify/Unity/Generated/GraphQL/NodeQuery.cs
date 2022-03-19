namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void NodeDelegate(NodeQuery query);

    /// <summary>
    /// An object with an ID to support global identification.
    /// </summary>
    public class NodeQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="NodeQuery" /> is used to build queries. Typically
        /// <see cref="NodeQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public NodeQuery(StringBuilder query) {
            Query = query;

            Query.Append("__typename ");
        }

        /// <summary>
        /// Globally unique identifier.
        /// </summary>
        public NodeQuery id() {
            Query.Append("id ");

            return this;
        }

        /// <summary>
        /// will allow you to write queries on AppliedGiftCard.
        /// </summary>
        public NodeQuery onAppliedGiftCard(AppliedGiftCardDelegate buildQuery) {
            Query.Append("...on AppliedGiftCard{");
            buildQuery(new AppliedGiftCardQuery(Query));
            Query.Append("}");
            return this;
        }

        /// <summary>
        /// will allow you to write queries on Article.
        /// </summary>
        public NodeQuery onArticle(ArticleDelegate buildQuery) {
            Query.Append("...on Article{");
            buildQuery(new ArticleQuery(Query));
            Query.Append("}");
            return this;
        }

        /// <summary>
        /// will allow you to write queries on Blog.
        /// </summary>
        public NodeQuery onBlog(BlogDelegate buildQuery) {
            Query.Append("...on Blog{");
            buildQuery(new BlogQuery(Query));
            Query.Append("}");
            return this;
        }

        /// <summary>
        /// will allow you to write queries on Checkout.
        /// </summary>
        public NodeQuery onCheckout(CheckoutDelegate buildQuery) {
            Query.Append("...on Checkout{");
            buildQuery(new CheckoutQuery(Query));
            Query.Append("}");
            return this;
        }

        /// <summary>
        /// will allow you to write queries on CheckoutLineItem.
        /// </summary>
        public NodeQuery onCheckoutLineItem(CheckoutLineItemDelegate buildQuery) {
            Query.Append("...on CheckoutLineItem{");
            buildQuery(new CheckoutLineItemQuery(Query));
            Query.Append("}");
            return this;
        }

        /// <summary>
        /// will allow you to write queries on Collection.
        /// </summary>
        public NodeQuery onCollection(CollectionDelegate buildQuery) {
            Query.Append("...on Collection{");
            buildQuery(new CollectionQuery(Query));
            Query.Append("}");
            return this;
        }

        /// <summary>
        /// will allow you to write queries on Comment.
        /// </summary>
        public NodeQuery onComment(CommentDelegate buildQuery) {
            Query.Append("...on Comment{");
            buildQuery(new CommentQuery(Query));
            Query.Append("}");
            return this;
        }

        /// <summary>
        /// will allow you to write queries on ExternalVideo.
        /// </summary>
        public NodeQuery onExternalVideo(ExternalVideoDelegate buildQuery) {
            Query.Append("...on ExternalVideo{");
            buildQuery(new ExternalVideoQuery(Query));
            Query.Append("}");
            return this;
        }

        /// <summary>
        /// will allow you to write queries on MailingAddress.
        /// </summary>
        public NodeQuery onMailingAddress(MailingAddressDelegate buildQuery) {
            Query.Append("...on MailingAddress{");
            buildQuery(new MailingAddressQuery(Query));
            Query.Append("}");
            return this;
        }

        /// <summary>
        /// will allow you to write queries on MediaImage.
        /// </summary>
        public NodeQuery onMediaImage(MediaImageDelegate buildQuery) {
            Query.Append("...on MediaImage{");
            buildQuery(new MediaImageQuery(Query));
            Query.Append("}");
            return this;
        }

        /// <summary>
        /// will allow you to write queries on Metafield.
        /// </summary>
        public NodeQuery onMetafield(MetafieldDelegate buildQuery) {
            Query.Append("...on Metafield{");
            buildQuery(new MetafieldQuery(Query));
            Query.Append("}");
            return this;
        }

        /// <summary>
        /// will allow you to write queries on Model3d.
        /// </summary>
        public NodeQuery onModel3d(Model3dDelegate buildQuery) {
            Query.Append("...on Model3d{");
            buildQuery(new Model3dQuery(Query));
            Query.Append("}");
            return this;
        }

        /// <summary>
        /// will allow you to write queries on Order.
        /// </summary>
        public NodeQuery onOrder(OrderDelegate buildQuery) {
            Query.Append("...on Order{");
            buildQuery(new OrderQuery(Query));
            Query.Append("}");
            return this;
        }

        /// <summary>
        /// will allow you to write queries on Page.
        /// </summary>
        public NodeQuery onPage(PageDelegate buildQuery) {
            Query.Append("...on Page{");
            buildQuery(new PageQuery(Query));
            Query.Append("}");
            return this;
        }

        /// <summary>
        /// will allow you to write queries on Payment.
        /// </summary>
        public NodeQuery onPayment(PaymentDelegate buildQuery) {
            Query.Append("...on Payment{");
            buildQuery(new PaymentQuery(Query));
            Query.Append("}");
            return this;
        }

        /// <summary>
        /// will allow you to write queries on Product.
        /// </summary>
        public NodeQuery onProduct(ProductDelegate buildQuery) {
            Query.Append("...on Product{");
            buildQuery(new ProductQuery(Query));
            Query.Append("}");
            return this;
        }

        /// <summary>
        /// will allow you to write queries on ProductOption.
        /// </summary>
        public NodeQuery onProductOption(ProductOptionDelegate buildQuery) {
            Query.Append("...on ProductOption{");
            buildQuery(new ProductOptionQuery(Query));
            Query.Append("}");
            return this;
        }

        /// <summary>
        /// will allow you to write queries on ProductVariant.
        /// </summary>
        public NodeQuery onProductVariant(ProductVariantDelegate buildQuery) {
            Query.Append("...on ProductVariant{");
            buildQuery(new ProductVariantQuery(Query));
            Query.Append("}");
            return this;
        }

        /// <summary>
        /// will allow you to write queries on ShopPolicy.
        /// </summary>
        public NodeQuery onShopPolicy(ShopPolicyDelegate buildQuery) {
            Query.Append("...on ShopPolicy{");
            buildQuery(new ShopPolicyQuery(Query));
            Query.Append("}");
            return this;
        }

        /// <summary>
        /// will allow you to write queries on Video.
        /// </summary>
        public NodeQuery onVideo(VideoDelegate buildQuery) {
            Query.Append("...on Video{");
            buildQuery(new VideoQuery(Query));
            Query.Append("}");
            return this;
        }
    }
    }
