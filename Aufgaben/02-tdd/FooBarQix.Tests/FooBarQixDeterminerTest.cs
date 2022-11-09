using Xunit;

namespace FooBarQix.Tests
{
    public class FooBarQixDeterminerTest
    {
        [Fact]
        public void NotDividableByThreeOrFiveOrSevenIsArg()
        {
            var determiner = new FooBarQixDeterminer();
            int arg = 4;

            string result = determiner.Determine(arg);

            Assert.Equal(result, arg.ToString());
        }

        [Fact]
        public void DividableByThreeIsFoo()
        {
            var determiner = new FooBarQixDeterminer();
            int arg = 9;
            string expected = "Foo";

            string result = determiner.Determine(arg);

            Assert.Equal(result, expected);
        }

        [Fact]
        public void DividableByFiveIsBar()
        {
            var determiner = new FooBarQixDeterminer();
            int arg = 10;
            string expected = "Bar";

            string result = determiner.Determine(arg);

            Assert.Equal(result, expected);
        }

        [Fact]
        public void DividableBySevenIsQix()
        {
            var determiner = new FooBarQixDeterminer();
            int arg = 14;
            string expected = "Qix";

            string result = determiner.Determine(arg);

            Assert.Equal(result, expected);
        }
    }
}