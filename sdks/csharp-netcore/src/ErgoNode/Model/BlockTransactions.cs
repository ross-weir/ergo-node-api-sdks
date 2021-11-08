/*
 * Ergo Node API
 *
 * API docs for Ergo Node. Models are shared between all Ergo products
 *
 * The version of the OpenAPI document: 4.0.15
 * Contact: ergoplatform@protonmail.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = ErgoNode.Client.OpenAPIDateConverter;

namespace ErgoNode.Model
{
    /// <summary>
    /// BlockTransactions
    /// </summary>
    [DataContract(Name = "BlockTransactions")]
    public partial class BlockTransactions : IEquatable<BlockTransactions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BlockTransactions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BlockTransactions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BlockTransactions" /> class.
        /// </summary>
        /// <param name="headerId">Base16-encoded 32 byte modifier id (required).</param>
        /// <param name="transactions">Ergo transaction objects (required).</param>
        /// <param name="size">Size in bytes (required).</param>
        public BlockTransactions(string headerId = default(string), List<ErgoTransaction> transactions = default(List<ErgoTransaction>), int size = default(int))
        {
            // to ensure "headerId" is required (not null)
            if (headerId == null) {
                throw new ArgumentNullException("headerId is a required property for BlockTransactions and cannot be null");
            }
            this.HeaderId = headerId;
            // to ensure "transactions" is required (not null)
            if (transactions == null) {
                throw new ArgumentNullException("transactions is a required property for BlockTransactions and cannot be null");
            }
            this.Transactions = transactions;
            this.Size = size;
        }

        /// <summary>
        /// Base16-encoded 32 byte modifier id
        /// </summary>
        /// <value>Base16-encoded 32 byte modifier id</value>
        [DataMember(Name = "headerId", IsRequired = true, EmitDefaultValue = false)]
        public string HeaderId { get; set; }

        /// <summary>
        /// Ergo transaction objects
        /// </summary>
        /// <value>Ergo transaction objects</value>
        [DataMember(Name = "transactions", IsRequired = true, EmitDefaultValue = false)]
        public List<ErgoTransaction> Transactions { get; set; }

        /// <summary>
        /// Size in bytes
        /// </summary>
        /// <value>Size in bytes</value>
        [DataMember(Name = "size", IsRequired = true, EmitDefaultValue = false)]
        public int Size { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BlockTransactions {\n");
            sb.Append("  HeaderId: ").Append(HeaderId).Append("\n");
            sb.Append("  Transactions: ").Append(Transactions).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as BlockTransactions);
        }

        /// <summary>
        /// Returns true if BlockTransactions instances are equal
        /// </summary>
        /// <param name="input">Instance of BlockTransactions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BlockTransactions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HeaderId == input.HeaderId ||
                    (this.HeaderId != null &&
                    this.HeaderId.Equals(input.HeaderId))
                ) && 
                (
                    this.Transactions == input.Transactions ||
                    this.Transactions != null &&
                    input.Transactions != null &&
                    this.Transactions.SequenceEqual(input.Transactions)
                ) && 
                (
                    this.Size == input.Size ||
                    this.Size.Equals(input.Size)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.HeaderId != null)
                    hashCode = hashCode * 59 + this.HeaderId.GetHashCode();
                if (this.Transactions != null)
                    hashCode = hashCode * 59 + this.Transactions.GetHashCode();
                hashCode = hashCode * 59 + this.Size.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
