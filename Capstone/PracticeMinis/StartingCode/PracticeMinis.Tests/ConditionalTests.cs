using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeMinis.Tests
{
    public class ConditionalTests
    {
        [TestCase(true, true, true)]
        [TestCase(false, false, true)]
        [TestCase(false, true, false)]
        public void AreWeInTrouble(bool aSmile, bool bSmile, bool expected)
        {
            var actual = ConditionalExercises.AreWeInTrouble(aSmile, bSmile);

            Assert.That(actual == expected);
        }

        [TestCase(false, false, true)]
        [TestCase(true, false, false)]
        [TestCase(false, true, true)]
        public void CanSleepIn(bool isWeekday, bool isVacation, bool expected)
        {
            var actual = ConditionalExercises.CanSleepIn(isWeekday, isVacation);

            Assert.That(actual == expected);
        }

        [TestCase(1, 2, 3)]
        [TestCase(3, 2, 5)]
        [TestCase(2, 2, 8)]
        public void SumDouble(int a, int b, int expected)
        {
            var actual = ConditionalExercises.SumDouble(a, b);

            Assert.That(actual == expected);
        }

        [TestCase(23, 4)]
        [TestCase(10, 11)]
        [TestCase(21, 0)]
        public void Diff21(int n, int expected)
        {
            var actual = ConditionalExercises.Diff21(n);

            Assert.That(actual == expected);
        }

        [TestCase(true, 6, true)]
        [TestCase(true, 7, false)]
        [TestCase(false, 6, false)]
        public void ParrotTrouble(bool isTalking, int hour, bool expected)
        {
            var actual = ConditionalExercises.ParrotTrouble(isTalking, hour);

            Assert.That(actual == expected);
        }

        [TestCase(9, 10, true)]
        [TestCase(9, 9, false)]
        [TestCase(1, 9, true)]
        public void Makes10(int a, int b, bool expected)
        {
            var actual = ConditionalExercises.Makes10(a, b);

            Assert.That(actual == expected);
        }

        [TestCase(103, true)]
        [TestCase(90, true)]
        [TestCase(89, false)]
        public void NearHundred(int n, bool expected)
        {
            var actual = ConditionalExercises.NearHundred(n);

            Assert.That(actual == expected);
        }

        [TestCase(1, -1, false, true)]
        [TestCase(-1, 1, false, true)]
        [TestCase(-4, -5, true, true)]
        public void PosNeg(int a, int b, bool negative, bool expected)
        {
            var actual = ConditionalExercises.PosNeg(a, b, negative);

            Assert.That(actual == expected);
        }

        [TestCase("candy", "not candy")]
        [TestCase("x", "not x")]
        [TestCase("not bad", "not bad")]
        public void NotString(string s, string expected)
        {
            var actual = ConditionalExercises.NotString(s);

            Assert.That(actual == expected);
        }

        [TestCase("kitten", 1, "ktten")]
        [TestCase("hello", 0, "ello")]
        [TestCase("kitten", 4, "kittn")]
        public void MissingChar(string str, int n, string expected)
        {
            var actual = ConditionalExercises.MissingChar(str, n);

            Assert.That(actual == expected);
        }

        [TestCase("code", "eodc")]
        [TestCase("a", "a")]
        [TestCase("ab", "ba")]
        public void FrontBack(string str, string expected)
        {
            var actual = ConditionalExercises.FrontBack(str);

            Assert.That(actual == expected);
        }

        [TestCase("Microsoft", "MicMicMic")]
        [TestCase("Chocolate", "ChoChoCho")]
        [TestCase("at", "atatat")]
        public void Front3(string str, string expected)
        {
            var actual = ConditionalExercises.Front3(str);

            Assert.That(actual == expected);
        }

        [TestCase("cat", "tcatt")]
        [TestCase("Hello", "oHelloo")]
        [TestCase("a", "aaa")]
        public void BackAround(string str, string expected)
        {
            var actual = ConditionalExercises.BackAround(str);

            Assert.That(actual == expected);
        }

        [TestCase(3, true)]
        [TestCase(5, true)]
        [TestCase(8, false)]
        public void Multiple3or5(int n, bool expected)
        {
            var actual = ConditionalExercises.Multiple3or5(n);

            Assert.That(actual == expected);
        }

        [TestCase("hi there", true)]
        [TestCase("Hi", false)]
        [TestCase("orange juice", false)]
        public void StartHi(string str, bool expected)
        {
            var actual = ConditionalExercises.StartHi(str);

            Assert.That(actual == expected);
        }
    }
}
