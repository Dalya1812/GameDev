using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinManager : MonoBehaviour
{
    public GameObject cherry; 

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
            Debug.Log("You Win");

            if (cherry != null)
            {
                cherry.SetActive(false);
            }
        }
    }
}
