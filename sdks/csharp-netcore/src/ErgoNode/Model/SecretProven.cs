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
    /// SecretProven
    /// </summary>
    [DataContract(Name = "SecretProven")]
    public partial class SecretProven : IEquatable<SecretProven>, IValidatableObject
    {
        /// <summary>
        /// Defines Hint
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HintEnum
        {
            /// <summary>
            /// Enum ProofReal for value: proofReal
            /// </summary>
            [EnumMember(Value = "proofReal")]
            ProofReal = 1,

            /// <summary>
            /// Enum ProofSimulated for value: proofSimulated
            /// </summary>
            [EnumMember(Value = "proofSimulated")]
            ProofSimulated = 2

        }


        /// <summary>
        /// Gets or Sets Hint
        /// </summary>
        [DataMember(Name = "hint", IsRequired = true, EmitDefaultValue = false)]
        public HintEnum Hint { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SecretProven" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SecretProven() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SecretProven" /> class.
        /// </summary>
        /// <param name="hint">hint (required).</param>
        /// <param name="challenge">challenge (required).</param>
        /// <param name="pubkey">pubkey (required).</param>
        /// <param name="proof">proof (required).</param>
        /// <param name="position">position (required).</param>
        public SecretProven(HintEnum hint = default(HintEnum), string challenge = default(string), SigmaBoolean pubkey = default(SigmaBoolean), string proof = default(string), string position = default(string))
        {
            this.Hint = hint;
            // to ensure "challenge" is required (not null)
            if (challenge == null) {
                throw new ArgumentNullException("challenge is a required property for SecretProven and cannot be null");
            }
            this.Challenge = challenge;
            // to ensure "pubkey" is required (not null)
            if (pubkey == null) {
                throw new ArgumentNullException("pubkey is a required property for SecretProven and cannot be null");
            }
            this.Pubkey = pubkey;
            // to ensure "proof" is required (not null)
            if (proof == null) {
                throw new ArgumentNullException("proof is a required property for SecretProven and cannot be null");
            }
            this.Proof = proof;
            // to ensure "position" is required (not null)
            if (position == null) {
                throw new ArgumentNullException("position is a required property for SecretProven and cannot be null");
            }
            this.Position = position;
        }

        /// <summary>
        /// Gets or Sets Challenge
        /// </summary>
        [DataMember(Name = "challenge", IsRequired = true, EmitDefaultValue = false)]
        public string Challenge { get; set; }

        /// <summary>
        /// Gets or Sets Pubkey
        /// </summary>
        [DataMember(Name = "pubkey", IsRequired = true, EmitDefaultValue = false)]
        public SigmaBoolean Pubkey { get; set; }

        /// <summary>
        /// Gets or Sets Proof
        /// </summary>
        [DataMember(Name = "proof", IsRequired = true, EmitDefaultValue = false)]
        public string Proof { get; set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name = "position", IsRequired = true, EmitDefaultValue = false)]
        public string Position { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecretProven {\n");
            sb.Append("  Hint: ").Append(Hint).Append("\n");
            sb.Append("  Challenge: ").Append(Challenge).Append("\n");
            sb.Append("  Pubkey: ").Append(Pubkey).Append("\n");
            sb.Append("  Proof: ").Append(Proof).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
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
            return this.Equals(input as SecretProven);
        }

        /// <summary>
        /// Returns true if SecretProven instances are equal
        /// </summary>
        /// <param name="input">Instance of SecretProven to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecretProven input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Hint == input.Hint ||
                    this.Hint.Equals(input.Hint)
                ) && 
                (
                    this.Challenge == input.Challenge ||
                    (this.Challenge != null &&
                    this.Challenge.Equals(input.Challenge))
                ) && 
                (
                    this.Pubkey == input.Pubkey ||
                    (this.Pubkey != null &&
                    this.Pubkey.Equals(input.Pubkey))
                ) && 
                (
                    this.Proof == input.Proof ||
                    (this.Proof != null &&
                    this.Proof.Equals(input.Proof))
                ) && 
                (
                    this.Position == input.Position ||
                    (this.Position != null &&
                    this.Position.Equals(input.Position))
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
                hashCode = hashCode * 59 + this.Hint.GetHashCode();
                if (this.Challenge != null)
                    hashCode = hashCode * 59 + this.Challenge.GetHashCode();
                if (this.Pubkey != null)
                    hashCode = hashCode * 59 + this.Pubkey.GetHashCode();
                if (this.Proof != null)
                    hashCode = hashCode * 59 + this.Proof.GetHashCode();
                if (this.Position != null)
                    hashCode = hashCode * 59 + this.Position.GetHashCode();
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