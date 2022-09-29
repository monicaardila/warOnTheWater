using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class TimerScript : MonoBehaviour
{
    public float TimeLeft;
    public bool TimerOn = false;

    public Text TimerTxt;
    
   public GameObject Canvasl;
    void Start()
    {
        TimerOn = true;
        
    }

    void Update()
    {
        if(TimerOn)
        {
            if(TimeLeft > 0)
            {
                TimeLeft -= Time.deltaTime;
                updateTimer(TimeLeft);
            }
            else
            {
                Debug.Log("Time is UP!");
                TimeLeft = 0;
				Canvasl.SetActive (true);
                TimerOn = false;
            }
        }
    }

    void updateTimer(float currentTime)
    {
        currentTime += 1;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        TimerTxt.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

}