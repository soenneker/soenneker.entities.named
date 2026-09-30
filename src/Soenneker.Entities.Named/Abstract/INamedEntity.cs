using System.Text.Json.Serialization;
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
    string Name { get; set; }
}
