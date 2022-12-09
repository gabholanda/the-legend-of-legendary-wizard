using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public int health;
    public string playerName;
    public List<Card> cards;

    public int currentPos = 0;
    public Vector3 offset = new Vector3(0, 0.2f, 0);
    public Deck deck;
    public int initialCardsAmount = 5;

    private void Awake()
    {
        //for (int i = 0; i < initialCardsAmount; i++)
        //{
        //    cards.Add(deck.DrawRandom());
        //}
    }

    public Card ChooseCard()
    {
        return cards[0];
    }
    public void ExecuteCard()
    {
        ChooseCard().Execute();
    }
    public void DiscardRandom()
    {
        int rngNum = Random.Range(0, cards.Count);
        cards.RemoveAt(rngNum);
    }
    public void DrawRandom()
    {
    }



}
