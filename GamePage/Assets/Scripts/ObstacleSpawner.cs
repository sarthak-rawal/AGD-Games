using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab; // Drag your obstacle prefab here
    public float spawnInterval = 2f;   // Time between spawns
    public float spawnX = 10f;         // X position where obstacles appear
    public float minY = -1f;           // Y range for randomness
    public float maxY = 1f;
    public float moveSpeed = 5f;       // Speed at which obstacles move left
    public float destroyX = -20f;      // X position to destroy the obstacle

    private float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnObstacle();
            timer = 0f;
        }
    }

    void SpawnObstacle()
    {
        float spawnY = Random.Range(minY, maxY);
        Vector3 spawnPosition = new Vector3(spawnX, spawnY, 0);
        GameObject obstacle = Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity);

        // Add movement behavior right here
        obstacle.AddComponent<ObstacleMover>().Initialize(moveSpeed, destroyX);
    }

    // Internal class to handle movement
    private class ObstacleMover : MonoBehaviour
    {
        float speed;
        float destroyX;

        public void Initialize(float speed, float destroyX)
        {
            this.speed = speed;
            this.destroyX = destroyX;
        }

        void Update()
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);

            if (transform.position.x < destroyX)
            {
                Destroy(gameObject);
            }
        }
    }
}
