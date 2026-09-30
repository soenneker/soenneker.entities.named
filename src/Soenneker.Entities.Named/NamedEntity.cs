using System.Text.Json.Serialization;
using Soenneker.Entities.Named.Abstract;

namespace Soenneker.Entities.Named;

/// <inheritdoc cref="INamedEntity" />
public class NamedEntity : Entity.Entity, INamedEntity
{
    [JsonPropertyName("name")]
    public virtual string Name { get; set; } = null!;
}
