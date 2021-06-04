using Microsoft.VisualStudio.TestTools.UnitTesting;
using MagieApp;
using System.Collections.Generic;
using System;

namespace MagieAppTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FirstHandout()
        {
            // Arrange
            List<Card> answer = new List<Card>();
            var values = Enum.GetValues(typeof(CardValues.Values));
            foreach (var value in values)
            {
                Card card = new Card(value);
                answer.Add(card);
            }
            Deck deck = new Deck();

            // Act
            List<Card> output = deck.FirstHandout();

            // Assert
            for (int i = 0; i < output.Count; i++)
            {
                Assert.AreEqual(answer[i].Value, output[i].Value);
            }
        }

        [TestMethod]
        public void TestShuffle()
        {
            // Arrange
            Deck deck = new Deck();
            List<Card> input = new List<Card> {
                new Card('a'),
                new Card('b'),
                new Card('c'),
                new Card('d'),
                new Card('e'),
                new Card('f'),
                new Card('g'),
                new Card('h'),
                new Card('i'),
                new Card('j'),
                new Card('k'),
                new Card('l'),
                new Card('m'),
                new Card('n'),
                new Card('o'),
                new Card('p'),
            };
            List<Card> input2 = new List<Card>();
            List<string> shuffledInput = new List<string>();
            List<string> shuffledInput2 = new List<string>();

            // Act
            input2 = deck.Shuffle(input);
            foreach (Card card in input)
            {
                shuffledInput.Add(card.Value.ToString());
            }
            input = deck.Shuffle(input);
            foreach (Card card in input)
            {
                shuffledInput2.Add(card.Value.ToString());
            }

            // Assert
            CollectionAssert.AreNotEqual(shuffledInput2, shuffledInput);

        }
    }
}
