using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cards
{
    //Contrary to pupular belief, the deck is going to handle all the cards the player owns.
    public class Deck : MonoBehaviour
    {
        public List<Card> DeckList;
        private List<Card> inDeck;
        private List<Card> inHand;
        private List<Card> inDiscard;

        void Shuffle()
        {//Fisher-Yates Suffle, apparently
            for (int i = 0; i < DeckList.Count; i++)
            {
                Card temp = DeckList[i];
                int randomIndex = Random.Range(i, DeckList.Count);
                DeckList[i] = DeckList[randomIndex];
                DeckList[randomIndex] = temp;
            }
        }

        void FillDeck()
        {
            inDeck.Capacity = DeckList.Count;
            inDeck.AddRange(DeckList);
        }

        void DrawCard()
        {
            inHand.Add(inDeck[0]);
            inDeck.RemoveAt(0);

            //Add UI animations;
        }

        void Discard(Card card)
        {
            inHand.Remove(card);
            inDiscard.Add(card);
        }

    }

}
