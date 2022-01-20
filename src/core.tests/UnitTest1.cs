using Xunit;
using NFluent;

namespace core.tests;

public class UnitTest1
{
    [Fact]
    public void DummyTest()
    {
        Check.That(1).IsEqualTo(1);
    }
}