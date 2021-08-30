using UnityEngine;

// ReSharper disable Unity.InefficientPropertyAccess

public class Parallax : MonoBehaviour
{
    public float parallaxEffect;
    public float xMax = 282;
    public float speed = 100;
    
    private Rigidbody2D rigidBody;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float parallaxEffectValue = Mathf.Clamp(1 - parallaxEffect, 0, 1);

        Vector3 speedVector = transform.right * speed * parallaxEffectValue;

        Debug.Log("Speed vector: " + speedVector);
        
        // Establezco una velocidad en base a speed y al efecto paralax
        rigidBody.velocity = speedVector;

        // Si me pase del borde vuelvo al inicio
        if (transform.position.x >= xMax)
            transform.position = new Vector3(0, transform.position.y, transform.position.z);

        //transform.position = new Vector3(startpos + dist, transformPosition.y, transformPosition.z);
    }
}
