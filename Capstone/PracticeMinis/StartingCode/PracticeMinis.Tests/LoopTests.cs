using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeMinis.Tests
{
    public class LoopTests
    {
        [TestCase("Hi", 2, "HiHi")]
        [TestCase("Hi", 3, "HiHiHi")]
        [TestCase("Hi", 1, "Hi")]
        public void StringTimesTest(string str, int n, string expected)
        {
            var actual = LoopExercises.StringTimes(str, n);

            Assert.That(actual == expected);
        }

        [TestCase("Chocolate", 2, "ChoCho")]
        [TestCase("Chocolate", 3, "ChoChoCho")]
        [TestCase("Abc", 3, "AbcAbcAbc")]
        public void FrontTimesTest(string str, int n, string expected)
        {
            var actual = LoopExercises.FrontTimes(str, n);

            Assert.That(actual == expected);
        }

        [TestCase("axxbb", true)]
        [TestCase("axaxxax", false)]
        [TestCase("xxxxx", true)]
        public void DoubleXTest(string str, bool expected)
        {
            var actual = LoopExercises.DoubleX(str);

            Assert.That(actual == expected);
        }

        [TestCase("Hello", "Hlo")]
        [TestCase("Hi", "H")]
        [TestCase("Heeololeo", "Hello")]
        public void EveryOtherTest(string str, string expected)
        {
            var actual = LoopExercises.EveryOther(str);

            Assert.That(actual == expected);
        }

        [TestCase("Code", "CCoCodCode")]
        [TestCase("abc", "aababc")]
        [TestCase("ab", "aab")]
        public void StringSplosionTest(string str, string expected)
        {
            var actual = LoopExercises.StringSplosion(str);

            Assert.That(actual == expected);
        }

        [TestCase("hixxhi", 1)]
        [TestCase("xaxxaxaxx", 1)]
        [TestCase("axxxaaxx", 2)]
        public void CountLast2Test(string str, int expected)
        {
            var actual = LoopExercises.CountLast2(str);

            Assert.That(actual == expected);
        }

        [TestCase(new int[] { 1, 2, 9 }, 1)]
        [TestCase(new int[] { 1, 9, 9 }, 2)]
        [TestCase(new int[] { 1, 9, 9, 3, 9 }, 3)]
        public void Count9Test(int[] numbers, int expected)
        {
            var actual = LoopExercises.Count9(numbers);

            Assert.That(actual == expected);
        }

        [TestCase(new int[] { 1, 2, 9, 3, 4 }, true)]
        [TestCase(new int[] { 1, 2, 3, 4, 9 }, false)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, false)]
        public void ArrayFront9Test(int[] numbers, bool expected)
        {
            var actual = LoopExercises.ArrayFront9(numbers);

            Assert.That(actual == expected);
        }

        [TestCase(new int[] { 1, 1, 2, 3, 1 }, true)]
        [TestCase(new int[] { 1, 1, 2, 4, 1 }, false)]
        [TestCase(new int[] { 1, 1, 2, 1, 2, 3 }, true)]
        public void Array123Test(int[] numbers, bool expected)
        {
            var actual = LoopExercises.Array123(numbers);

            Assert.That(actual == expected);
        }

        [TestCase("xxcaazz", "xxbaaz", 3)]
        [TestCase("abc", "abc", 2)]
        [TestCase("abc", "axc", 0)]
        public void SubStringMatchTest(string a, string b, int expected)
        {
            var actual = LoopExercises.SubStringMatch(a, b);

            Assert.That(actual == expected);
        }

        [TestCase("xxHxix", "xHix")]
        [TestCase("abxxxcd", "abcd")]
        [TestCase("xabxxxcdx", "xabcdx")]
        public void StringXTest(string str, string expected)
        {
            var actual = LoopExercises.StringX(str);

            Assert.That(actual == expected);
        }

        [TestCase("kitten", "kien")]
        [TestCase("Chocolate", "Chole")]
        [TestCase("CodingHorror", "Congrr")]
        public void AltPairsTest(string str, string expected)
        {
            var actual = LoopExercises.AltPairs(str);

            Assert.That(actual == expected);
        }

        [TestCase("yakpak", "pak")]
        [TestCase("pakyak", "pak")]
        [TestCase("yak123ya", "123ya")]
        public void DoNotYakTest(string str, string expected)
        {
            var actual = LoopExercises.DoNotYak(str);

            Assert.That(actual == expected);
        }

        [TestCase(new int[] { 6, 6, 2 }, 1)]
        [TestCase(new int[] { 6, 6, 2, 6 }, 1)]
        [TestCase(new int[] { 6, 7, 2, 6 }, 1)]
        public void Array667Test(int[] numbers, int expected)
        {
            var actual = LoopExercises.Array667(numbers);
            
            Assert.That(actual == expected);
        }

        [TestCase(new int[] { 1, 1, 2, 2, 1 }, true)]
        [TestCase(new int[] { 1, 1, 2, 2, 2, 1 }, false)]
        [TestCase(new int[] { 1, 1, 1, 2, 2, 2, 1 }, false)]
        public void NoTriplesTest(int[] numbers, bool expected)
        {
            var actual = LoopExercises.NoTriples(numbers);

            Assert.That(actual == expected);
        }

        [TestCase(new int[] { 1, 2, 7, 1 }, true)]
        [TestCase(new int[] { 1, 2, 8, 1 }, false)]
        [TestCase(new int[] { 2, 7, 1 }, true)]
        public void Pattern51Test(int[] numbers, bool expected)
        {
            var actual = LoopExercises.Pattern51(numbers);

            Assert.That(actual == expected);
        }

        [TestCase("abcxx", 1)]
        [TestCase("xxxx", 3)]
        [TestCase("ab", 0)]
        public void CountXXTest(string input, int expected)
        {
            var actual = LoopExercises.CountXX(input);

            Assert.That(actual == expected);
        }
    }
}
