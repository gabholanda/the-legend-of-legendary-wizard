using System.Collections;
using System.Collections.Generic;
using UnityEngine;


abstract class Card : MonoBehaviour
{

    CardData data;
    int amount;

    public abstract void Execute();
    public abstract void ExecuteCursed();

}
