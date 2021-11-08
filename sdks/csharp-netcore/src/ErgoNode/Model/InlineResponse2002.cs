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
    /// InlineResponse2002
    /// </summary>
    [DataContract(Name = "inline_response_200_2")]
    public partial class InlineResponse2002 : IEquatable<InlineResponse2002>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2002" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InlineResponse2002() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2002" /> class.
        /// </summary>
        /// <param name="isInitialized">true if wallet is initialized, false otherwise (required).</param>
        /// <param name="isUnlocked">true if wallet is unlocked, false otherwise (required).</param>
        /// <param name="changeAddress">address to send change to. Empty when wallet is not initialized or locked. By default change address correponds to root key address, could be set via /wallet/updateChangeAddress method. (required).</param>
        /// <param name="walletHeight">last scanned height for the wallet (and external scans) (required).</param>
        /// <param name="error">last wallet error caught (required).</param>
        public InlineResponse2002(bool isInitialized = default(bool), bool isUnlocked = default(bool), string changeAddress = default(string), int walletHeight = default(int), string error = default(string))
        {
            this.IsInitialized = isInitialized;
            this.IsUnlocked = isUnlocked;
            // to ensure "changeAddress" is required (not null)
            if (changeAddress == null) {
                throw new ArgumentNullException("changeAddress is a required property for InlineResponse2002 and cannot be null");
            }
            this.ChangeAddress = changeAddress;
            this.WalletHeight = walletHeight;
            // to ensure "error" is required (not null)
            if (error == null) {
                throw new ArgumentNullException("error is a required property for InlineResponse2002 and cannot be null");
            }
            this.Error = error;
        }

        /// <summary>
        /// true if wallet is initialized, false otherwise
        /// </summary>
        /// <value>true if wallet is initialized, false otherwise</value>
        [DataMember(Name = "isInitialized", IsRequired = true, EmitDefaultValue = true)]
        public bool IsInitialized { get; set; }

        /// <summary>
        /// true if wallet is unlocked, false otherwise
        /// </summary>
        /// <value>true if wallet is unlocked, false otherwise</value>
        [DataMember(Name = "isUnlocked", IsRequired = true, EmitDefaultValue = true)]
        public bool IsUnlocked { get; set; }

        /// <summary>
        /// address to send change to. Empty when wallet is not initialized or locked. By default change address correponds to root key address, could be set via /wallet/updateChangeAddress method.
        /// </summary>
        /// <value>address to send change to. Empty when wallet is not initialized or locked. By default change address correponds to root key address, could be set via /wallet/updateChangeAddress method.</value>
        [DataMember(Name = "changeAddress", IsRequired = true, EmitDefaultValue = false)]
        public string ChangeAddress { get; set; }

        /// <summary>
        /// last scanned height for the wallet (and external scans)
        /// </summary>
        /// <value>last scanned height for the wallet (and external scans)</value>
        [DataMember(Name = "walletHeight", IsRequired = true, EmitDefaultValue = false)]
        public int WalletHeight { get; set; }

        /// <summary>
        /// last wallet error caught
        /// </summary>
        /// <value>last wallet error caught</value>
        [DataMember(Name = "error", IsRequired = true, EmitDefaultValue = false)]
        public string Error { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2002 {\n");
            sb.Append("  IsInitialized: ").Append(IsInitialized).Append("\n");
            sb.Append("  IsUnlocked: ").Append(IsUnlocked).Append("\n");
            sb.Append("  ChangeAddress: ").Append(ChangeAddress).Append("\n");
            sb.Append("  WalletHeight: ").Append(WalletHeight).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
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
            return this.Equals(input as InlineResponse2002);
        }

        /// <summary>
        /// Returns true if InlineResponse2002 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse2002 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2002 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsInitialized == input.IsInitialized ||
                    this.IsInitialized.Equals(input.IsInitialized)
                ) && 
                (
                    this.IsUnlocked == input.IsUnlocked ||
                    this.IsUnlocked.Equals(input.IsUnlocked)
                ) && 
                (
                    this.ChangeAddress == input.ChangeAddress ||
                    (this.ChangeAddress != null &&
                    this.ChangeAddress.Equals(input.ChangeAddress))
                ) && 
                (
                    this.WalletHeight == input.WalletHeight ||
                    this.WalletHeight.Equals(input.WalletHeight)
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
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
                hashCode = hashCode * 59 + this.IsInitialized.GetHashCode();
                hashCode = hashCode * 59 + this.IsUnlocked.GetHashCode();
                if (this.ChangeAddress != null)
                    hashCode = hashCode * 59 + this.ChangeAddress.GetHashCode();
                hashCode = hashCode * 59 + this.WalletHeight.GetHashCode();
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
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