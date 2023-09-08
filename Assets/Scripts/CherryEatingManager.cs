using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CherryEatingManager : MonoBehaviour
{
    public GameObject cherry;
    public TextMeshPro cherryCounterUI; 
    public int cherriesToWin = 4; 

    private int eatenCherries = 0;

    private void Start()
    {
        if (cherry != null)
        {
            cherry.SetActive(true);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (cherry != null)
            {
                cherry.SetActive(false);
                eatenCherries++;

                if (eatenCherries >= cherriesToWin)
                {
                    Debug.Log("YOU WIN");
                }

            }
        }
    }
}
