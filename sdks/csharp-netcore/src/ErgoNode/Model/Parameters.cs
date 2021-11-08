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
    /// Parameters
    /// </summary>
    [DataContract(Name = "Parameters")]
    public partial class Parameters : IEquatable<Parameters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Parameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Parameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Parameters" /> class.
        /// </summary>
        /// <param name="height">Height when current parameters were considered(not actual height). Can be &#39;0&#39; if state is empty (required).</param>
        /// <param name="storageFeeFactor">Storage fee coefficient (per byte per storage period ~4 years) (required).</param>
        /// <param name="minValuePerByte">Minimum value per byte of an output (required).</param>
        /// <param name="maxBlockSize">Maximum block size (in bytes) (required).</param>
        /// <param name="maxBlockCost">Maximum cumulative computational cost of input scripts in block transactions (required).</param>
        /// <param name="blockVersion">Ergo blockchain protocol version (required).</param>
        /// <param name="tokenAccessCost">Validation cost of a single token (required).</param>
        /// <param name="inputCost">Validation cost per one transaction input (required).</param>
        /// <param name="dataInputCost">Validation cost per one data input (required).</param>
        /// <param name="outputCost">Validation cost per one transaction output (required).</param>
        public Parameters(int height = default(int), int storageFeeFactor = default(int), int minValuePerByte = default(int), int maxBlockSize = default(int), int maxBlockCost = default(int), int blockVersion = default(int), int tokenAccessCost = default(int), int inputCost = default(int), int dataInputCost = default(int), int outputCost = default(int))
        {
            this.Height = height;
            this.StorageFeeFactor = storageFeeFactor;
            this.MinValuePerByte = minValuePerByte;
            this.MaxBlockSize = maxBlockSize;
            this.MaxBlockCost = maxBlockCost;
            this.BlockVersion = blockVersion;
            this.TokenAccessCost = tokenAccessCost;
            this.InputCost = inputCost;
            this.DataInputCost = dataInputCost;
            this.OutputCost = outputCost;
        }

        /// <summary>
        /// Height when current parameters were considered(not actual height). Can be &#39;0&#39; if state is empty
        /// </summary>
        /// <value>Height when current parameters were considered(not actual height). Can be &#39;0&#39; if state is empty</value>
        [DataMember(Name = "height", IsRequired = true, EmitDefaultValue = false)]
        public int Height { get; set; }

        /// <summary>
        /// Storage fee coefficient (per byte per storage period ~4 years)
        /// </summary>
        /// <value>Storage fee coefficient (per byte per storage period ~4 years)</value>
        [DataMember(Name = "storageFeeFactor", IsRequired = true, EmitDefaultValue = false)]
        public int StorageFeeFactor { get; set; }

        /// <summary>
        /// Minimum value per byte of an output
        /// </summary>
        /// <value>Minimum value per byte of an output</value>
        [DataMember(Name = "minValuePerByte", IsRequired = true, EmitDefaultValue = false)]
        public int MinValuePerByte { get; set; }

        /// <summary>
        /// Maximum block size (in bytes)
        /// </summary>
        /// <value>Maximum block size (in bytes)</value>
        [DataMember(Name = "maxBlockSize", IsRequired = true, EmitDefaultValue = false)]
        public int MaxBlockSize { get; set; }

        /// <summary>
        /// Maximum cumulative computational cost of input scripts in block transactions
        /// </summary>
        /// <value>Maximum cumulative computational cost of input scripts in block transactions</value>
        [DataMember(Name = "maxBlockCost", IsRequired = true, EmitDefaultValue = false)]
        public int MaxBlockCost { get; set; }

        /// <summary>
        /// Ergo blockchain protocol version
        /// </summary>
        /// <value>Ergo blockchain protocol version</value>
        [DataMember(Name = "blockVersion", IsRequired = true, EmitDefaultValue = false)]
        public int BlockVersion { get; set; }

        /// <summary>
        /// Validation cost of a single token
        /// </summary>
        /// <value>Validation cost of a single token</value>
        [DataMember(Name = "tokenAccessCost", IsRequired = true, EmitDefaultValue = false)]
        public int TokenAccessCost { get; set; }

        /// <summary>
        /// Validation cost per one transaction input
        /// </summary>
        /// <value>Validation cost per one transaction input</value>
        [DataMember(Name = "inputCost", IsRequired = true, EmitDefaultValue = false)]
        public int InputCost { get; set; }

        /// <summary>
        /// Validation cost per one data input
        /// </summary>
        /// <value>Validation cost per one data input</value>
        [DataMember(Name = "dataInputCost", IsRequired = true, EmitDefaultValue = false)]
        public int DataInputCost { get; set; }

        /// <summary>
        /// Validation cost per one transaction output
        /// </summary>
        /// <value>Validation cost per one transaction output</value>
        [DataMember(Name = "outputCost", IsRequired = true, EmitDefaultValue = false)]
        public int OutputCost { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Parameters {\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  StorageFeeFactor: ").Append(StorageFeeFactor).Append("\n");
            sb.Append("  MinValuePerByte: ").Append(MinValuePerByte).Append("\n");
            sb.Append("  MaxBlockSize: ").Append(MaxBlockSize).Append("\n");
            sb.Append("  MaxBlockCost: ").Append(MaxBlockCost).Append("\n");
            sb.Append("  BlockVersion: ").Append(BlockVersion).Append("\n");
            sb.Append("  TokenAccessCost: ").Append(TokenAccessCost).Append("\n");
            sb.Append("  InputCost: ").Append(InputCost).Append("\n");
            sb.Append("  DataInputCost: ").Append(DataInputCost).Append("\n");
            sb.Append("  OutputCost: ").Append(OutputCost).Append("\n");
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
            return this.Equals(input as Parameters);
        }

        /// <summary>
        /// Returns true if Parameters instances are equal
        /// </summary>
        /// <param name="input">Instance of Parameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Parameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Height == input.Height ||
                    this.Height.Equals(input.Height)
                ) && 
                (
                    this.StorageFeeFactor == input.StorageFeeFactor ||
                    this.StorageFeeFactor.Equals(input.StorageFeeFactor)
                ) && 
                (
                    this.MinValuePerByte == input.MinValuePerByte ||
                    this.MinValuePerByte.Equals(input.MinValuePerByte)
                ) && 
                (
                    this.MaxBlockSize == input.MaxBlockSize ||
                    this.MaxBlockSize.Equals(input.MaxBlockSize)
                ) && 
                (
                    this.MaxBlockCost == input.MaxBlockCost ||
                    this.MaxBlockCost.Equals(input.MaxBlockCost)
                ) && 
                (
                    this.BlockVersion == input.BlockVersion ||
                    this.BlockVersion.Equals(input.BlockVersion)
                ) && 
                (
                    this.TokenAccessCost == input.TokenAccessCost ||
                    this.TokenAccessCost.Equals(input.TokenAccessCost)
                ) && 
                (
                    this.InputCost == input.InputCost ||
                    this.InputCost.Equals(input.InputCost)
                ) && 
                (
                    this.DataInputCost == input.DataInputCost ||
                    this.DataInputCost.Equals(input.DataInputCost)
                ) && 
                (
                    this.OutputCost == input.OutputCost ||
                    this.OutputCost.Equals(input.OutputCost)
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
                hashCode = hashCode * 59 + this.Height.GetHashCode();
                hashCode = hashCode * 59 + this.StorageFeeFactor.GetHashCode();
                hashCode = hashCode * 59 + this.MinValuePerByte.GetHashCode();
                hashCode = hashCode * 59 + this.MaxBlockSize.GetHashCode();
                hashCode = hashCode * 59 + this.MaxBlockCost.GetHashCode();
                hashCode = hashCode * 59 + this.BlockVersion.GetHashCode();
                hashCode = hashCode * 59 + this.TokenAccessCost.GetHashCode();
                hashCode = hashCode * 59 + this.InputCost.GetHashCode();
                hashCode = hashCode * 59 + this.DataInputCost.GetHashCode();
                hashCode = hashCode * 59 + this.OutputCost.GetHashCode();
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
            // Height (int) minimum
            if(this.Height < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Height, must be a value greater than or equal to 0.", new [] { "Height" });
            }

            // StorageFeeFactor (int) minimum
            if(this.StorageFeeFactor < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StorageFeeFactor, must be a value greater than or equal to 0.", new [] { "StorageFeeFactor" });
            }

            // MinValuePerByte (int) minimum
            if(this.MinValuePerByte < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MinValuePerByte, must be a value greater than or equal to 0.", new [] { "MinValuePerByte" });
            }

            // MaxBlockSize (int) minimum
            if(this.MaxBlockSize < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaxBlockSize, must be a value greater than or equal to 0.", new [] { "MaxBlockSize" });
            }

            // MaxBlockCost (int) minimum
            if(this.MaxBlockCost < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaxBlockCost, must be a value greater than or equal to 0.", new [] { "MaxBlockCost" });
            }

            // TokenAccessCost (int) minimum
            if(this.TokenAccessCost < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TokenAccessCost, must be a value greater than or equal to 0.", new [] { "TokenAccessCost" });
            }

            // InputCost (int) minimum
            if(this.InputCost < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InputCost, must be a value greater than or equal to 0.", new [] { "InputCost" });
            }

            // DataInputCost (int) minimum
            if(this.DataInputCost < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DataInputCost, must be a value greater than or equal to 0.", new [] { "DataInputCost" });
            }

            // OutputCost (int) minimum
            if(this.OutputCost < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OutputCost, must be a value greater than or equal to 0.", new [] { "OutputCost" });
            }

            yield break;
        }
    }

}
