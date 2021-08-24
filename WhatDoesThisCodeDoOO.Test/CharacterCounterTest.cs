using NUnit.Framework;

namespace WhatDoesThisCodeDoOO.Test
{
    public class CharacterCounterTest
    {
        [Test]
        public void Test1()
        {
            // arrange
            var characterCounter = CharacterCounter.Instance;

            // act
            characterCounter.Count("ABC");
            characterCounter.Count("AAA");

            // assert
            var actualDescription = characterCounter.CreateDescription();
            const string expectedDescription = "A - 4\nB - 1\nC - 1\n";
            Assert.AreEqual(expectedDescription, actualDescription);
        }

        [Test]
        public void Test2()
        {
            // arrange
            var characterCounter = CharacterCounter.Instance;

            // act

            // assert
            var actualDescription = characterCounter.CreateDescription();
            const string expectedDescription = "";
            Assert.AreEqual(expectedDescription, actualDescription);
        }
    }
}