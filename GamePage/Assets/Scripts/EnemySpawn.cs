using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemy;
    public float maxX;
    public float maxY;
    public float minX;
    public float minY;
    public float timebetwnspwn;
    private float spwantime;
    // Update is called once per frame
    void Update()
    {
        if (Time.time > spwantime)
        {
            Spawn();
            spwantime = Time.time + timebetwnspwn;
        }
    }
    void Spawn()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        Instantiate(enemy, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }
}
