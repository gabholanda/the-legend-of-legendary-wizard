using System.Linq;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Deck : ScriptableObject
{
    public List<Card> deckCards = new List<Card>();
    public Card DrawWithCost(float value)
    {
        List<Card> cardsWithCost = deckCards.FindAll(c => c.data.cost == value);

        Card card = cardsWithCost[Random.Range(0, cardsWithCost.Count)];
        deckCards.Remove(card);
        return card;
    }

    public Card DrawRandom()
    {
        Card card = deckCards[Random.Range(0, deckCards.Count)];
        deckCards.Remove(card);
        return card;
    }
    public Card DrawFromTop()
    {
        Card topCard = deckCards[0];
        deckCards.Remove(topCard);
        return topCard;
    }
    public void Shuffle()
    {
        System.Random rand = new System.Random();
        deckCards = deckCards.OrderBy(_ => rand.Next()).ToList();
    }
}
