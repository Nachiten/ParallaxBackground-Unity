using UnityEngine;
// ReSharper disable Unity.InefficientPropertyAccess

public class Parallax : MonoBehaviour
{
    public float parallaxEffect;
    public float xMax = 282;
    
    private const float speed = 200;
    
    private Rigidbody rigidBody;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        parallaxEffect = Mathf.Clamp(1 - parallaxEffect, 0, 1);
    }

    private void Update()
    {
        // Calculo y aplico el vector velocidad en base a speed y efecto paralax
        rigidBody.velocity = transform.right * (speed * parallaxEffect);

        // Si me pase del borde vuelvo al inicio
        if (Vector3.Distance(transform.position, Vector3.zero) >= xMax)
            //transform.localPosition = new Vector3(0, transform.localPosition.y, transform.localPosition.z);
            transform.position -= transform.right * xMax;
    }
}
