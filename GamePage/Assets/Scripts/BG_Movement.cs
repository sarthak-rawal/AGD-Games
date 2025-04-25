using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG_Movement : MonoBehaviour
{
    public float speed = 0.1f; 
    private Vector2 offset;
    private Material material;

    private void Start()
    {
        material = GetComponent<Renderer>().material;
        offset = new Vector2(speed, 0);
    }

    private void Update()
    {
        material.mainTextureOffset += offset * Time.deltaTime;
    }
}