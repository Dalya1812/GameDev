using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstructionsController : MonoBehaviour
{
    public GameObject instructionsCanvas;
    public GameObject mazeGameObject;
    public float instructionsDuration = 10f;
    private void Start()
    {
        ShowInstructions();
    }



    private void ShowInstructions()
    {
        if (instructionsCanvas != null)
        {
            instructionsCanvas.SetActive(true);
        }

        if (mazeGameObject != null)
        {
            mazeGameObject.SetActive(false);
        }

        Invoke("HideInstructions", instructionsDuration);
    }


    private void HideInstructions()
    {
        if (instructionsCanvas != null)
        {
            instructionsCanvas.SetActive(false);
        }

        if (mazeGameObject != null)
        {
            mazeGameObject.SetActive(true);
        }
    }


}
