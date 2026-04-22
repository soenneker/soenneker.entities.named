using Soenneker.Tests.HostedUnit;

namespace Soenneker.Entities.Named.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class NamedEntityTests : HostedUnitTest
{
    public NamedEntityTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
