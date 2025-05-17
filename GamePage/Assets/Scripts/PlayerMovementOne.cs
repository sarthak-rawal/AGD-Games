using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovementOne : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 50f;
    private Rigidbody2D rb;
    private Vector2 plydir;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float dirX = Input.GetAxis("Horizontal");
        plydir = new Vector2(dirX, 0f).normalized;
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(Mathf.Clamp(plydir.x, -1f, 1f) * movementSpeed * Time.fixedDeltaTime, 0f);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            SceneManager.LoadScene(7);
        }
    }
}
