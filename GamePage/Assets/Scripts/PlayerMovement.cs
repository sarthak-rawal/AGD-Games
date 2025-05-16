using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement Settings")]
    [SerializeField] private float moveSpeed = 5f;

    private void Update()
    {
        
        float horizontalInput = Input.GetAxisRaw("Horizontal");

        
        Vector3 movement = new Vector3(horizontalInput * moveSpeed * Time.deltaTime, 0, 0);

        
        transform.position += movement;
    }
}