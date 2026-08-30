using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Soenneker.Entities.Entity.Abstract;

namespace Soenneker.Entities.Named.Abstract;

/// <summary>
/// Extends <see cref="IEntity"/> with an application-defined display or domain name.
/// </summary>
public interface INamedEntity : IEntity
{
    /// <summary>
    /// Gets or sets the entity's name.
    /// </summary>
    [JsonPropertyName("name")]
    [JsonProperty("name")]
    string Name { get; set; }
}
