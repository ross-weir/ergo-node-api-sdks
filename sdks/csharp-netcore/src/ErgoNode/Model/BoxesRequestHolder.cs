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
    /// Holds request for wallet boxes
    /// </summary>
    [DataContract(Name = "BoxesRequestHolder")]
    public partial class BoxesRequestHolder : IEquatable<BoxesRequestHolder>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BoxesRequestHolder" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BoxesRequestHolder() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BoxesRequestHolder" /> class.
        /// </summary>
        /// <param name="targetAssets">Target assets (required).</param>
        /// <param name="targetBalance">Target balance (required).</param>
        public BoxesRequestHolder(List<List> targetAssets = default(List<List>), long targetBalance = default(long))
        {
            // to ensure "targetAssets" is required (not null)
            if (targetAssets == null) {
                throw new ArgumentNullException("targetAssets is a required property for BoxesRequestHolder and cannot be null");
            }
            this.TargetAssets = targetAssets;
            this.TargetBalance = targetBalance;
        }

        /// <summary>
        /// Target assets
        /// </summary>
        /// <value>Target assets</value>
        [DataMember(Name = "targetAssets", IsRequired = true, EmitDefaultValue = false)]
        public List<List> TargetAssets { get; set; }

        /// <summary>
        /// Target balance
        /// </summary>
        /// <value>Target balance</value>
        [DataMember(Name = "targetBalance", IsRequired = true, EmitDefaultValue = false)]
        public long TargetBalance { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BoxesRequestHolder {\n");
            sb.Append("  TargetAssets: ").Append(TargetAssets).Append("\n");
            sb.Append("  TargetBalance: ").Append(TargetBalance).Append("\n");
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
            return this.Equals(input as BoxesRequestHolder);
        }

        /// <summary>
        /// Returns true if BoxesRequestHolder instances are equal
        /// </summary>
        /// <param name="input">Instance of BoxesRequestHolder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BoxesRequestHolder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TargetAssets == input.TargetAssets ||
                    this.TargetAssets != null &&
                    input.TargetAssets != null &&
                    this.TargetAssets.SequenceEqual(input.TargetAssets)
                ) && 
                (
                    this.TargetBalance == input.TargetBalance ||
                    this.TargetBalance.Equals(input.TargetBalance)
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
                if (this.TargetAssets != null)
                    hashCode = hashCode * 59 + this.TargetAssets.GetHashCode();
                hashCode = hashCode * 59 + this.TargetBalance.GetHashCode();
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
