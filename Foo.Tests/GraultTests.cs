using Xunit;

namespace Foo.Tests
{
    public class GraultTests
    {
        [Fact]
        public void CanInstantiateGrault()
        {
            var grault = new Grault();
        }

        [Fact]
        public void ThisTestShouldNotFail()
        {
            Assert.True(true);
        }
    }
}
