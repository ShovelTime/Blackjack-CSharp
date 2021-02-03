﻿using System;
using System.Collections.Generic;

namespace BlackJack
{
    public class Game
    {
        List<Player> Playerlist = new List<Player>();
        Dealer dealer = new Dealer();
        Deck deck;
        public Game()
        {
            deck = new Deck();
        }
        class Player
        {
            List<Card> CardList = new List<Card>();
            Card LastDrawn;
            public virtual void Draw()
            {

            }

        }
        class Dealer : Player
        {

        }
        class Card
        {
            CardType Value;
            SuitType suittype;
            public int BlackJackValue; // Find out what this is.

            public Card(CardType invalue, SuitType cardtype, int Blackjackval)
            {
                suittype = cardtype;
                Value = invalue;
                BlackJackValue = Math.Clamp(Blackjackval, 1, 10);
            }
        }
        public class Deck
        {
            Random rand = new Random();
           List<Card> CardList = new List<Card>(52); //used for shuffling and resetting the Deck.
           Queue<Card> CardDeck = new Queue<Card>();

            public Deck()
            {
                for(int x = 0; x < 4; x++)
                {
                    SuitType currtype = (SuitType)x;
                    for (int y = 1; y <= 13; y++)
                    {
                        CardList.Add(new Card((CardType) y,currtype, y));
                    }
                }
                
                
            }
            Queue<Card> Shuffle(Queue<Card> deck)
            {
                int decklength = deck.Count;
                int[] randused = new int[decklength];
                int nextrand;
                Card[] ShuffleList = deck.ToArray();
                deck.Clear();
                

            }
            Queue<Card> ResetAndShuffle(List<Card> list)
            {
                Queue<Card> NewDeck = new Queue<Card>();
                int decklength = list.Count;
                int[] randused = new int[decklength];
            }
        }
        public enum SuitType
        {
            Spades,
            Diamond,
            Club,
            Heart,
        }
        public enum GameState
        {
            Win,
            Lost,
            Playing,
            Tie,
            BlackJack,
        }
        public enum CardType : int
        {
            Ace = 1,
            Jack = 11,
            Queen = 12,
            King = 13,
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(); 
            Console.WriteLine("Ah Shit Here We Go Again");
            
        }
    }
}