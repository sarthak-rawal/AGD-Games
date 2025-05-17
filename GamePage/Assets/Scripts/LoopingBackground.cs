
using UnityEngine;

public class LoopingBackground : MonoBehaviour
{
    public float scrollSpeed = 2f;
    public float resetPosition = 20f;
    public float startPosition = 20f;

    void Update()
    {
        transform.Translate(Vector2.left * scrollSpeed * Time.deltaTime);

        if (transform.position.x < -resetPosition)
        {
            Vector3 newPos = new Vector3(startPosition, transform.position.y, transform.position.z);
            transform.position = newPos;
        }
    }
}
