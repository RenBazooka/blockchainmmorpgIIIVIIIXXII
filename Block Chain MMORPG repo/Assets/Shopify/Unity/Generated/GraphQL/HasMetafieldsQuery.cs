namespace Shopify.Unity.GraphQL {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    public delegate void HasMetafieldsDelegate(HasMetafieldsQuery query);

    /// <summary>
    /// Represents information about the metafields associated to the specified resource.
    /// </summary>
    public class HasMetafieldsQuery {
        private StringBuilder Query;

        /// <summary>
        /// <see cref="HasMetafieldsQuery" /> is used to build queries. Typically
        /// <see cref="HasMetafieldsQuery" /> will not be used directly but instead will be used when building queries from either
        /// <see cref="QueryRootQuery" /> or <see cref="MutationQuery" />.
        /// </summary>
        public HasMetafieldsQuery(StringBuilder query) {
            Query = query;

            Query.Append("__typename ");
        }

        /// <summary>
        /// The metafield associated with the resource.
        /// </summary>
        /// <param name="namespace">
        /// Container for a set of metafields (maximum of 20 characters).
        /// </param>
        /// <param name="key">
        /// Identifier for the metafield (maximum of 30 characters).
        /// </param>
        public HasMetafieldsQuery metafield(MetafieldDelegate buildQuery,string namespaceValue,string key,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("metafield___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("metafield ");

            Arguments args = new Arguments();

            args.Add("namespace", namespaceValue);

            args.Add("key", key);

            Query.Append(args.ToString());

            Query.Append("{");
            buildQuery(new MetafieldQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// A paginated list of metafields associated with the resource.
        /// </summary>
        /// <param name="namespace">
        /// Container for a set of metafields (maximum of 20 characters).
        /// </param>
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
        public HasMetafieldsQuery metafields(MetafieldConnectionDelegate buildQuery,string namespaceValue = null,long? first = null,string after = null,long? last = null,string before = null,bool? reverse = null,string alias = null) {
            if (alias != null) {
                ValidationUtils.ValidateAlias(alias);

                Query.Append("metafields___");
                Query.Append(alias);
                Query.Append(":");
            }

            Query.Append("metafields ");

            Arguments args = new Arguments();

            if (namespaceValue != null) {
                args.Add("namespace", namespaceValue);
            }

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
            buildQuery(new MetafieldConnectionQuery(Query));
            Query.Append("}");

            return this;
        }

        /// <summary>
        /// will allow you to write queries on Product.
        /// </summary>
        public HasMetafieldsQuery onProduct(ProductDelegate buildQuery) {
            Query.Append("...on Product{");
            buildQuery(new ProductQuery(Query));
            Query.Append("}");
            return this;
        }

        /// <summary>
        /// will allow you to write queries on ProductVariant.
        /// </summary>
        public HasMetafieldsQuery onProductVariant(ProductVariantDelegate buildQuery) {
            Query.Append("...on ProductVariant{");
            buildQuery(new ProductVariantQuery(Query));
            Query.Append("}");
            return this;
        }
    }
    }
