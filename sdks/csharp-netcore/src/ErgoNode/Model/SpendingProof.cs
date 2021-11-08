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
    /// Spending proof for transaction input
    /// </summary>
    [DataContract(Name = "SpendingProof")]
    public partial class SpendingProof : IEquatable<SpendingProof>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpendingProof" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SpendingProof() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SpendingProof" /> class.
        /// </summary>
        /// <param name="proofBytes">Base16-encoded spending proofs (required).</param>
        /// <param name="extension">Variables to be put into context (required).</param>
        public SpendingProof(string proofBytes = default(string), Dictionary<string, string> extension = default(Dictionary<string, string>))
        {
            // to ensure "proofBytes" is required (not null)
            if (proofBytes == null) {
                throw new ArgumentNullException("proofBytes is a required property for SpendingProof and cannot be null");
            }
            this.ProofBytes = proofBytes;
            // to ensure "extension" is required (not null)
            if (extension == null) {
                throw new ArgumentNullException("extension is a required property for SpendingProof and cannot be null");
            }
            this.Extension = extension;
        }

        /// <summary>
        /// Base16-encoded spending proofs
        /// </summary>
        /// <value>Base16-encoded spending proofs</value>
        [DataMember(Name = "proofBytes", IsRequired = true, EmitDefaultValue = false)]
        public string ProofBytes { get; set; }

        /// <summary>
        /// Variables to be put into context
        /// </summary>
        /// <value>Variables to be put into context</value>
        [DataMember(Name = "extension", IsRequired = true, EmitDefaultValue = false)]
        public Dictionary<string, string> Extension { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SpendingProof {\n");
            sb.Append("  ProofBytes: ").Append(ProofBytes).Append("\n");
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
            return this.Equals(input as SpendingProof);
        }

        /// <summary>
        /// Returns true if SpendingProof instances are equal
        /// </summary>
        /// <param name="input">Instance of SpendingProof to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SpendingProof input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProofBytes == input.ProofBytes ||
                    (this.ProofBytes != null &&
                    this.ProofBytes.Equals(input.ProofBytes))
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
                if (this.ProofBytes != null)
                    hashCode = hashCode * 59 + this.ProofBytes.GetHashCode();
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
