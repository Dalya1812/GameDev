using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CherryEatingManager : MonoBehaviour
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
            Debug.Log("Nice");

            if (cherry != null)
            {
                cherry.SetActive(false);
            }
        }
    }
}
