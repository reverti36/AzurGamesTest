using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public Slider TimerSlider;
    public TextMeshProUGUI timerText;

    public FinishScript finishScript;
    //public Text timerText;

    public float gameTime;

    private bool stopTimer;
    // Start is called before the first frame update
    void Start()
    {
        stopTimer = false;
        TimerSlider.maxValue = gameTime;
        TimerSlider.value = gameTime;
    }

    // Update is called once per frame
    void Update()
    {
        float time = gameTime - Time.time;
        int minutes =  Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time - minutes * 60f);

        string textTime = string.Format("{0:0}:{1:00}", minutes, seconds);
        
        if (time <= 0 && stopTimer == false)
        {
            stopTimer = true;
            finishScript.PlayFail();
        }

        if (stopTimer == false)
        {
            timerText.text = textTime;
            TimerSlider.value = time;
        }
    }

    public void StopTimer()
    {
        stopTimer = true;
    }
}
