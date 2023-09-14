using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab; // Reference to the enemy prefab.
    public int numberOfEnemies = 3; // Number of enemies to spawn.
    public Vector2 spawnRange = new Vector2(-5f, 5f); // Range for random spawning.

    private void Start()
    {
        SpawnEnemies(numberOfEnemies);
    }

    private void SpawnEnemies(int count)
    {
        // Clear existing enemies.
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (var enemy in enemies)
        {
            Destroy(enemy);
        }

        for (int i = 0; i < count; i++)
        {
            if (enemyPrefab != null)
            {
                // Generate a random position within the specified range.
                Vector2 randomPosition = new Vector2(Random.Range(spawnRange.x, spawnRange.y), Random.Range(spawnRange.x, spawnRange.y));

                // Clone the enemy prefab at the random position with no specific rotation.
                GameObject enemy = Instantiate(enemyPrefab, randomPosition, Quaternion.identity);
                enemy.tag = "Enemy"; // Assign the "Enemy" tag to the spawned enemy.
            }
        }
    }
}
