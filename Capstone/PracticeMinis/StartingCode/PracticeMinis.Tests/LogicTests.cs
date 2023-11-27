using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeMinis.Tests
{
    public class LogicTests
    {
        [TestCase(6, 4, true)]
        [TestCase(4, 5, false)]
        [TestCase(1, 5, true)]
        public void LoveSix(int a, int b, bool expected)
        {
            var actual = LogicExercises.LoveSix(a, b);

            Assert.That(actual == expected);
        }

        [TestCase(5, 10, 2)]
        [TestCase(5, 2, 0)]
        [TestCase(5, 5, 1)]
        public void CanHazTableTest(int yourStyle, int dateStyle, int expected)
        {
            var actual = LogicExercises.CanHazTable(yourStyle, dateStyle);

            Assert.That(actual == expected);
        }

        [TestCase(70, false, true)]
        [TestCase(95, false, false)]
        [TestCase(95, true, true)]
        public void PlayOutside(int temp, bool isSummer, bool expected)
        {
            var actual = LogicExercises.PlayOutside(temp, isSummer);

            Assert.That(actual == expected);
        }

        [TestCase(60, false, 0)]
        [TestCase(65, false, 1)]
        [TestCase(65, true, 0)]
        public void CaughtSpeeding(int speed, bool isBirthday, int expected)
        {
            var actual = LogicExercises.CaughtSpeeding(speed, isBirthday);

            Assert.That(actual == expected);
        }

        [TestCase(3, 4, 7)]
        [TestCase(9, 4, 20)]
        [TestCase(10, 11, 21)]
        public void SkipSum(int a, int b, int expected)
        {
            var actual = LogicExercises.SkipSum(a, b);

            Assert.That(actual == expected);
        }

        [TestCase(1, false, "7:00")]
        [TestCase(5, false, "7:00")]
        [TestCase(3, true, "10:00")]
        public void AlarmClock(int day, bool vaction, string expected)
        {
            var actual = LogicExercises.AlarmClock(day, vaction);

            Assert.That(actual == expected);
        }

        [TestCase(5, false, true)]
        [TestCase(11, false, false)]
        [TestCase(11, true, true)]
        public void InRange(int n, bool outsideMode, bool expected)
        {
            var actual = LogicExercises.InRange(n, outsideMode);

            Assert.That(actual == expected);
        }

        [TestCase(22, true)]
        [TestCase(23, true)]
        [TestCase(24, false)]
        public void SpecialEleven(int n, bool expected)
        {
            var actual = LogicExercises.SpecialEleven(n);

            Assert.That(actual == expected);
        }

        [TestCase(20, false)]
        [TestCase(21, true)]
        [TestCase(22, true)]
        public void Mod20(int n, bool expected)
        {
            var actual = LogicExercises.Mod20(n);

            Assert.That(actual == expected);
        }

        [TestCase(3, true)]
        [TestCase(10, true)]
        [TestCase(15, false)]
        public void Mod35(int n, bool expected)
        {
            var actual = LogicExercises.Mod35(n);

            Assert.That(actual == expected);
        }

        [TestCase(false, false, false, true)]
        [TestCase(false, false, true, false)]
        [TestCase(true, false, false, false)]
        public void AnswerCell(bool isMorning, bool isMom, bool isAsleep, bool expected)
        {
            var actual = LogicExercises.AnswerCell(isMorning, isMom, isAsleep);

            Assert.That(actual == expected);
        }

        [TestCase(1, 2, 3, true)]
        [TestCase(3, 1, 2, true)]
        [TestCase(3, 2, 2, false)]
        public void TwoIsOne(int a, int b, int c, bool expected)
        {
            var actual = LogicExercises.TwoIsOne(a, b, c);

            Assert.That(actual == expected);
        }

        [TestCase(23, 19, 13, true)]
        [TestCase(23, 19, 12, false)]
        [TestCase(23, 19, 3, true)]
        public void LastDigit(int a, int b, int c, bool expected)
        {
            var actual = LogicExercises.LastDigit(a, b, c);

            Assert.That(actual == expected);
        }
    }
}
