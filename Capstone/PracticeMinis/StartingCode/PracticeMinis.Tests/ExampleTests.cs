namespace PracticeMinis.Tests
{
    public class ExampleTests
    {
        // test case values are passed in to the parameter variables, x, y, and expected
        [TestCase(1, 1, 2)]
        [TestCase(5, 10, 15)]
        public void AddTest(int x, int y, int expected)
        {
            int actual = Example.Add(x, y);

            // assert, verify correctness
            Assert.That(actual == expected);
        }
    }
}