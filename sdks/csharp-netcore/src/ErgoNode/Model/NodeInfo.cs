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
    /// NodeInfo
    /// </summary>
    [DataContract(Name = "NodeInfo")]
    public partial class NodeInfo : IEquatable<NodeInfo>, IValidatableObject
    {
        /// <summary>
        /// Defines StateType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateTypeEnum
        {
            /// <summary>
            /// Enum Digest for value: digest
            /// </summary>
            [EnumMember(Value = "digest")]
            Digest = 1,

            /// <summary>
            /// Enum Utxo for value: utxo
            /// </summary>
            [EnumMember(Value = "utxo")]
            Utxo = 2

        }


        /// <summary>
        /// Gets or Sets StateType
        /// </summary>
        [DataMember(Name = "stateType", IsRequired = true, EmitDefaultValue = false)]
        public StateTypeEnum StateType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NodeInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeInfo" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="appVersion">appVersion (required).</param>
        /// <param name="fullHeight">Can be &#39;null&#39; if state is empty (no full block is applied since node launch) (required).</param>
        /// <param name="headersHeight">Can be &#39;null&#39; if state is empty (no header applied since node launch) (required).</param>
        /// <param name="bestFullHeaderId">Can be &#39;null&#39; if no full block is applied since node launch (required).</param>
        /// <param name="previousFullHeaderId">Can be &#39;null&#39; if no full block is applied since node launch (required).</param>
        /// <param name="bestHeaderId">Can be &#39;null&#39; if no header applied since node launch (required).</param>
        /// <param name="stateRoot">Can be &#39;null&#39; if state is empty (no full block is applied since node launch) (required).</param>
        /// <param name="stateType">stateType (required).</param>
        /// <param name="stateVersion">Can be &#39;null&#39; if no full block is applied since node launch (required).</param>
        /// <param name="isMining">isMining (required).</param>
        /// <param name="peersCount">Number of connected peers (required).</param>
        /// <param name="unconfirmedCount">Current unconfirmed transactions count (required).</param>
        /// <param name="difficulty">Difficulty on current bestFullHeaderId. Can be &#39;null&#39; if no full block is applied since node launch (required).</param>
        /// <param name="currentTime">Current internal node time (required).</param>
        /// <param name="launchTime">Time when the node was started (required).</param>
        /// <param name="headersScore">Can be &#39;null&#39; if no headers is applied since node launch (required).</param>
        /// <param name="fullBlocksScore">Can be &#39;null&#39; if no full block is applied since node launch (required).</param>
        /// <param name="genesisBlockId">Can be &#39;null&#39; if genesis blocks is not produced yet (required).</param>
        /// <param name="parameters">parameters (required).</param>
        public NodeInfo(string name = default(string), string appVersion = default(string), int? fullHeight = default(int?), int? headersHeight = default(int?), string bestFullHeaderId = default(string), string previousFullHeaderId = default(string), string bestHeaderId = default(string), string stateRoot = default(string), StateTypeEnum stateType = default(StateTypeEnum), string stateVersion = default(string), bool isMining = default(bool), int peersCount = default(int), int unconfirmedCount = default(int), int? difficulty = default(int?), long currentTime = default(long), long launchTime = default(long), int? headersScore = default(int?), int? fullBlocksScore = default(int?), string genesisBlockId = default(string), Parameters parameters = default(Parameters))
        {
            // to ensure "name" is required (not null)
            if (name == null) {
                throw new ArgumentNullException("name is a required property for NodeInfo and cannot be null");
            }
            this.Name = name;
            // to ensure "appVersion" is required (not null)
            if (appVersion == null) {
                throw new ArgumentNullException("appVersion is a required property for NodeInfo and cannot be null");
            }
            this.AppVersion = appVersion;
            // to ensure "fullHeight" is required (not null)
            if (fullHeight == null) {
                throw new ArgumentNullException("fullHeight is a required property for NodeInfo and cannot be null");
            }
            this.FullHeight = fullHeight;
            // to ensure "headersHeight" is required (not null)
            if (headersHeight == null) {
                throw new ArgumentNullException("headersHeight is a required property for NodeInfo and cannot be null");
            }
            this.HeadersHeight = headersHeight;
            // to ensure "bestFullHeaderId" is required (not null)
            if (bestFullHeaderId == null) {
                throw new ArgumentNullException("bestFullHeaderId is a required property for NodeInfo and cannot be null");
            }
            this.BestFullHeaderId = bestFullHeaderId;
            // to ensure "previousFullHeaderId" is required (not null)
            if (previousFullHeaderId == null) {
                throw new ArgumentNullException("previousFullHeaderId is a required property for NodeInfo and cannot be null");
            }
            this.PreviousFullHeaderId = previousFullHeaderId;
            // to ensure "bestHeaderId" is required (not null)
            if (bestHeaderId == null) {
                throw new ArgumentNullException("bestHeaderId is a required property for NodeInfo and cannot be null");
            }
            this.BestHeaderId = bestHeaderId;
            // to ensure "stateRoot" is required (not null)
            if (stateRoot == null) {
                throw new ArgumentNullException("stateRoot is a required property for NodeInfo and cannot be null");
            }
            this.StateRoot = stateRoot;
            this.StateType = stateType;
            // to ensure "stateVersion" is required (not null)
            if (stateVersion == null) {
                throw new ArgumentNullException("stateVersion is a required property for NodeInfo and cannot be null");
            }
            this.StateVersion = stateVersion;
            this.IsMining = isMining;
            this.PeersCount = peersCount;
            this.UnconfirmedCount = unconfirmedCount;
            // to ensure "difficulty" is required (not null)
            if (difficulty == null) {
                throw new ArgumentNullException("difficulty is a required property for NodeInfo and cannot be null");
            }
            this.Difficulty = difficulty;
            this.CurrentTime = currentTime;
            this.LaunchTime = launchTime;
            // to ensure "headersScore" is required (not null)
            if (headersScore == null) {
                throw new ArgumentNullException("headersScore is a required property for NodeInfo and cannot be null");
            }
            this.HeadersScore = headersScore;
            // to ensure "fullBlocksScore" is required (not null)
            if (fullBlocksScore == null) {
                throw new ArgumentNullException("fullBlocksScore is a required property for NodeInfo and cannot be null");
            }
            this.FullBlocksScore = fullBlocksScore;
            // to ensure "genesisBlockId" is required (not null)
            if (genesisBlockId == null) {
                throw new ArgumentNullException("genesisBlockId is a required property for NodeInfo and cannot be null");
            }
            this.GenesisBlockId = genesisBlockId;
            // to ensure "parameters" is required (not null)
            if (parameters == null) {
                throw new ArgumentNullException("parameters is a required property for NodeInfo and cannot be null");
            }
            this.Parameters = parameters;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets AppVersion
        /// </summary>
        [DataMember(Name = "appVersion", IsRequired = true, EmitDefaultValue = false)]
        public string AppVersion { get; set; }

        /// <summary>
        /// Can be &#39;null&#39; if state is empty (no full block is applied since node launch)
        /// </summary>
        /// <value>Can be &#39;null&#39; if state is empty (no full block is applied since node launch)</value>
        [DataMember(Name = "fullHeight", IsRequired = true, EmitDefaultValue = true)]
        public int? FullHeight { get; set; }

        /// <summary>
        /// Can be &#39;null&#39; if state is empty (no header applied since node launch)
        /// </summary>
        /// <value>Can be &#39;null&#39; if state is empty (no header applied since node launch)</value>
        [DataMember(Name = "headersHeight", IsRequired = true, EmitDefaultValue = true)]
        public int? HeadersHeight { get; set; }

        /// <summary>
        /// Can be &#39;null&#39; if no full block is applied since node launch
        /// </summary>
        /// <value>Can be &#39;null&#39; if no full block is applied since node launch</value>
        [DataMember(Name = "bestFullHeaderId", IsRequired = true, EmitDefaultValue = true)]
        public string BestFullHeaderId { get; set; }

        /// <summary>
        /// Can be &#39;null&#39; if no full block is applied since node launch
        /// </summary>
        /// <value>Can be &#39;null&#39; if no full block is applied since node launch</value>
        [DataMember(Name = "previousFullHeaderId", IsRequired = true, EmitDefaultValue = true)]
        public string PreviousFullHeaderId { get; set; }

        /// <summary>
        /// Can be &#39;null&#39; if no header applied since node launch
        /// </summary>
        /// <value>Can be &#39;null&#39; if no header applied since node launch</value>
        [DataMember(Name = "bestHeaderId", IsRequired = true, EmitDefaultValue = true)]
        public string BestHeaderId { get; set; }

        /// <summary>
        /// Can be &#39;null&#39; if state is empty (no full block is applied since node launch)
        /// </summary>
        /// <value>Can be &#39;null&#39; if state is empty (no full block is applied since node launch)</value>
        [DataMember(Name = "stateRoot", IsRequired = true, EmitDefaultValue = true)]
        public string StateRoot { get; set; }

        /// <summary>
        /// Can be &#39;null&#39; if no full block is applied since node launch
        /// </summary>
        /// <value>Can be &#39;null&#39; if no full block is applied since node launch</value>
        [DataMember(Name = "stateVersion", IsRequired = true, EmitDefaultValue = true)]
        public string StateVersion { get; set; }

        /// <summary>
        /// Gets or Sets IsMining
        /// </summary>
        [DataMember(Name = "isMining", IsRequired = true, EmitDefaultValue = true)]
        public bool IsMining { get; set; }

        /// <summary>
        /// Number of connected peers
        /// </summary>
        /// <value>Number of connected peers</value>
        [DataMember(Name = "peersCount", IsRequired = true, EmitDefaultValue = false)]
        public int PeersCount { get; set; }

        /// <summary>
        /// Current unconfirmed transactions count
        /// </summary>
        /// <value>Current unconfirmed transactions count</value>
        [DataMember(Name = "unconfirmedCount", IsRequired = true, EmitDefaultValue = false)]
        public int UnconfirmedCount { get; set; }

        /// <summary>
        /// Difficulty on current bestFullHeaderId. Can be &#39;null&#39; if no full block is applied since node launch
        /// </summary>
        /// <value>Difficulty on current bestFullHeaderId. Can be &#39;null&#39; if no full block is applied since node launch</value>
        [DataMember(Name = "difficulty", IsRequired = true, EmitDefaultValue = true)]
        public int? Difficulty { get; set; }

        /// <summary>
        /// Current internal node time
        /// </summary>
        /// <value>Current internal node time</value>
        [DataMember(Name = "currentTime", IsRequired = true, EmitDefaultValue = false)]
        public long CurrentTime { get; set; }

        /// <summary>
        /// Time when the node was started
        /// </summary>
        /// <value>Time when the node was started</value>
        [DataMember(Name = "launchTime", IsRequired = true, EmitDefaultValue = false)]
        public long LaunchTime { get; set; }

        /// <summary>
        /// Can be &#39;null&#39; if no headers is applied since node launch
        /// </summary>
        /// <value>Can be &#39;null&#39; if no headers is applied since node launch</value>
        [DataMember(Name = "headersScore", IsRequired = true, EmitDefaultValue = true)]
        public int? HeadersScore { get; set; }

        /// <summary>
        /// Can be &#39;null&#39; if no full block is applied since node launch
        /// </summary>
        /// <value>Can be &#39;null&#39; if no full block is applied since node launch</value>
        [DataMember(Name = "fullBlocksScore", IsRequired = true, EmitDefaultValue = true)]
        public int? FullBlocksScore { get; set; }

        /// <summary>
        /// Can be &#39;null&#39; if genesis blocks is not produced yet
        /// </summary>
        /// <value>Can be &#39;null&#39; if genesis blocks is not produced yet</value>
        [DataMember(Name = "genesisBlockId", IsRequired = true, EmitDefaultValue = true)]
        public string GenesisBlockId { get; set; }

        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [DataMember(Name = "parameters", IsRequired = true, EmitDefaultValue = false)]
        public Parameters Parameters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeInfo {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AppVersion: ").Append(AppVersion).Append("\n");
            sb.Append("  FullHeight: ").Append(FullHeight).Append("\n");
            sb.Append("  HeadersHeight: ").Append(HeadersHeight).Append("\n");
            sb.Append("  BestFullHeaderId: ").Append(BestFullHeaderId).Append("\n");
            sb.Append("  PreviousFullHeaderId: ").Append(PreviousFullHeaderId).Append("\n");
            sb.Append("  BestHeaderId: ").Append(BestHeaderId).Append("\n");
            sb.Append("  StateRoot: ").Append(StateRoot).Append("\n");
            sb.Append("  StateType: ").Append(StateType).Append("\n");
            sb.Append("  StateVersion: ").Append(StateVersion).Append("\n");
            sb.Append("  IsMining: ").Append(IsMining).Append("\n");
            sb.Append("  PeersCount: ").Append(PeersCount).Append("\n");
            sb.Append("  UnconfirmedCount: ").Append(UnconfirmedCount).Append("\n");
            sb.Append("  Difficulty: ").Append(Difficulty).Append("\n");
            sb.Append("  CurrentTime: ").Append(CurrentTime).Append("\n");
            sb.Append("  LaunchTime: ").Append(LaunchTime).Append("\n");
            sb.Append("  HeadersScore: ").Append(HeadersScore).Append("\n");
            sb.Append("  FullBlocksScore: ").Append(FullBlocksScore).Append("\n");
            sb.Append("  GenesisBlockId: ").Append(GenesisBlockId).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
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
            return this.Equals(input as NodeInfo);
        }

        /// <summary>
        /// Returns true if NodeInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of NodeInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NodeInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.AppVersion == input.AppVersion ||
                    (this.AppVersion != null &&
                    this.AppVersion.Equals(input.AppVersion))
                ) && 
                (
                    this.FullHeight == input.FullHeight ||
                    (this.FullHeight != null &&
                    this.FullHeight.Equals(input.FullHeight))
                ) && 
                (
                    this.HeadersHeight == input.HeadersHeight ||
                    (this.HeadersHeight != null &&
                    this.HeadersHeight.Equals(input.HeadersHeight))
                ) && 
                (
                    this.BestFullHeaderId == input.BestFullHeaderId ||
                    (this.BestFullHeaderId != null &&
                    this.BestFullHeaderId.Equals(input.BestFullHeaderId))
                ) && 
                (
                    this.PreviousFullHeaderId == input.PreviousFullHeaderId ||
                    (this.PreviousFullHeaderId != null &&
                    this.PreviousFullHeaderId.Equals(input.PreviousFullHeaderId))
                ) && 
                (
                    this.BestHeaderId == input.BestHeaderId ||
                    (this.BestHeaderId != null &&
                    this.BestHeaderId.Equals(input.BestHeaderId))
                ) && 
                (
                    this.StateRoot == input.StateRoot ||
                    (this.StateRoot != null &&
                    this.StateRoot.Equals(input.StateRoot))
                ) && 
                (
                    this.StateType == input.StateType ||
                    this.StateType.Equals(input.StateType)
                ) && 
                (
                    this.StateVersion == input.StateVersion ||
                    (this.StateVersion != null &&
                    this.StateVersion.Equals(input.StateVersion))
                ) && 
                (
                    this.IsMining == input.IsMining ||
                    this.IsMining.Equals(input.IsMining)
                ) && 
                (
                    this.PeersCount == input.PeersCount ||
                    this.PeersCount.Equals(input.PeersCount)
                ) && 
                (
                    this.UnconfirmedCount == input.UnconfirmedCount ||
                    this.UnconfirmedCount.Equals(input.UnconfirmedCount)
                ) && 
                (
                    this.Difficulty == input.Difficulty ||
                    (this.Difficulty != null &&
                    this.Difficulty.Equals(input.Difficulty))
                ) && 
                (
                    this.CurrentTime == input.CurrentTime ||
                    this.CurrentTime.Equals(input.CurrentTime)
                ) && 
                (
                    this.LaunchTime == input.LaunchTime ||
                    this.LaunchTime.Equals(input.LaunchTime)
                ) && 
                (
                    this.HeadersScore == input.HeadersScore ||
                    (this.HeadersScore != null &&
                    this.HeadersScore.Equals(input.HeadersScore))
                ) && 
                (
                    this.FullBlocksScore == input.FullBlocksScore ||
                    (this.FullBlocksScore != null &&
                    this.FullBlocksScore.Equals(input.FullBlocksScore))
                ) && 
                (
                    this.GenesisBlockId == input.GenesisBlockId ||
                    (this.GenesisBlockId != null &&
                    this.GenesisBlockId.Equals(input.GenesisBlockId))
                ) && 
                (
                    this.Parameters == input.Parameters ||
                    (this.Parameters != null &&
                    this.Parameters.Equals(input.Parameters))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.AppVersion != null)
                    hashCode = hashCode * 59 + this.AppVersion.GetHashCode();
                if (this.FullHeight != null)
                    hashCode = hashCode * 59 + this.FullHeight.GetHashCode();
                if (this.HeadersHeight != null)
                    hashCode = hashCode * 59 + this.HeadersHeight.GetHashCode();
                if (this.BestFullHeaderId != null)
                    hashCode = hashCode * 59 + this.BestFullHeaderId.GetHashCode();
                if (this.PreviousFullHeaderId != null)
                    hashCode = hashCode * 59 + this.PreviousFullHeaderId.GetHashCode();
                if (this.BestHeaderId != null)
                    hashCode = hashCode * 59 + this.BestHeaderId.GetHashCode();
                if (this.StateRoot != null)
                    hashCode = hashCode * 59 + this.StateRoot.GetHashCode();
                hashCode = hashCode * 59 + this.StateType.GetHashCode();
                if (this.StateVersion != null)
                    hashCode = hashCode * 59 + this.StateVersion.GetHashCode();
                hashCode = hashCode * 59 + this.IsMining.GetHashCode();
                hashCode = hashCode * 59 + this.PeersCount.GetHashCode();
                hashCode = hashCode * 59 + this.UnconfirmedCount.GetHashCode();
                if (this.Difficulty != null)
                    hashCode = hashCode * 59 + this.Difficulty.GetHashCode();
                hashCode = hashCode * 59 + this.CurrentTime.GetHashCode();
                hashCode = hashCode * 59 + this.LaunchTime.GetHashCode();
                if (this.HeadersScore != null)
                    hashCode = hashCode * 59 + this.HeadersScore.GetHashCode();
                if (this.FullBlocksScore != null)
                    hashCode = hashCode * 59 + this.FullBlocksScore.GetHashCode();
                if (this.GenesisBlockId != null)
                    hashCode = hashCode * 59 + this.GenesisBlockId.GetHashCode();
                if (this.Parameters != null)
                    hashCode = hashCode * 59 + this.Parameters.GetHashCode();
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
            // FullHeight (int?) minimum
            if(this.FullHeight < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FullHeight, must be a value greater than or equal to 0.", new [] { "FullHeight" });
            }

            // HeadersHeight (int?) minimum
            if(this.HeadersHeight < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HeadersHeight, must be a value greater than or equal to 0.", new [] { "HeadersHeight" });
            }

            // PeersCount (int) minimum
            if(this.PeersCount < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PeersCount, must be a value greater than or equal to 0.", new [] { "PeersCount" });
            }

            // UnconfirmedCount (int) maximum
            if(this.UnconfirmedCount > (int)10000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UnconfirmedCount, must be a value less than or equal to 10000.", new [] { "UnconfirmedCount" });
            }

            // UnconfirmedCount (int) minimum
            if(this.UnconfirmedCount < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UnconfirmedCount, must be a value greater than or equal to 0.", new [] { "UnconfirmedCount" });
            }

            // Difficulty (int?) minimum
            if(this.Difficulty < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Difficulty, must be a value greater than or equal to 0.", new [] { "Difficulty" });
            }

            yield break;
        }
    }

}
