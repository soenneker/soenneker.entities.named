[![](https://img.shields.io/nuget/v/Soenneker.Entities.Named.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Entities.Named/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.entities.named/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.entities.named/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/Soenneker.Entities.Named.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Entities.Named/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.entities.named/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.entities.named/actions/workflows/codeql.yml)

# Soenneker.Entities.Named

Adds a mutable, virtual `Name` property to the base entity identity and audit fields.

## Install

```bash
dotnet add package Soenneker.Entities.Named
```

## Derive a named entity

```csharp
using Soenneker.Entities.Named;

public sealed class ProductCategory : NamedEntity
{
    public string? Description { get; set; }
}

var category = new ProductCategory
{
    Id = Guid.NewGuid().ToString("N"),
    Name = "Office supplies",
    Description = "Paper, stationery, and desk accessories",
    CreatedAt = DateTimeOffset.UtcNow
};
```

`NamedEntity` derives from `Soenneker.Entities.Entity.Entity` and implements `INamedEntity`. Implement `INamedEntity` directly when your domain type already has another base class.

The package does not assign, trim, normalize, localize, or require uniqueness for `Name`; those remain application rules. `Id`, `Name`, and `CreatedAt` must be assigned by the caller to avoid their CLR defaults.

The serialized property names are `id`, `name`, `createdAt`, and `modifiedAt` with both `System.Text.Json` and Newtonsoft.Json. Null omission follows the selected serializer settings.
