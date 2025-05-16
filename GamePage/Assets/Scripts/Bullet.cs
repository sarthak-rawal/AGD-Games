using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 40;
    public Rigidbody2D rb;
    public GameObject enemy;

    // Use this for initialization
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("enemy") )
        {
            Destroy(gameObject);
        }
    }
}
