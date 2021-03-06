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
    /// ErgoLikeTransaction
    /// </summary>
    [DataContract(Name = "ErgoLikeTransaction")]
    public partial class ErgoLikeTransaction : IEquatable<ErgoLikeTransaction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErgoLikeTransaction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ErgoLikeTransaction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ErgoLikeTransaction" /> class.
        /// </summary>
        /// <param name="id">Base16-encoded 32 byte modifier id (required).</param>
        /// <param name="inputs">inputs (required).</param>
        /// <param name="dataInputs">dataInputs (required).</param>
        /// <param name="outputs">outputs (required).</param>
        public ErgoLikeTransaction(string id = default(string), List<ErgoTransactionInput> inputs = default(List<ErgoTransactionInput>), List<ErgoTransactionDataInput> dataInputs = default(List<ErgoTransactionDataInput>), List<ErgoTransactionOutput> outputs = default(List<ErgoTransactionOutput>))
        {
            // to ensure "id" is required (not null)
            if (id == null) {
                throw new ArgumentNullException("id is a required property for ErgoLikeTransaction and cannot be null");
            }
            this.Id = id;
            // to ensure "inputs" is required (not null)
            if (inputs == null) {
                throw new ArgumentNullException("inputs is a required property for ErgoLikeTransaction and cannot be null");
            }
            this.Inputs = inputs;
            // to ensure "dataInputs" is required (not null)
            if (dataInputs == null) {
                throw new ArgumentNullException("dataInputs is a required property for ErgoLikeTransaction and cannot be null");
            }
            this.DataInputs = dataInputs;
            // to ensure "outputs" is required (not null)
            if (outputs == null) {
                throw new ArgumentNullException("outputs is a required property for ErgoLikeTransaction and cannot be null");
            }
            this.Outputs = outputs;
        }

        /// <summary>
        /// Base16-encoded 32 byte modifier id
        /// </summary>
        /// <value>Base16-encoded 32 byte modifier id</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Inputs
        /// </summary>
        [DataMember(Name = "inputs", IsRequired = true, EmitDefaultValue = false)]
        public List<ErgoTransactionInput> Inputs { get; set; }

        /// <summary>
        /// Gets or Sets DataInputs
        /// </summary>
        [DataMember(Name = "dataInputs", IsRequired = true, EmitDefaultValue = false)]
        public List<ErgoTransactionDataInput> DataInputs { get; set; }

        /// <summary>
        /// Gets or Sets Outputs
        /// </summary>
        [DataMember(Name = "outputs", IsRequired = true, EmitDefaultValue = false)]
        public List<ErgoTransactionOutput> Outputs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ErgoLikeTransaction {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Inputs: ").Append(Inputs).Append("\n");
            sb.Append("  DataInputs: ").Append(DataInputs).Append("\n");
            sb.Append("  Outputs: ").Append(Outputs).Append("\n");
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
            return this.Equals(input as ErgoLikeTransaction);
        }

        /// <summary>
        /// Returns true if ErgoLikeTransaction instances are equal
        /// </summary>
        /// <param name="input">Instance of ErgoLikeTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ErgoLikeTransaction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Inputs == input.Inputs ||
                    this.Inputs != null &&
                    input.Inputs != null &&
                    this.Inputs.SequenceEqual(input.Inputs)
                ) && 
                (
                    this.DataInputs == input.DataInputs ||
                    this.DataInputs != null &&
                    input.DataInputs != null &&
                    this.DataInputs.SequenceEqual(input.DataInputs)
                ) && 
                (
                    this.Outputs == input.Outputs ||
                    this.Outputs != null &&
                    input.Outputs != null &&
                    this.Outputs.SequenceEqual(input.Outputs)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Inputs != null)
                    hashCode = hashCode * 59 + this.Inputs.GetHashCode();
                if (this.DataInputs != null)
                    hashCode = hashCode * 59 + this.DataInputs.GetHashCode();
                if (this.Outputs != null)
                    hashCode = hashCode * 59 + this.Outputs.GetHashCode();
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
