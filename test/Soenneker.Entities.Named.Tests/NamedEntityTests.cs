using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Entities.Named.Tests;

[Collection("Collection")]
public class NamedEntityTests : FixturedUnitTest
{
    public NamedEntityTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
