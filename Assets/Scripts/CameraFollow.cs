using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public PlayerManager playerManager;
    public Vector3 offset;
    private void FixedUpdate()
    {
        if (playerManager.player != null)
        {
            transform.position = playerManager.player.transform.position + offset;
        }
    }
}
