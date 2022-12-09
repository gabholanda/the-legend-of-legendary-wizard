using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class GameManager : MonoBehaviourPunCallbacks
{
    public GameObject playerPrefab;
    public GameObject boardObj;
    public GameObject currentPlayer;
    public Board board;


    private void Start()
    {
        GameObject player = PhotonNetwork.Instantiate(playerPrefab.name, new Vector3(0, 0, 0), Quaternion.identity);
        player.GetComponent<PlayerController>().currentPos = 0;
        board.Move(player, 0);
        currentPlayer = player;
    }

    public void ThrowDice()
    {
        if (photonView.IsMine)
        {
            int result = Random.Range(1, 7);
            board.Move(currentPlayer, result + currentPlayer.GetComponent<PlayerController>().currentPos);
        }
    }

}
