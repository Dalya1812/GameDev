using UnityEngine;
using TMPro;

public class CherryCounterUI : MonoBehaviour
{
    public TextMeshProUGUI cherryCountUI;
    private int cherryCount = 0;

    private void Start()
    {
        if (cherryCountUI == null)
        {
            Debug.LogError("TextMesh Pro UI Text component not assigned. ");
            return;
        }

        UpdateCherryCountUI();

        CherryEatingManager.CherryEaten += IncrementCherryCount;
    }

    private void OnDestroy()
    {
        CherryEatingManager.CherryEaten -= IncrementCherryCount;
    }

    private void IncrementCherryCount()
    {
        cherryCount++;
        UpdateCherryCountUI();
    }

    private void UpdateCherryCountUI()
    {
        cherryCountUI.text = "Cherries: " + cherryCount.ToString();
    }
}
