using UnityEngine;
using System.Collections.Generic;

public class Board : MonoBehaviour
{
    public int boardSize;
    public GameObject tile;
    public float gapBetweenTiles;
    public List<GameObject> tiles;

    private void Awake()
    {
        float increment = 0f;
        for (int i = 0; i < boardSize; i++)
        {
            tiles.Add(Instantiate(tile, new Vector3(i + increment, 0f, 0f), Quaternion.identity, transform));
            increment += gapBetweenTiles;
        }
    }

    public void Move(GameObject player, int pos)
    {
        PlayerController controller = player.GetComponent<PlayerController>();
        if (pos > tiles.Count)
        {
            pos = tiles.Count - 1;
        }
        player.transform.position = tiles[pos].transform.position + controller.offset;
        controller.currentPos = pos;
    }
}
