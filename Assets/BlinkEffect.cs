using UnityEngine;
using System.Collections;
public class BlinkEffect : MonoBehaviour
{
    public GameObject objectToBlink;
    public float blinkInterval = 2f;

    private void Start()
    {
        StartCoroutine(BlinkObject());
    }

    IEnumerator BlinkObject()
    {
        while (true)
        {
            objectToBlink.SetActive(!objectToBlink.activeSelf);
            yield return new WaitForSeconds(blinkInterval);
        }
    }
}
