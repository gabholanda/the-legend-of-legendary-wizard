using UnityEngine;

[CreateAssetMenu]
public class CardData : ScriptableObject
{
    public Color color = Color.white;

    [TextArea(20, 20)]
    public string description;

    [Range(0, 9)]
    public int cost;

    public GameObject prefab;


}
