using UnityEngine;

public class PlaceHolderMovement : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    public float speed = 5;    
    
    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        rigidBody.velocity = transform.right * speed;
    }
}
