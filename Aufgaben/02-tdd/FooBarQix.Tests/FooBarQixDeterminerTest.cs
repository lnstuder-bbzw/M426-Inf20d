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

        [Fact]
        public void DividableByThreeAndFiveIsFooBar()
        {
            var determiner = new FooBarQixDeterminer();
            int arg = 15;
            string expected = "FooBar";

            string result = determiner.Determine(arg);

            Assert.Equal(result, expected);
        }

        [Fact]
        public void DividableByFiveAndSevenIsBarQix()
        {
            var determiner = new FooBarQixDeterminer();
            int arg = 35;
            string expected = "BarQix";

            string result = determiner.Determine(arg);

            Assert.Equal(result, expected);
        }

        [Fact]
        public void DividableByThreeAndSevenIsBarQix()
        {
            var determiner = new FooBarQixDeterminer();
            int arg = 21;
            string expected = "FooQix";

            string result = determiner.Determine(arg);

            Assert.Equal(result, expected);
        }

        [Fact]
        public void DividableByThreeAndFiveAndSevenIsFooBarQix()
        {
            var determiner = new FooBarQixDeterminer();
            int arg = 105;
            string expected = "FooBarQix";

            string result = determiner.Determine(arg);

            Assert.Equal(result, expected);
        }
    }
}