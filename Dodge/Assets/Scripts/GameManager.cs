using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class GameManager : MonoBehaviour
{
    // 1. 게임이 종료되면 GameOverUI를 보여줘야함.
    // 2. 재시작 안내를 해준다 ~
    public TimerText Timer;

    public GameOver GameOverUI;

    public GameObject playerObj;
    
    private bool _isOver;


    private void Update()
    {
        // 만약에 게임이 종료가 되었다면
        // R키를 눌렀다면 재시작

        if(_isOver && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }

        if(playerObj.activeSelf == false)
        {
            End();
        }
    }

    public void End()
    {


        // 타이머 종료
        Timer.IsOn = false;



        //데이터 저장
        int savedBestTime = PlayerPrefs.GetInt("BestTime", 0);
        int bestTime = Math.Max((int)Timer.SurvivalTime, savedBestTime);

        if (bestTime < savedBestTime)
        {
            bestTime = savedBestTime;
        }

        PlayerPrefs.SetInt("BestTime", bestTime);

        GameOverUI.Activate(bestTime);

        if (PlayerPrefs.HasKey("BestTime"))
        {
            savedBestTime = PlayerPrefs.GetInt("BestTime");

            if(bestTime < savedBestTime)
            {
                PlayerPrefs.SetInt("BestTime", bestTime);
            }

            else
            {
                bestTime = savedBestTime;
            }
        }

        _isOver = true;
    }
}
