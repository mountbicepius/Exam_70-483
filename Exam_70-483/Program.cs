using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exam_70_483
{
    public class Program
    {
        public static void Main()
        {
            Deck deck = new Deck(5);
            Card cr = new Card();
            cr.name = Console.ReadLine();
            foreach (var cr1 in deck.Cards)
            {
               Console.Write("\r{0}%", cr1.ToString());
            }
        }
    }
    class Card
    {
        public string name{ get; set; }
        public Card()
        {
            this.name = null;
        }
    }
    class Deck
    {
        private int _maximumNumberOfCards;
        public List<Card> Cards { get; set; }
        public Deck(int maximumNumberOfCards)
        {
            this._maximumNumberOfCards = maximumNumberOfCards;
            Cards = new List<Card>();
        }
    }
}