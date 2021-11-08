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
    /// ErgoTransactionOutput
    /// </summary>
    [DataContract(Name = "ErgoTransactionOutput")]
    public partial class ErgoTransactionOutput : IEquatable<ErgoTransactionOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErgoTransactionOutput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ErgoTransactionOutput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ErgoTransactionOutput" /> class.
        /// </summary>
        /// <param name="boxId">Base16-encoded transaction box id bytes. Should be 32 bytes long.</param>
        /// <param name="value">Amount of Ergo token (required).</param>
        /// <param name="ergoTree">Base16-encoded ergo tree bytes (required).</param>
        /// <param name="creationHeight">Height the output was created at (required).</param>
        /// <param name="assets">Assets list in the transaction.</param>
        /// <param name="additionalRegisters">Ergo box registers (required).</param>
        /// <param name="transactionId">Base16-encoded transaction id bytes.</param>
        /// <param name="index">Index in the transaction outputs.</param>
        public ErgoTransactionOutput(string boxId = default(string), long value = default(long), string ergoTree = default(string), int creationHeight = default(int), List<Asset> assets = default(List<Asset>), Dictionary<string, string> additionalRegisters = default(Dictionary<string, string>), string transactionId = default(string), int index = default(int))
        {
            this.Value = value;
            // to ensure "ergoTree" is required (not null)
            if (ergoTree == null) {
                throw new ArgumentNullException("ergoTree is a required property for ErgoTransactionOutput and cannot be null");
            }
            this.ErgoTree = ergoTree;
            this.CreationHeight = creationHeight;
            // to ensure "additionalRegisters" is required (not null)
            if (additionalRegisters == null) {
                throw new ArgumentNullException("additionalRegisters is a required property for ErgoTransactionOutput and cannot be null");
            }
            this.AdditionalRegisters = additionalRegisters;
            this.BoxId = boxId;
            this.Assets = assets;
            this.TransactionId = transactionId;
            this.Index = index;
        }

        /// <summary>
        /// Base16-encoded transaction box id bytes. Should be 32 bytes long
        /// </summary>
        /// <value>Base16-encoded transaction box id bytes. Should be 32 bytes long</value>
        [DataMember(Name = "boxId", EmitDefaultValue = false)]
        public string BoxId { get; set; }

        /// <summary>
        /// Amount of Ergo token
        /// </summary>
        /// <value>Amount of Ergo token</value>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = false)]
        public long Value { get; set; }

        /// <summary>
        /// Base16-encoded ergo tree bytes
        /// </summary>
        /// <value>Base16-encoded ergo tree bytes</value>
        [DataMember(Name = "ergoTree", IsRequired = true, EmitDefaultValue = false)]
        public string ErgoTree { get; set; }

        /// <summary>
        /// Height the output was created at
        /// </summary>
        /// <value>Height the output was created at</value>
        [DataMember(Name = "creationHeight", IsRequired = true, EmitDefaultValue = false)]
        public int CreationHeight { get; set; }

        /// <summary>
        /// Assets list in the transaction
        /// </summary>
        /// <value>Assets list in the transaction</value>
        [DataMember(Name = "assets", EmitDefaultValue = false)]
        public List<Asset> Assets { get; set; }

        /// <summary>
        /// Ergo box registers
        /// </summary>
        /// <value>Ergo box registers</value>
        [DataMember(Name = "additionalRegisters", IsRequired = true, EmitDefaultValue = false)]
        public Dictionary<string, string> AdditionalRegisters { get; set; }

        /// <summary>
        /// Base16-encoded transaction id bytes
        /// </summary>
        /// <value>Base16-encoded transaction id bytes</value>
        [DataMember(Name = "transactionId", EmitDefaultValue = false)]
        public string TransactionId { get; set; }

        /// <summary>
        /// Index in the transaction outputs
        /// </summary>
        /// <value>Index in the transaction outputs</value>
        [DataMember(Name = "index", EmitDefaultValue = false)]
        public int Index { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ErgoTransactionOutput {\n");
            sb.Append("  BoxId: ").Append(BoxId).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  ErgoTree: ").Append(ErgoTree).Append("\n");
            sb.Append("  CreationHeight: ").Append(CreationHeight).Append("\n");
            sb.Append("  Assets: ").Append(Assets).Append("\n");
            sb.Append("  AdditionalRegisters: ").Append(AdditionalRegisters).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
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
            return this.Equals(input as ErgoTransactionOutput);
        }

        /// <summary>
        /// Returns true if ErgoTransactionOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of ErgoTransactionOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ErgoTransactionOutput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BoxId == input.BoxId ||
                    (this.BoxId != null &&
                    this.BoxId.Equals(input.BoxId))
                ) && 
                (
                    this.Value == input.Value ||
                    this.Value.Equals(input.Value)
                ) && 
                (
                    this.ErgoTree == input.ErgoTree ||
                    (this.ErgoTree != null &&
                    this.ErgoTree.Equals(input.ErgoTree))
                ) && 
                (
                    this.CreationHeight == input.CreationHeight ||
                    this.CreationHeight.Equals(input.CreationHeight)
                ) && 
                (
                    this.Assets == input.Assets ||
                    this.Assets != null &&
                    input.Assets != null &&
                    this.Assets.SequenceEqual(input.Assets)
                ) && 
                (
                    this.AdditionalRegisters == input.AdditionalRegisters ||
                    this.AdditionalRegisters != null &&
                    input.AdditionalRegisters != null &&
                    this.AdditionalRegisters.SequenceEqual(input.AdditionalRegisters)
                ) && 
                (
                    this.TransactionId == input.TransactionId ||
                    (this.TransactionId != null &&
                    this.TransactionId.Equals(input.TransactionId))
                ) && 
                (
                    this.Index == input.Index ||
                    this.Index.Equals(input.Index)
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
                if (this.BoxId != null)
                    hashCode = hashCode * 59 + this.BoxId.GetHashCode();
                hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.ErgoTree != null)
                    hashCode = hashCode * 59 + this.ErgoTree.GetHashCode();
                hashCode = hashCode * 59 + this.CreationHeight.GetHashCode();
                if (this.Assets != null)
                    hashCode = hashCode * 59 + this.Assets.GetHashCode();
                if (this.AdditionalRegisters != null)
                    hashCode = hashCode * 59 + this.AdditionalRegisters.GetHashCode();
                if (this.TransactionId != null)
                    hashCode = hashCode * 59 + this.TransactionId.GetHashCode();
                hashCode = hashCode * 59 + this.Index.GetHashCode();
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
            // Value (long) minimum
            if(this.Value < (long)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Value, must be a value greater than or equal to 0.", new [] { "Value" });
            }

            yield break;
        }
    }

}
