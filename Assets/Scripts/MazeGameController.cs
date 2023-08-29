using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeGameController : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject goalPrefab;
    [SerializeField] private GameObject maze;

    private List<GameObject> cherries = new List<GameObject>();
    private int cherriesCollected = 0;
    private bool introFinished = false;

    private void Start()
    {
 
        introFinished = true;
        PlaceCherries(3);

    }

    private void Update()
    {

    }

    private void PlaceCherries(int count)
    {
        foreach (var cherry in cherries)
        {
            Destroy(cherry);
        }
        cherries.Clear();

        for (int i = 0; i < count; i++)
        {
            Vector2 randomPosition;

            randomPosition = new Vector2(Random.Range(-5f, 5f), Random.Range(-5f, 5f)); 
            GameObject cherry = Instantiate(goalPrefab, randomPosition, Quaternion.identity);
            cherries.Add(cherry);
        }
    }

    public void PlayerReachedCherry(GameObject cherry)
    {
        cherriesCollected++;
        Destroy(cherry);

        if (cherriesCollected < 3)
        {
            PlaceCherries(1); 
        }
        else
        {
            Debug.Log("Congratulations! You collected all cherries!");
        }
    }
}
