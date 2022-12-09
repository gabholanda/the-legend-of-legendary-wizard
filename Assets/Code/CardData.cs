using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class CardData : ScriptableObject
{

    public Color color = Color.white;

    [TextArea(20, 20)]
    public string description;

    [Range(0, 9)]
    public int cost;

    [Range(-1, 1)]
    int rangeType = 0;
    [Range(-20, 0)]
    public int minrange;
    [Range(0, 20)]
    public int maxrange;
}
