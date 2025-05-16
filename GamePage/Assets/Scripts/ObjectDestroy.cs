using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroy : MonoBehaviour
{
    public GameObject xyz;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(xyz);
    }
}
