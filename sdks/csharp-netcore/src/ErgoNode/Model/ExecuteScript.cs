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
    /// ExecuteScript
    /// </summary>
    [DataContract(Name = "ExecuteScript")]
    public partial class ExecuteScript : IEquatable<ExecuteScript>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteScript" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExecuteScript() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteScript" /> class.
        /// </summary>
        /// <param name="script">Sigma script to be executed (required).</param>
        /// <param name="namedConstants">Environment for compiler (required).</param>
        /// <param name="context">context (required).</param>
        public ExecuteScript(string script = default(string), Object namedConstants = default(Object), ErgoLikeContext context = default(ErgoLikeContext))
        {
            // to ensure "script" is required (not null)
            if (script == null) {
                throw new ArgumentNullException("script is a required property for ExecuteScript and cannot be null");
            }
            this.Script = script;
            // to ensure "namedConstants" is required (not null)
            if (namedConstants == null) {
                throw new ArgumentNullException("namedConstants is a required property for ExecuteScript and cannot be null");
            }
            this.NamedConstants = namedConstants;
            // to ensure "context" is required (not null)
            if (context == null) {
                throw new ArgumentNullException("context is a required property for ExecuteScript and cannot be null");
            }
            this.Context = context;
        }

        /// <summary>
        /// Sigma script to be executed
        /// </summary>
        /// <value>Sigma script to be executed</value>
        [DataMember(Name = "script", IsRequired = true, EmitDefaultValue = false)]
        public string Script { get; set; }

        /// <summary>
        /// Environment for compiler
        /// </summary>
        /// <value>Environment for compiler</value>
        [DataMember(Name = "namedConstants", IsRequired = true, EmitDefaultValue = true)]
        public Object NamedConstants { get; set; }

        /// <summary>
        /// Gets or Sets Context
        /// </summary>
        [DataMember(Name = "context", IsRequired = true, EmitDefaultValue = false)]
        public ErgoLikeContext Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExecuteScript {\n");
            sb.Append("  Script: ").Append(Script).Append("\n");
            sb.Append("  NamedConstants: ").Append(NamedConstants).Append("\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
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
            return this.Equals(input as ExecuteScript);
        }

        /// <summary>
        /// Returns true if ExecuteScript instances are equal
        /// </summary>
        /// <param name="input">Instance of ExecuteScript to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExecuteScript input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Script == input.Script ||
                    (this.Script != null &&
                    this.Script.Equals(input.Script))
                ) && 
                (
                    this.NamedConstants == input.NamedConstants ||
                    (this.NamedConstants != null &&
                    this.NamedConstants.Equals(input.NamedConstants))
                ) && 
                (
                    this.Context == input.Context ||
                    (this.Context != null &&
                    this.Context.Equals(input.Context))
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
                if (this.Script != null)
                    hashCode = hashCode * 59 + this.Script.GetHashCode();
                if (this.NamedConstants != null)
                    hashCode = hashCode * 59 + this.NamedConstants.GetHashCode();
                if (this.Context != null)
                    hashCode = hashCode * 59 + this.Context.GetHashCode();
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