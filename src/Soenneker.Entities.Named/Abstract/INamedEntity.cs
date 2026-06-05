using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Soenneker.Entities.Entity.Abstract;

namespace Soenneker.Entities.Named.Abstract;

/// <summary>Essentially just provides <see cref="Name"/> string property.
///<inheritdoc cref="IEntity"/>
/// </summary>
public interface INamedEntity : IEntity
{
    /// <summary>
    /// Gets or sets name.
    /// </summary>
    [JsonPropertyName("name")]
    [JsonProperty("name")]
    string Name { get; set; }
}