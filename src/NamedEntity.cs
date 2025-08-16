using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Soenneker.Entities.Named.Abstract;

namespace Soenneker.Entities.Named;

/// <inheritdoc cref="INamedEntity"/>
public class NamedEntity : Entity.Entity, INamedEntity
{
    [JsonPropertyName("name")]
    [JsonProperty("name")]
    public virtual string Name { get; set; } = null!;
}