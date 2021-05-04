using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static float currentTime;
    public Text timerText;


    void Update()
    {
        currentTime += Time.deltaTime;
        timerText.text = currentTime.ToString("0");
    }
}
