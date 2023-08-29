using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public TextMeshProUGUI timerText;
    public float totalTime = 60f; 

    private void Start()
    {
        StartCoroutine(StartTimer());
    }

    private IEnumerator StartTimer()
    {
        float remainingTime = totalTime;

        while (remainingTime > 0f)
        {
            timerText.text = "Time: " + Mathf.FloorToInt(remainingTime).ToString();

            yield return new WaitForSeconds(1f);

            remainingTime -= 1f;
        }

        timerText.text = "Time's up!";
    }
}


