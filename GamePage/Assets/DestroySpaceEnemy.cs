using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySpaceEnemy : MonoBehaviour
{
    public GameObject wxyz;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
            {
            Destroy(wxyz);
        }
    }
}
