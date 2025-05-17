
using UnityEngine;

public class ScrollBackground : MonoBehaviour
{
    public float scrollSpeed = 0.1f;
    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        float offset = Time.deltaTime * scrollSpeed;
        rend.material.mainTextureOffset = new Vector2(offset, 0);
    }
}
