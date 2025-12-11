using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    //variables
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime;

   

    void Update()
    {
        //timer
        if (remainingTime > 0)
        {
            //if time remaing countinue countdown
            remainingTime -= Time.deltaTime;
        }
        else 
        { 
            //if time 0 load the GameOver scene
            remainingTime = 0;
            SceneManager.LoadScene("GameOver");
        }
        // change format of the timer
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{00:00}:{01:00}", minutes, seconds);
    }
}

