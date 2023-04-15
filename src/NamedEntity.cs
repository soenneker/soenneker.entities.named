using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Soenneker.Entities.Named.Abstract;

namespace Soenneker.Entities.Named;

/// <inheritdoc cref="INamedEntity"/>
public abstract class NamedEntity : Entity.Entity, INamedEntity
{
    [JsonPropertyName("name")]
    [JsonProperty("name")]
    public string Name { get; set; } = default!;
}