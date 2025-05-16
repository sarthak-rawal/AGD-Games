using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [Header("Spawn Settings")]
    [SerializeField] private GameObject objectToSpawn;  
    [SerializeField] private float spawnInterval = 2f;  

    private float timer;

    private void Start()
    {
        timer = spawnInterval;  
    }

    private void Update()
    {
        
        timer -= Time.deltaTime;

       
        if (timer <= 0)
        {
            SpawnObject();
            timer = spawnInterval;
        }
    }

    private void SpawnObject()
    {
        if (objectToSpawn != null)
        {
            Instantiate(objectToSpawn, transform.position, Quaternion.identity);
        }
        else
        {
            Debug.LogWarning("No object to spawn assigned in the spawner!");
        }
    }
}