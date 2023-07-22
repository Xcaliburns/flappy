using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;

public class GameManager : MonoBehaviour


{
    public Player player;
    public TMP_Text scoretext;
    public GameObject playButton;
    public GameObject gameOver;
    public int score = 0;


    private void Awake()
    {
        Application.targetFrameRate = 60;// this is not required but its fix a limit
        Pause();
    }

    public void Play()
    {
        score = 0;
        scoretext.text = "score: " +score.ToString();       
        gameOver.SetActive(false);
        playButton.SetActive(false);
        Time.timeScale = 1f;
        player.enabled = true;

        Pipes[] pipes =FindObjectsOfType<Pipes>();
        for(int i=0;i<pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject) ;
        }
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        player.enabled = false;
        
    }
    public void GameOver()
    {
        Pause();
        gameOver.SetActive(true);
        playButton.SetActive(true);
       
    }

    public void IncreaseScore()
    {
        score ++;
        scoretext.text="score: " + score.ToString();
        
    }
}
