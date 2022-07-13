using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class GameManager : MonoBehaviour
{
    // 1. ������ ����Ǹ� GameOverUI�� ���������.
    // 2. ����� �ȳ��� ���ش� ~
    public TimerText Timer;

    public GameOver GameOverUI;

    public GameObject playerObj;
    
    private bool _isOver;


    private void Update()
    {
        // ���࿡ ������ ���ᰡ �Ǿ��ٸ�
        // RŰ�� �����ٸ� �����

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


        // Ÿ�̸� ����
        Timer.IsOn = false;



        //������ ����
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
