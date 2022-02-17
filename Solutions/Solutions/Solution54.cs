using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProjectEulerSolutions.Solutions
{
    public class Solution54 : ISolution
    {
        private enum Ranks {
            HighCard,
            OnePair,
            TwoPairs,
            ThreeOfAKind,
            Straight,
            Flush,
            FullHouse,
            FourOfAKind,
            StraightFlush,
            RoyalFlush
        }

        private static IDictionary<char, int> cardValues = new Dictionary<char, int>() {
            { '2', 2 },
            { '3', 3 },
            { '4', 4 },
            { '5', 5 },
            { '6', 6 },
            { '7', 7 },
            { '8', 8 },
            { '9', 9 },
            { 'T', 10 },
            { 'J', 11 },
            { 'Q', 12 },
            { 'K', 13 },
            { 'A', 14 }
        };

        public string GetSolution()
        {
            var hands = File.ReadAllLines("./assets/p054_poker.txt").Select(l => l.Replace(" ", string.Empty)).ToList();
            var count = 0;

            foreach (var hand in hands)
            {
                if (checkIfPlayerOneWins(hand)) count++;
            }

            return count.ToString();
        }

        private static bool checkIfPlayerOneWins(string hand)
        {
            var hand1 = hand.Substring(0, 10);
            var hand2 = hand.Substring(10);
            
            var rank1 = calculateHandRank(hand1);
            var rank2 = calculateHandRank(hand2);

            if (rank1 > rank2)
            {
                return true;
            } else if (rank1 == rank2) {
                return checkHighestCard(hand1, hand2, rank1);
            }
            return false;
        }

        private static Ranks calculateHandRank(string hand)
        {
            var cardValues = $"{hand[0]}{hand[2]}{hand[4]}{hand[6]}{hand[8]}";
            var cardSuits = $"{hand[1]}{hand[3]}{hand[5]}{hand[7]}{hand[9]}";

            var allSameSuit = cardSuits.Distinct().Count() == 1;
            var straight = isStraight(cardValues);

            if (allSameSuit)
            {
                if (cardValues.All(v => char.IsLetter(v))) return Ranks.RoyalFlush;

                if (straight) return Ranks.StraightFlush;
            }
            
            var groupedValues = cardValues.GroupBy(v => v);
            var four = groupedValues.Any(g => g.Count() == 4);
            var three = groupedValues.Any(g => g.Count() == 3);
            var pairs = groupedValues.Count(g => g.Count() == 2);

            if (four) return Ranks.FourOfAKind;

            if (three && pairs == 1) return Ranks.FullHouse;

            if (allSameSuit) return Ranks.Flush;

            if (straight) return Ranks.Straight;

            if (three) return Ranks.ThreeOfAKind;

            if (pairs == 2) return Ranks.TwoPairs;

            if (pairs == 1) return Ranks.OnePair;

            return Ranks.HighCard;
        }

        private static bool isStraight(string values)
        {
            var allValues = "23456789TJQKA";
            return allValues.Contains(new string(values.OrderBy(v => cardValues[v]).ToArray()));
        }

        private static bool checkHighestCard(string hand1, string hand2, Ranks rank)
        {
            var cardValues1 = $"{hand1[0]}{hand1[2]}{hand1[4]}{hand1[6]}{hand1[8]}";
            var cardValues2 = $"{hand2[0]}{hand2[2]}{hand2[4]}{hand2[6]}{hand2[8]}";
            var h1 = 0;
            var h2 = 0;

            switch (rank)
            {
                case Ranks.RoyalFlush:
                case Ranks.StraightFlush:
                case Ranks.Flush:
                case Ranks.Straight:
                case Ranks.HighCard:
                    for (int i = 0; i < 5; i++)
                    {
                        h1 = getNHighestValue(cardValues1, i);
                        h2 = getNHighestValue(cardValues2, i);
                        if (h1 > h2) return true;
                        if (h2 > h1) return false;
                    }
                    break;
                case Ranks.FullHouse:
                case Ranks.FourOfAKind:
                case Ranks.ThreeOfAKind:
                case Ranks.TwoPairs:
                case Ranks.OnePair:
                    var groupedValues1 = cardValues1.GroupBy(v => v).GroupBy(g => g.Count()).OrderByDescending(g => g.Key).Select(g => new string(g.Select(gg => gg.Key).ToArray()));
                    var groupedValues2 = cardValues2.GroupBy(v => v).GroupBy(g => g.Count()).OrderByDescending(g => g.Key).Select(g => new string(g.Select(gg => gg.Key).ToArray()));                    
                    for (int i = 0; i < groupedValues1.Count(); i++)
                    {
                        h1 = getNHighestValue(groupedValues1.ElementAt(i), 0);
                        h2 = getNHighestValue(groupedValues2.ElementAt(i), 0);
                        if (h1 > h2) return true;
                        if (h2 > h1) return false;                        
                    }                    
                    break;
            }

            return true;
        }

        private static int getNHighestValue(string values, int n)
        {
            return values.Select(v => cardValues[v]).OrderByDescending(v => v).ElementAt(n);
        }
    }
}