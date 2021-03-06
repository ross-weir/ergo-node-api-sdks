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
    /// SigmaBooleanAndPredicateAllOf
    /// </summary>
    [DataContract(Name = "SigmaBooleanAndPredicate_allOf")]
    public partial class SigmaBooleanAndPredicateAllOf : IEquatable<SigmaBooleanAndPredicateAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SigmaBooleanAndPredicateAllOf" /> class.
        /// </summary>
        /// <param name="args">args.</param>
        public SigmaBooleanAndPredicateAllOf(List<SigmaBoolean> args = default(List<SigmaBoolean>))
        {
            this.Args = args;
        }

        /// <summary>
        /// Gets or Sets Args
        /// </summary>
        [DataMember(Name = "args", EmitDefaultValue = false)]
        public List<SigmaBoolean> Args { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SigmaBooleanAndPredicateAllOf {\n");
            sb.Append("  Args: ").Append(Args).Append("\n");
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
            return this.Equals(input as SigmaBooleanAndPredicateAllOf);
        }

        /// <summary>
        /// Returns true if SigmaBooleanAndPredicateAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of SigmaBooleanAndPredicateAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SigmaBooleanAndPredicateAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Args == input.Args ||
                    this.Args != null &&
                    input.Args != null &&
                    this.Args.SequenceEqual(input.Args)
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
                if (this.Args != null)
                    hashCode = hashCode * 59 + this.Args.GetHashCode();
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
