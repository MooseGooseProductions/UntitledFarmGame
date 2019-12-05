using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cards
{
    public enum Keyword
    {
        None,
        Prune, 
        Till,
        Harvest,
        Dig,
        Test,
        Seed,
        Treat,
        Fertilize,
        Irrigation
    };
    public enum Position
    {
        None,
        Deck,
        Hand,
        Discard
    }

    [CreateAssetMenu(fileName = "New Card", menuName = "Cards")]
    public class Card : ScriptableObject
    {
        public string CardName;
        public string CardDescription;

        public Sprite Art;

        public Position Location;
        public Dictionary<Keyword, int> Mechanics;

    }
}

