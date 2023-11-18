using NUnit.Framework;
using System;
using testing_lab4._5;

namespace testing_lab4._5_tests
{
    public class Tests
    {

        [TestCase(100.7f)]
        [TestCase(100.8f)]
        [TestCase(100.9f)]
        public void NumberGreaterThen100Point7IncludingThisNumber(float number)
        {
            var expect = 1000;
            var actual = Converter.Do(number);
            

            Assert.AreEqual(expect, actual);
        }


        [TestCase(100.6f)]
        [TestCase(100.5f)]
        [TestCase(100.4f)]
        [TestCase(1.4f)]
        [TestCase(0.5f)]
        public void NumberLessThen100Point7AndGreatestThen0NotIncludingThisNumber(float number)
        {
            var expect = (int)number;
            var actual = Converter.Do(number);


            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void NumberIs0()
        {
            Assert.Throws<ArgumentException>(() => Converter.Do(0));
        }

        [TestCase(-30.4f)]
        [TestCase(-30.3f)]
        [TestCase(-30.2f)]
        [TestCase(-3.2f)]
        public void NumberLessMinus30Point4AndGreatestThen0NotIncludingMinus30Point4(float number)
        {
            var expect = (int)number - 5 ;
            var actual = Converter.Do(number);

            Assert.AreEqual(expect, actual);
        }

        [TestCase(-30.5f)]
        [TestCase(-30.6f)]
        [TestCase(-30.7f)]
        [TestCase(-300.2f)]
        public void NumberGreatestMinus30Point5AndIncludingThisNumber(float number)
        {
            var expect = -2000;
            var actual = Converter.Do(number);

            Assert.AreEqual(expect, actual);
        }

        [TestCase(-30.54f)]
        [TestCase(100.64f)]
        [TestCase(0.74f)]
        public void NumberOfDecimalPlacesIsNotDifferent1(float number)
        {
            Assert.Throws<ArgumentException>(() => Converter.Do(number));
        }
    }
}