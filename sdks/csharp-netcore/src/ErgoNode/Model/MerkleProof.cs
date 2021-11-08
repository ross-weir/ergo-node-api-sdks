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
    /// Merkle proof for a leaf, which is an array of bytes (e.g. a transaction identifier)
    /// </summary>
    [DataContract(Name = "MerkleProof")]
    public partial class MerkleProof : IEquatable<MerkleProof>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MerkleProof" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MerkleProof() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MerkleProof" /> class.
        /// </summary>
        /// <param name="leaf">Base16-encoded Merkle tree leaf bytes (required).</param>
        /// <param name="levels">levels (required).</param>
        public MerkleProof(string leaf = default(string), List<List> levels = default(List<List>))
        {
            // to ensure "leaf" is required (not null)
            if (leaf == null) {
                throw new ArgumentNullException("leaf is a required property for MerkleProof and cannot be null");
            }
            this.Leaf = leaf;
            // to ensure "levels" is required (not null)
            if (levels == null) {
                throw new ArgumentNullException("levels is a required property for MerkleProof and cannot be null");
            }
            this.Levels = levels;
        }

        /// <summary>
        /// Base16-encoded Merkle tree leaf bytes
        /// </summary>
        /// <value>Base16-encoded Merkle tree leaf bytes</value>
        [DataMember(Name = "leaf", IsRequired = true, EmitDefaultValue = false)]
        public string Leaf { get; set; }

        /// <summary>
        /// Gets or Sets Levels
        /// </summary>
        [DataMember(Name = "levels", IsRequired = true, EmitDefaultValue = false)]
        public List<List> Levels { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MerkleProof {\n");
            sb.Append("  Leaf: ").Append(Leaf).Append("\n");
            sb.Append("  Levels: ").Append(Levels).Append("\n");
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
            return this.Equals(input as MerkleProof);
        }

        /// <summary>
        /// Returns true if MerkleProof instances are equal
        /// </summary>
        /// <param name="input">Instance of MerkleProof to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MerkleProof input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Leaf == input.Leaf ||
                    (this.Leaf != null &&
                    this.Leaf.Equals(input.Leaf))
                ) && 
                (
                    this.Levels == input.Levels ||
                    this.Levels != null &&
                    input.Levels != null &&
                    this.Levels.SequenceEqual(input.Levels)
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
                if (this.Leaf != null)
                    hashCode = hashCode * 59 + this.Leaf.GetHashCode();
                if (this.Levels != null)
                    hashCode = hashCode * 59 + this.Levels.GetHashCode();
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
