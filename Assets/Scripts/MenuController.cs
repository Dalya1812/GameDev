using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject canvas;
    public void StartGame()
    {
      canvas.SetActive(false);   
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}