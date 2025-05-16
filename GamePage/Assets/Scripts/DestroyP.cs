using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DestroyP:MonoBehaviour
{
   
    void Start()
    {

    }
    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject);
        }
    }
}