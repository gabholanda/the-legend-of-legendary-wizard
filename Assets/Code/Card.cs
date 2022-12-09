using UnityEngine;


public abstract class Card : MonoBehaviour
{

    public CardData data;
    public int amount;

    public abstract void Execute();
    public abstract void ExecuteCursed();

}
