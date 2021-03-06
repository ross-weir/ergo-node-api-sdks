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
    /// ErgoTransactionUnsignedInput
    /// </summary>
    [DataContract(Name = "ErgoTransactionUnsignedInput")]
    public partial class ErgoTransactionUnsignedInput : IEquatable<ErgoTransactionUnsignedInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErgoTransactionUnsignedInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ErgoTransactionUnsignedInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ErgoTransactionUnsignedInput" /> class.
        /// </summary>
        /// <param name="boxId">Base16-encoded transaction box id bytes. Should be 32 bytes long (required).</param>
        /// <param name="extension">extension.</param>
        public ErgoTransactionUnsignedInput(string boxId = default(string), Dictionary<string, string> extension = default(Dictionary<string, string>))
        {
            // to ensure "boxId" is required (not null)
            if (boxId == null) {
                throw new ArgumentNullException("boxId is a required property for ErgoTransactionUnsignedInput and cannot be null");
            }
            this.BoxId = boxId;
            this.Extension = extension;
        }

        /// <summary>
        /// Base16-encoded transaction box id bytes. Should be 32 bytes long
        /// </summary>
        /// <value>Base16-encoded transaction box id bytes. Should be 32 bytes long</value>
        [DataMember(Name = "boxId", IsRequired = true, EmitDefaultValue = false)]
        public string BoxId { get; set; }

        /// <summary>
        /// Gets or Sets Extension
        /// </summary>
        [DataMember(Name = "extension", EmitDefaultValue = false)]
        public Dictionary<string, string> Extension { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ErgoTransactionUnsignedInput {\n");
            sb.Append("  BoxId: ").Append(BoxId).Append("\n");
            sb.Append("  Extension: ").Append(Extension).Append("\n");
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
            return this.Equals(input as ErgoTransactionUnsignedInput);
        }

        /// <summary>
        /// Returns true if ErgoTransactionUnsignedInput instances are equal
        /// </summary>
        /// <param name="input">Instance of ErgoTransactionUnsignedInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ErgoTransactionUnsignedInput input)
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
                    this.Extension == input.Extension ||
                    this.Extension != null &&
                    input.Extension != null &&
                    this.Extension.SequenceEqual(input.Extension)
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
                if (this.Extension != null)
                    hashCode = hashCode * 59 + this.Extension.GetHashCode();
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
