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
    /// WalletBox
    /// </summary>
    [DataContract(Name = "WalletBox")]
    public partial class WalletBox : IEquatable<WalletBox>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletBox" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WalletBox() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletBox" /> class.
        /// </summary>
        /// <param name="box">box (required).</param>
        /// <param name="confirmationsNum">Number of confirmations, if the box is included into the blockchain (required).</param>
        /// <param name="address">Encoded Ergo Address (required).</param>
        /// <param name="creationTransaction">Base16-encoded 32 byte modifier id (required).</param>
        /// <param name="spendingTransaction">Base16-encoded 32 byte modifier id (required).</param>
        /// <param name="spendingHeight">The height the box was spent at (required).</param>
        /// <param name="inclusionHeight">The height the transaction containing the box was included in a block at (required).</param>
        /// <param name="onchain">A flag signalling whether the box is created on main chain (required).</param>
        /// <param name="spent">A flag signalling whether the box was spent (required).</param>
        /// <param name="creationOutIndex">An index of a box in the creating transaction (required).</param>
        /// <param name="scans">Scan identifiers the box relates to (required).</param>
        public WalletBox(ErgoTransactionOutput box = default(ErgoTransactionOutput), int? confirmationsNum = default(int?), string address = default(string), string creationTransaction = default(string), string spendingTransaction = default(string), int? spendingHeight = default(int?), int inclusionHeight = default(int), bool onchain = default(bool), bool spent = default(bool), int creationOutIndex = default(int), List<int> scans = default(List<int>))
        {
            // to ensure "box" is required (not null)
            if (box == null) {
                throw new ArgumentNullException("box is a required property for WalletBox and cannot be null");
            }
            this.Box = box;
            // to ensure "confirmationsNum" is required (not null)
            if (confirmationsNum == null) {
                throw new ArgumentNullException("confirmationsNum is a required property for WalletBox and cannot be null");
            }
            this.ConfirmationsNum = confirmationsNum;
            // to ensure "address" is required (not null)
            if (address == null) {
                throw new ArgumentNullException("address is a required property for WalletBox and cannot be null");
            }
            this.Address = address;
            // to ensure "creationTransaction" is required (not null)
            if (creationTransaction == null) {
                throw new ArgumentNullException("creationTransaction is a required property for WalletBox and cannot be null");
            }
            this.CreationTransaction = creationTransaction;
            // to ensure "spendingTransaction" is required (not null)
            if (spendingTransaction == null) {
                throw new ArgumentNullException("spendingTransaction is a required property for WalletBox and cannot be null");
            }
            this.SpendingTransaction = spendingTransaction;
            // to ensure "spendingHeight" is required (not null)
            if (spendingHeight == null) {
                throw new ArgumentNullException("spendingHeight is a required property for WalletBox and cannot be null");
            }
            this.SpendingHeight = spendingHeight;
            this.InclusionHeight = inclusionHeight;
            this.Onchain = onchain;
            this.Spent = spent;
            this.CreationOutIndex = creationOutIndex;
            // to ensure "scans" is required (not null)
            if (scans == null) {
                throw new ArgumentNullException("scans is a required property for WalletBox and cannot be null");
            }
            this.Scans = scans;
        }

        /// <summary>
        /// Gets or Sets Box
        /// </summary>
        [DataMember(Name = "box", IsRequired = true, EmitDefaultValue = false)]
        public ErgoTransactionOutput Box { get; set; }

        /// <summary>
        /// Number of confirmations, if the box is included into the blockchain
        /// </summary>
        /// <value>Number of confirmations, if the box is included into the blockchain</value>
        [DataMember(Name = "confirmationsNum", IsRequired = true, EmitDefaultValue = true)]
        public int? ConfirmationsNum { get; set; }

        /// <summary>
        /// Encoded Ergo Address
        /// </summary>
        /// <value>Encoded Ergo Address</value>
        [DataMember(Name = "address", IsRequired = true, EmitDefaultValue = false)]
        public string Address { get; set; }

        /// <summary>
        /// Base16-encoded 32 byte modifier id
        /// </summary>
        /// <value>Base16-encoded 32 byte modifier id</value>
        [DataMember(Name = "creationTransaction", IsRequired = true, EmitDefaultValue = false)]
        public string CreationTransaction { get; set; }

        /// <summary>
        /// Base16-encoded 32 byte modifier id
        /// </summary>
        /// <value>Base16-encoded 32 byte modifier id</value>
        [DataMember(Name = "spendingTransaction", IsRequired = true, EmitDefaultValue = false)]
        public string SpendingTransaction { get; set; }

        /// <summary>
        /// The height the box was spent at
        /// </summary>
        /// <value>The height the box was spent at</value>
        [DataMember(Name = "spendingHeight", IsRequired = true, EmitDefaultValue = true)]
        public int? SpendingHeight { get; set; }

        /// <summary>
        /// The height the transaction containing the box was included in a block at
        /// </summary>
        /// <value>The height the transaction containing the box was included in a block at</value>
        [DataMember(Name = "inclusionHeight", IsRequired = true, EmitDefaultValue = false)]
        public int InclusionHeight { get; set; }

        /// <summary>
        /// A flag signalling whether the box is created on main chain
        /// </summary>
        /// <value>A flag signalling whether the box is created on main chain</value>
        [DataMember(Name = "onchain", IsRequired = true, EmitDefaultValue = true)]
        public bool Onchain { get; set; }

        /// <summary>
        /// A flag signalling whether the box was spent
        /// </summary>
        /// <value>A flag signalling whether the box was spent</value>
        [DataMember(Name = "spent", IsRequired = true, EmitDefaultValue = true)]
        public bool Spent { get; set; }

        /// <summary>
        /// An index of a box in the creating transaction
        /// </summary>
        /// <value>An index of a box in the creating transaction</value>
        [DataMember(Name = "creationOutIndex", IsRequired = true, EmitDefaultValue = false)]
        public int CreationOutIndex { get; set; }

        /// <summary>
        /// Scan identifiers the box relates to
        /// </summary>
        /// <value>Scan identifiers the box relates to</value>
        [DataMember(Name = "scans", IsRequired = true, EmitDefaultValue = false)]
        public List<int> Scans { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WalletBox {\n");
            sb.Append("  Box: ").Append(Box).Append("\n");
            sb.Append("  ConfirmationsNum: ").Append(ConfirmationsNum).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  CreationTransaction: ").Append(CreationTransaction).Append("\n");
            sb.Append("  SpendingTransaction: ").Append(SpendingTransaction).Append("\n");
            sb.Append("  SpendingHeight: ").Append(SpendingHeight).Append("\n");
            sb.Append("  InclusionHeight: ").Append(InclusionHeight).Append("\n");
            sb.Append("  Onchain: ").Append(Onchain).Append("\n");
            sb.Append("  Spent: ").Append(Spent).Append("\n");
            sb.Append("  CreationOutIndex: ").Append(CreationOutIndex).Append("\n");
            sb.Append("  Scans: ").Append(Scans).Append("\n");
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
            return this.Equals(input as WalletBox);
        }

        /// <summary>
        /// Returns true if WalletBox instances are equal
        /// </summary>
        /// <param name="input">Instance of WalletBox to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WalletBox input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Box == input.Box ||
                    (this.Box != null &&
                    this.Box.Equals(input.Box))
                ) && 
                (
                    this.ConfirmationsNum == input.ConfirmationsNum ||
                    (this.ConfirmationsNum != null &&
                    this.ConfirmationsNum.Equals(input.ConfirmationsNum))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.CreationTransaction == input.CreationTransaction ||
                    (this.CreationTransaction != null &&
                    this.CreationTransaction.Equals(input.CreationTransaction))
                ) && 
                (
                    this.SpendingTransaction == input.SpendingTransaction ||
                    (this.SpendingTransaction != null &&
                    this.SpendingTransaction.Equals(input.SpendingTransaction))
                ) && 
                (
                    this.SpendingHeight == input.SpendingHeight ||
                    (this.SpendingHeight != null &&
                    this.SpendingHeight.Equals(input.SpendingHeight))
                ) && 
                (
                    this.InclusionHeight == input.InclusionHeight ||
                    this.InclusionHeight.Equals(input.InclusionHeight)
                ) && 
                (
                    this.Onchain == input.Onchain ||
                    this.Onchain.Equals(input.Onchain)
                ) && 
                (
                    this.Spent == input.Spent ||
                    this.Spent.Equals(input.Spent)
                ) && 
                (
                    this.CreationOutIndex == input.CreationOutIndex ||
                    this.CreationOutIndex.Equals(input.CreationOutIndex)
                ) && 
                (
                    this.Scans == input.Scans ||
                    this.Scans != null &&
                    input.Scans != null &&
                    this.Scans.SequenceEqual(input.Scans)
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
                if (this.Box != null)
                    hashCode = hashCode * 59 + this.Box.GetHashCode();
                if (this.ConfirmationsNum != null)
                    hashCode = hashCode * 59 + this.ConfirmationsNum.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.CreationTransaction != null)
                    hashCode = hashCode * 59 + this.CreationTransaction.GetHashCode();
                if (this.SpendingTransaction != null)
                    hashCode = hashCode * 59 + this.SpendingTransaction.GetHashCode();
                if (this.SpendingHeight != null)
                    hashCode = hashCode * 59 + this.SpendingHeight.GetHashCode();
                hashCode = hashCode * 59 + this.InclusionHeight.GetHashCode();
                hashCode = hashCode * 59 + this.Onchain.GetHashCode();
                hashCode = hashCode * 59 + this.Spent.GetHashCode();
                hashCode = hashCode * 59 + this.CreationOutIndex.GetHashCode();
                if (this.Scans != null)
                    hashCode = hashCode * 59 + this.Scans.GetHashCode();
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
            // ConfirmationsNum (int?) minimum
            if(this.ConfirmationsNum < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ConfirmationsNum, must be a value greater than or equal to 0.", new [] { "ConfirmationsNum" });
            }

            // SpendingHeight (int?) minimum
            if(this.SpendingHeight < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SpendingHeight, must be a value greater than or equal to 0.", new [] { "SpendingHeight" });
            }

            // InclusionHeight (int) minimum
            if(this.InclusionHeight < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InclusionHeight, must be a value greater than or equal to 0.", new [] { "InclusionHeight" });
            }

            yield break;
        }
    }

}