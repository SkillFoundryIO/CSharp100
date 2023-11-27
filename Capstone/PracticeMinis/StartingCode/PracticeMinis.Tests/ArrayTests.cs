namespace PracticeMinis.Tests
{
    public class ArrayTests
    {
        private bool ArrayValuesMatch(int[] actual, int[] expected)
        {
            if(actual.Length != expected.Length)
            {
                return false;
            }

            for (int i = 0; i < actual.Length; i++)
            {
                if (actual[i] != expected[i])
                {
                    return false;
                }
            }

            return true;
        }

        [TestCase(new int[] { 1, 2, 6 }, true)]
        [TestCase(new int[] { 6, 1, 2, 3 }, true)]
        [TestCase(new int[] { 13, 6, 1, 2, 3 }, false)]
        public void FirstLast6Test(int[] numbers, bool expected)
        {
            var actual = ArrayExercises.FirstLast6(numbers);
            Assert.That(actual == expected);
        }

        [TestCase(new int[] { 1, 2, 3 }, false)]
        [TestCase(new int[] { 1, 2, 3, 1 }, true)]
        [TestCase(new int[] { 1, 2, 1 }, true)]
        public void SameFirstLastTest(int[] numbers, bool expected)
        {
            var actual = ArrayExercises.SameFirstLast(numbers);
            Assert.That(actual == expected);
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 7, 3 }, true)]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 7, 3, 2 }, false)]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 3 }, true)]
        public void CommonEndTest(int[] a, int[] b, bool expected)
        {
            var actual = ArrayExercises.CommonEnd(a, b);
            Assert.That(actual == expected);
        }

        [TestCase(new int[] { 1, 2, 3 }, 6)]
        [TestCase(new int[] { 5, 11, 2 }, 18)]
        [TestCase(new int[] { 7, 0, 0 }, 7)]
        public void SumTest(int[] numbers, int expected)
        {
            var actual = ArrayExercises.Sum(numbers);
            Assert.That(actual == expected);
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 2, 3, 1 })]
        [TestCase(new int[] { 5, 11, 9 }, new int[] { 11, 9, 5 })]
        [TestCase(new int[] { 7, 0, 0 }, new int[] { 0, 0, 7 })]
        public void RotateLeftTest(int[] numbers, int[] expected)
        {
            var actual = ArrayExercises.RotateLeft(numbers);
            Assert.That(ArrayValuesMatch(actual, expected));
        }


        [TestCase(new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 })]
        [TestCase(new int[] { 5, 11, 9 }, new int[] { 9, 11, 5 })]
        [TestCase(new int[] { 7, 0, 0 }, new int[] { 0, 0, 7 })]
        public void ReverseTest(int[] numbers, int[] expected)
        {
            var actual = ArrayExercises.Reverse(numbers);
            Assert.That(ArrayValuesMatch(actual, expected));
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 3, 3, 3 })]
        [TestCase(new int[] { 11, 5, 9 }, new int[] { 11, 11, 11 })]
        [TestCase(new int[] { 2, 11, 3 }, new int[] { 3, 3, 3 })]
        public void HigherWinsTest(int[] numbers, int[] expected)
        {
            var actual = ArrayExercises.HigherWins(numbers);
            Assert.That(ArrayValuesMatch(actual, expected));
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 2, 5 })]
        [TestCase(new int[] { 7, 7, 7 }, new int[] { 3, 8, 0 }, new int[] { 7, 8 })]
        [TestCase(new int[] { 5, 2, 9 }, new int[] { 1, 4, 5 }, new int[] { 2, 4 })]
        public void GetMiddleTest(int[] a, int[] b, int[] expected)
        {
            var actual = ArrayExercises.GetMiddle(a, b);
            Assert.That(ArrayValuesMatch(actual, expected));
        }

        [TestCase(new int[] { 2, 5 }, true)]
        [TestCase(new int[] { 4, 3 }, true)]
        [TestCase(new int[] { 7, 5 }, false)]
        public void HasEvenTest(int[] numbers, bool expected)
        {
            var actual = ArrayExercises.HasEven(numbers);
            Assert.That(actual == expected);
        }

        [TestCase(new int[] { 4, 5, 6 }, new int[] { 0, 0, 0, 0, 0, 6 })]
        [TestCase(new int[] { 1, 2 }, new int[] { 0, 0, 0, 2 })]
        [TestCase(new int[] { 3 }, new int[] { 0, 3 })]
        public void KeepLastTest(int[] numbers, int[] expected)
        {
            var actual = ArrayExercises.KeepLast(numbers);
            Assert.That(ArrayValuesMatch(actual, expected));
        }

        [TestCase(new int[] { 2, 2, 3 }, true)]
        [TestCase(new int[] { 3, 4, 5, 3 }, true)]
        [TestCase(new int[] { 2, 3, 2, 2 }, false)]
        public void Double23Test(int[] numbers, bool expected)
        {
            var actual = ArrayExercises.Double23(numbers);
            Assert.That(actual == expected);
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2, 0 })]
        [TestCase(new int[] { 2, 3, 5 }, new int[] { 2, 0, 5 })]
        [TestCase(new int[] { 1, 2, 1 }, new int[] { 1, 2, 1 })]
        public void Fix23Test(int[] numbers, int[] expected)
        {
            var actual = ArrayExercises.Fix23(numbers);
            Assert.That(ArrayValuesMatch(actual, expected));
        }

        [TestCase(new int[] { 1, 3, 4, 5 }, true)]
        [TestCase(new int[] { 2, 1, 3, 4, 5 }, true)]
        [TestCase(new int[] { 1, 1, 1 }, false)]
        public void Unlucky1Test(int[] numbers, bool expected)
        {
            var actual = ArrayExercises.Unlucky1(numbers);
            Assert.That(actual == expected);
        }

        [TestCase(new int[] { 4, 5 }, new int[] { 1, 2, 3 }, new int[] { 4, 5 })]
        [TestCase(new int[] { 4 }, new int[] { 1, 2, 3 }, new int[] { 4, 1 })]
        [TestCase(new int[] { }, new int[] { 1, 2 }, new int[] { 1, 2 })]
        public void Make2Test(int[] a, int[] b, int[] expected)
        {
            var actual = ArrayExercises.Make2(a, b);
            Assert.That(ArrayValuesMatch(actual, expected));
        }
    }
}
