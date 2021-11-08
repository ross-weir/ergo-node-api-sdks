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
    /// ScanRequest
    /// </summary>
    [DataContract(Name = "ScanRequest")]
    public partial class ScanRequest : IEquatable<ScanRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScanRequest" /> class.
        /// </summary>
        /// <param name="scanName">scanName.</param>
        /// <param name="trackingRule">trackingRule.</param>
        public ScanRequest(string scanName = default(string), ScanningPredicate trackingRule = default(ScanningPredicate))
        {
            this.ScanName = scanName;
            this.TrackingRule = trackingRule;
        }

        /// <summary>
        /// Gets or Sets ScanName
        /// </summary>
        [DataMember(Name = "scanName", EmitDefaultValue = false)]
        public string ScanName { get; set; }

        /// <summary>
        /// Gets or Sets TrackingRule
        /// </summary>
        [DataMember(Name = "trackingRule", EmitDefaultValue = false)]
        public ScanningPredicate TrackingRule { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScanRequest {\n");
            sb.Append("  ScanName: ").Append(ScanName).Append("\n");
            sb.Append("  TrackingRule: ").Append(TrackingRule).Append("\n");
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
            return this.Equals(input as ScanRequest);
        }

        /// <summary>
        /// Returns true if ScanRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ScanRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScanRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ScanName == input.ScanName ||
                    (this.ScanName != null &&
                    this.ScanName.Equals(input.ScanName))
                ) && 
                (
                    this.TrackingRule == input.TrackingRule ||
                    (this.TrackingRule != null &&
                    this.TrackingRule.Equals(input.TrackingRule))
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
                if (this.ScanName != null)
                    hashCode = hashCode * 59 + this.ScanName.GetHashCode();
                if (this.TrackingRule != null)
                    hashCode = hashCode * 59 + this.TrackingRule.GetHashCode();
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
