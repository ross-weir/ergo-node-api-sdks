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
    /// ContainsPredicateAllOf
    /// </summary>
    [DataContract(Name = "ContainsPredicate_allOf")]
    public partial class ContainsPredicateAllOf : IEquatable<ContainsPredicateAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContainsPredicateAllOf" /> class.
        /// </summary>
        /// <param name="register">register.</param>
        /// <param name="bytes">bytes.</param>
        public ContainsPredicateAllOf(string register = default(string), string bytes = default(string))
        {
            this.Register = register;
            this.Bytes = bytes;
        }

        /// <summary>
        /// Gets or Sets Register
        /// </summary>
        [DataMember(Name = "register", EmitDefaultValue = false)]
        public string Register { get; set; }

        /// <summary>
        /// Gets or Sets Bytes
        /// </summary>
        [DataMember(Name = "bytes", EmitDefaultValue = false)]
        public string Bytes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContainsPredicateAllOf {\n");
            sb.Append("  Register: ").Append(Register).Append("\n");
            sb.Append("  Bytes: ").Append(Bytes).Append("\n");
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
            return this.Equals(input as ContainsPredicateAllOf);
        }

        /// <summary>
        /// Returns true if ContainsPredicateAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of ContainsPredicateAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContainsPredicateAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Register == input.Register ||
                    (this.Register != null &&
                    this.Register.Equals(input.Register))
                ) && 
                (
                    this.Bytes == input.Bytes ||
                    (this.Bytes != null &&
                    this.Bytes.Equals(input.Bytes))
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
                if (this.Register != null)
                    hashCode = hashCode * 59 + this.Register.GetHashCode();
                if (this.Bytes != null)
                    hashCode = hashCode * 59 + this.Bytes.GetHashCode();
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