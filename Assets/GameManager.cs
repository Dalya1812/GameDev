using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float countdownDuration = 10f; 
    public Text countdownText; 

    private void Start()
    {
        countdownText = GameObject.Find("Text").GetComponent<Text>();
        StartCoroutine(CountdownCoroutine());
    }

    private IEnumerator CountdownCoroutine()
    {
        float timeLeft = countdownDuration;

        while (timeLeft > 0)
        {
            UpdateCountdownText(timeLeft);
            yield return new WaitForSeconds(1f); 
            timeLeft--;
        }

        countdownText.text = "Time's up!";
        PerformAction();
    }
    private void UpdateCountdownText(float timeLeft)
    {
        if (countdownText != null)
        {
            countdownText.text = "Time left: " + Mathf.CeilToInt(timeLeft).ToString();
        }
        else
        {
            Debug.LogWarning("countdownText is not assigned.");
        }
    }

    private void PerformAction()
    {
        Debug.Log("Action performed!");
    }
}
