using System;
using System.Collections;
using SelectionSort;

namespace DeckOfCards
{
    class Deck
    {
        static void Main(string[] args)
        {
            int[] deck = new int[52];
            Console.WriteLine("Enter number of cards");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter unique numbers of cards");
            for (int i = 0; i < count; i++)
            {
                deck[i] = Convert.ToInt32(Console.ReadLine());
            }
            deck = Program.Sort(deck, count);
            deck = Sequence(deck, count);
            Console.Write("deck of cards sequenced : ");
            for (int i = 0; i < count; i++)
            {
                Console.Write("{0}  ", deck[i]);
            }
            Console.ReadLine();
        }
        public static int[] Sequence(int[] deck, int count)
        {
            Queue locationQueue = new Queue();
            int[] sequencedDeck = new int[count];
            int loc;
            for (int i = 1; i <= count; i++)
            {
                locationQueue.Enqueue(i);
            }
            for (int i = 0; i < count; i++)
            {
                loc = GetLocation(locationQueue);
                sequencedDeck[loc - 1] = deck[i];
            }
            return sequencedDeck;
        }
        public static int GetLocation(Queue locationQueue)
        {
            int location = Convert.ToInt32(locationQueue.Dequeue());
            if (locationQueue.Count != 0)
            {
                int secodLocation = Convert.ToInt32(locationQueue.Dequeue());
                locationQueue.Enqueue(secodLocation);
            }
            return (location);
        }
    }
}
