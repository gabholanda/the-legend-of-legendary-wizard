using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    List<Card> deckcards= new List<Card>();
    //Card drawWithCost(float value) { }
    Card drawFromTop() {
        return deckcards[0];
    }
    void Shuffle() { }
}
