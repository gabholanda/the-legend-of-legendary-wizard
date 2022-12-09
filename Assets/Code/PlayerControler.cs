using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{

    int health;
    string name;
    Color color;
    List<Card> cards;
    Deck deck;


    Card chooseCard() { return cards[0] }
    void executeCard() { chooseCard().Execute(); }
    void discardRandom() {
        int max = cards.Count;
        int rngNum = RandomNumberGenerator.GetInt32(0, max);

        cards.RemoveAt(rngNum) }
    void drawRandom() { }



}
