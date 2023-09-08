using UnityEngine;
using TMPro;

public class CherryCounterUI : MonoBehaviour
{
    public TextMeshPro cherryCountUI;
    private int cherryCount = 0;

    private void Start()
    {
        if (cherryCountUI == null)
        {
            Debug.LogError("TextMesh Pro UI Text component not assigned.");
            return;
        }

        UpdateCherryCountUI();
    }

    private void UpdateCherryCountUI()
    {
        cherryCountUI.text = "Cherries: " + cherryCount.ToString();
    }


    public void OnCherryEaten()
    {
        UpdateCherryCountUI();
    }
}
