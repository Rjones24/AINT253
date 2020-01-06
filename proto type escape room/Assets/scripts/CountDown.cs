using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public int timeLeft = 300; 
    public Text countdown;

    void Start()
    {
        StartCoroutine("LoseTime");
        Time.timeScale = 1; 
    }
    void Update()
    {
        int min = Mathf.FloorToInt(timeLeft/60);
        int sec = Mathf.FloorToInt(timeLeft % 60);
        countdown.text = ("Time Remaining: " + min + ":" + sec.ToString("00"));

        if (timeLeft==0)
        {
            GameManagment.fail = true;
        }
    }
   
    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
        }
    }
}
