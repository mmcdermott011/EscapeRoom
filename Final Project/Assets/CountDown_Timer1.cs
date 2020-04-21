﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown_Timer1 : MonoBehaviour
{
    [SerializeField] private Text uiText;
    [SerializeField] private float mainTimer;

    private float timer;
    private float startTime;
    private bool canCount = true;
    private bool doOnce = false;
    void Start()
    {
        startTime = Time.deltaTime;
        timer = mainTimer;
    }
    void Update()
    {
        
        if (timer >= 0.0f && canCount)
        {
            timer -= Time.deltaTime;
            string minutes = ((int)timer / 60).ToString();
            string seconds = (timer % 60).ToString("f2");
            uiText.text = minutes + ":" + seconds;
        }

        else if (timer <= 0.0f && !doOnce)
        {
            canCount = false;
            doOnce = true;
            uiText.text = "0.00f";
            timer = 0.0f;
            GameOver();
        }

        void GameOver()
        {
            //Load Game Over Screen
        }

    }
}