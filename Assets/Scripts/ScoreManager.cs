using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public PlayerManager playerManager;
    public int score;
    private float _offset;
    public Text scoreText;
    
    public void Start()
    {
        if (playerManager.player != null)
        {
            _offset = playerManager.player.transform.position.z;
        }
    }

    void FixedUpdate()
    {
        if (playerManager.player != null)
        {
            score = (int)(playerManager.player.transform.position.z - _offset);
        }

        scoreText.text = "Score: " + score;
    }
}
