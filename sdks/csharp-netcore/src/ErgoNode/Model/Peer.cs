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
    /// Peer
    /// </summary>
    [DataContract(Name = "Peer")]
    public partial class Peer : IEquatable<Peer>, IValidatableObject
    {
        /// <summary>
        /// Defines ConnectionType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ConnectionTypeEnum
        {
            /// <summary>
            /// Enum Incoming for value: Incoming
            /// </summary>
            [EnumMember(Value = "Incoming")]
            Incoming = 1,

            /// <summary>
            /// Enum Outgoing for value: Outgoing
            /// </summary>
            [EnumMember(Value = "Outgoing")]
            Outgoing = 2

        }


        /// <summary>
        /// Gets or Sets ConnectionType
        /// </summary>
        [DataMember(Name = "connectionType", EmitDefaultValue = true)]
        public ConnectionTypeEnum? ConnectionType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Peer" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Peer() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Peer" /> class.
        /// </summary>
        /// <param name="address">address (required).</param>
        /// <param name="name">name.</param>
        /// <param name="lastSeen">Basic timestamp definition.</param>
        /// <param name="connectionType">connectionType.</param>
        public Peer(string address = default(string), string name = default(string), long lastSeen = default(long), ConnectionTypeEnum? connectionType = default(ConnectionTypeEnum?))
        {
            // to ensure "address" is required (not null)
            if (address == null) {
                throw new ArgumentNullException("address is a required property for Peer and cannot be null");
            }
            this.Address = address;
            this.Name = name;
            this.LastSeen = lastSeen;
            this.ConnectionType = connectionType;
        }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", IsRequired = true, EmitDefaultValue = false)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Basic timestamp definition
        /// </summary>
        /// <value>Basic timestamp definition</value>
        [DataMember(Name = "lastSeen", EmitDefaultValue = false)]
        public long LastSeen { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Peer {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  LastSeen: ").Append(LastSeen).Append("\n");
            sb.Append("  ConnectionType: ").Append(ConnectionType).Append("\n");
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
            return this.Equals(input as Peer);
        }

        /// <summary>
        /// Returns true if Peer instances are equal
        /// </summary>
        /// <param name="input">Instance of Peer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Peer input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.LastSeen == input.LastSeen ||
                    this.LastSeen.Equals(input.LastSeen)
                ) && 
                (
                    this.ConnectionType == input.ConnectionType ||
                    this.ConnectionType.Equals(input.ConnectionType)
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
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.LastSeen.GetHashCode();
                hashCode = hashCode * 59 + this.ConnectionType.GetHashCode();
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
