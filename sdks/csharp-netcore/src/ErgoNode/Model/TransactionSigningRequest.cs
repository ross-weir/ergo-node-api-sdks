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
    /// A request to sign a transaction with secrets provided
    /// </summary>
    [DataContract(Name = "TransactionSigningRequest")]
    public partial class TransactionSigningRequest : IEquatable<TransactionSigningRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionSigningRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionSigningRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionSigningRequest" /> class.
        /// </summary>
        /// <param name="tx">tx (required).</param>
        /// <param name="inputsRaw">Optional list of inputs to be used in serialized form.</param>
        /// <param name="dataInputsRaw">Optional list of inputs to be used in serialized form.</param>
        /// <param name="hints">hints.</param>
        /// <param name="secrets">secrets (required).</param>
        public TransactionSigningRequest(UnsignedErgoTransaction tx = default(UnsignedErgoTransaction), List<string> inputsRaw = default(List<string>), List<string> dataInputsRaw = default(List<string>), TransactionHintsBag hints = default(TransactionHintsBag), TransactionSigningRequestSecrets secrets = default(TransactionSigningRequestSecrets))
        {
            // to ensure "tx" is required (not null)
            if (tx == null) {
                throw new ArgumentNullException("tx is a required property for TransactionSigningRequest and cannot be null");
            }
            this.Tx = tx;
            // to ensure "secrets" is required (not null)
            if (secrets == null) {
                throw new ArgumentNullException("secrets is a required property for TransactionSigningRequest and cannot be null");
            }
            this.Secrets = secrets;
            this.InputsRaw = inputsRaw;
            this.DataInputsRaw = dataInputsRaw;
            this.Hints = hints;
        }

        /// <summary>
        /// Gets or Sets Tx
        /// </summary>
        [DataMember(Name = "tx", IsRequired = true, EmitDefaultValue = false)]
        public UnsignedErgoTransaction Tx { get; set; }

        /// <summary>
        /// Optional list of inputs to be used in serialized form
        /// </summary>
        /// <value>Optional list of inputs to be used in serialized form</value>
        [DataMember(Name = "inputsRaw", EmitDefaultValue = false)]
        public List<string> InputsRaw { get; set; }

        /// <summary>
        /// Optional list of inputs to be used in serialized form
        /// </summary>
        /// <value>Optional list of inputs to be used in serialized form</value>
        [DataMember(Name = "dataInputsRaw", EmitDefaultValue = false)]
        public List<string> DataInputsRaw { get; set; }

        /// <summary>
        /// Gets or Sets Hints
        /// </summary>
        [DataMember(Name = "hints", EmitDefaultValue = false)]
        public TransactionHintsBag Hints { get; set; }

        /// <summary>
        /// Gets or Sets Secrets
        /// </summary>
        [DataMember(Name = "secrets", IsRequired = true, EmitDefaultValue = false)]
        public TransactionSigningRequestSecrets Secrets { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionSigningRequest {\n");
            sb.Append("  Tx: ").Append(Tx).Append("\n");
            sb.Append("  InputsRaw: ").Append(InputsRaw).Append("\n");
            sb.Append("  DataInputsRaw: ").Append(DataInputsRaw).Append("\n");
            sb.Append("  Hints: ").Append(Hints).Append("\n");
            sb.Append("  Secrets: ").Append(Secrets).Append("\n");
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
            return this.Equals(input as TransactionSigningRequest);
        }

        /// <summary>
        /// Returns true if TransactionSigningRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionSigningRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionSigningRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Tx == input.Tx ||
                    (this.Tx != null &&
                    this.Tx.Equals(input.Tx))
                ) && 
                (
                    this.InputsRaw == input.InputsRaw ||
                    this.InputsRaw != null &&
                    input.InputsRaw != null &&
                    this.InputsRaw.SequenceEqual(input.InputsRaw)
                ) && 
                (
                    this.DataInputsRaw == input.DataInputsRaw ||
                    this.DataInputsRaw != null &&
                    input.DataInputsRaw != null &&
                    this.DataInputsRaw.SequenceEqual(input.DataInputsRaw)
                ) && 
                (
                    this.Hints == input.Hints ||
                    (this.Hints != null &&
                    this.Hints.Equals(input.Hints))
                ) && 
                (
                    this.Secrets == input.Secrets ||
                    (this.Secrets != null &&
                    this.Secrets.Equals(input.Secrets))
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
                if (this.Tx != null)
                    hashCode = hashCode * 59 + this.Tx.GetHashCode();
                if (this.InputsRaw != null)
                    hashCode = hashCode * 59 + this.InputsRaw.GetHashCode();
                if (this.DataInputsRaw != null)
                    hashCode = hashCode * 59 + this.DataInputsRaw.GetHashCode();
                if (this.Hints != null)
                    hashCode = hashCode * 59 + this.Hints.GetHashCode();
                if (this.Secrets != null)
                    hashCode = hashCode * 59 + this.Secrets.GetHashCode();
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
