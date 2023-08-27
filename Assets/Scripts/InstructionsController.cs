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
        instructionsCanvas.SetActive(true);
        mazeGameObject.SetActive(false);
        Invoke("HideInstructions", instructionsDuration);
    }

    private void HideInstructions()
    {
        instructionsCanvas.SetActive(false);
        mazeGameObject.SetActive(true);
    }
}
