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
    /// InlineResponse2008
    /// </summary>
    [DataContract(Name = "inline_response_200_8")]
    public partial class InlineResponse2008 : IEquatable<InlineResponse2008>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2008" /> class.
        /// </summary>
        /// <param name="tree">Base16-encoded bytes.</param>
        public InlineResponse2008(string tree = default(string))
        {
            this.Tree = tree;
        }

        /// <summary>
        /// Base16-encoded bytes
        /// </summary>
        /// <value>Base16-encoded bytes</value>
        [DataMember(Name = "tree", EmitDefaultValue = false)]
        public string Tree { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2008 {\n");
            sb.Append("  Tree: ").Append(Tree).Append("\n");
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
            return this.Equals(input as InlineResponse2008);
        }

        /// <summary>
        /// Returns true if InlineResponse2008 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse2008 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2008 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Tree == input.Tree ||
                    (this.Tree != null &&
                    this.Tree.Equals(input.Tree))
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
                if (this.Tree != null)
                    hashCode = hashCode * 59 + this.Tree.GetHashCode();
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
