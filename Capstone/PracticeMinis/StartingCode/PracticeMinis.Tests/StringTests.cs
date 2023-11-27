using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PracticeMinis.Tests
{
    public class StringTests
    {
        [TestCase("Bob", "Hello Bob!")]
        [TestCase("Alice", "Hello Alice!")]
        [TestCase("X", "Hello X!")]
        public void SayHiTest(string name, string expected)
        {
            var actual = StringExercises.SayHi(name);

            Assert.That(actual == expected);
        }

        [TestCase("Hi", "Bye", "HiByeByeHi")]
        [TestCase("Yo", "Alice", "YoAliceAliceYo")]
        [TestCase("What", "Up", "WhatUpUpWhat")]
        public void AbbaTest(string a, string b, string expected)
        {
            var actual = StringExercises.Abba(a, b);

            Assert.That(actual == expected);
        }

        [TestCase("i", "Yay", "<i>Yay</i>")]
        [TestCase("i", "Hello", "<i>Hello</i>")]
        [TestCase("cite", "Yay", "<cite>Yay</cite>")]
        public void MakeTagsTest(string tag, string content, string expected)
        {
            var actual = StringExercises.MakeTags(tag, content);

            Assert.That(actual == expected);
        }

        [TestCase("<<>>", "Yay", "<<Yay>>")]
        [TestCase("<<>>", "WooHoo", "<<WooHoo>>")]
        [TestCase("[[]]", "word", "[[word]]")]
        public void InsertWordTest(string container, string word, string expected)
        {
            var actual = StringExercises.InsertWord(container, word);

            Assert.That(actual == expected);
        }

        [TestCase("Hello", "lololo")]
        [TestCase("ab", "ababab")]
        [TestCase("Hi", "HiHiHi")]
        public void MultipleEndingsTest(string str, string expected)
        {
            var actual = StringExercises.MultipleEndings(str);

            Assert.That(actual == expected);
        }

        [TestCase("WooHoo", "Woo")]
        [TestCase("HelloThere", "Hello")]
        [TestCase("abcdef", "abc")]
        public void FirstHalfTest(string str, string expected)
        {
            var actual = StringExercises.FirstHalf(str);

            Assert.That(actual == expected);
        }

        [TestCase("Hello", "ell")]
        [TestCase("java", "av")]
        [TestCase("coding", "odin")]
        public void TrimOneTest(string str, string expected)
        {
            var actual = StringExercises.TrimOne(str);

            Assert.That(actual == expected);
        }

        [TestCase("Hello", "hi", "hiHellohi")]
        [TestCase("hi", "Hello", "hiHellohi")]
        [TestCase("aaa", "b", "baaab")]
        public void LongInMiddleTest(string a, string b, string expected)
        {
            var actual = StringExercises.LongInMiddle(a, b);

            Assert.That(actual == expected);
        }

        [TestCase("Hello", "lloHe")]
        [TestCase("java", "vaja")]
        [TestCase("Hi", "Hi")]
        public void Rotateleft2Test(string str, string expected)
        {
            var actual = StringExercises.Rotateleft2(str);

            Assert.That(actual == expected);
        }

        [TestCase("Hello", "loHel")]
        [TestCase("java", "vaja")]
        [TestCase("Hi", "Hi")]
        public void RotateRight2Test(string str, string expected)
        {
            var actual = StringExercises.RotateRight2(str);

            Assert.That(actual == expected);
        }

        [TestCase("string", "ri")]
        [TestCase("code", "od")]
        [TestCase("Practice", "ct")]
        public void MiddleTwoTest(string str, string expected)
        {
            var actual = StringExercises.MiddleTwo(str);

            Assert.That(actual == expected);
        }

        [TestCase("oddly", true)]
        [TestCase("y", false)]
        [TestCase("oddy", false)]
        public void EndsWithLyTest(string str, bool expected)
        {
            var actual = StringExercises.EndsWithLy(str);

            Assert.That(actual == expected);
        }

        [TestCase("Hello", 2, "Helo")]
        [TestCase("Chocolate", 3, "Choate")]
        [TestCase("Chocolate", 1, "Ce")]
        public void FrontAndBackTest(string str, int n, string expected)
        {
            var actual = StringExercises.FrontAndBack(str, n);

            Assert.That(actual == expected);
        }

        [TestCase("java", 0, "ja")]
        [TestCase("java", 2, "va")]
        [TestCase("java", 3, "ja")]
        public void TakeTwoFromPositionTest(string str, int n, string expected)
        {
            var actual = StringExercises.TakeTwoFromPosition(str, n);

            Assert.That(actual == expected);
        }

        [TestCase("badxx", true)]
        [TestCase("xbadxx", true)]
        [TestCase("xxbadxx", false)]
        public void HasBadTest(string str, bool expected)
        {
            var actual = StringExercises.HasBad(str);

            Assert.That(actual == expected);
        }
    }
}
