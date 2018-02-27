using Foo;
using Xunit;

namespace FooTests
{
    public class GraultTests
    {
        [Fact]
        public void CanInstantiateGrault()
        {
            var grault = new Grault();
        }

        [Fact]
        public void ThisTestShouldFail()
        {
            Assert.True(false);
        }
    }
}
