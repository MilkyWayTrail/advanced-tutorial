using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public GameObject player;
    public GameObject playerPrefab;
    public Transform spawnPoint;
    
    void Update()
    {
        if (player == null)
        {
            player = Instantiate(playerPrefab, spawnPoint.position, spawnPoint.rotation);
        }    
    }
}
