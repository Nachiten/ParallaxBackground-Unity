using UnityEngine;

public class Parallax : MonoBehaviour
{
    private float length, startpos;
    private GameObject cam;
    public float parallaxEffect;
    
    void Start()
    {
        cam = GameObject.Find("Main Camera");

        startpos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;

        parallaxEffect = Mathf.Clamp(parallaxEffect, 0, 1);
    }

    private void Update()
    {
        var camPosition = cam.transform.position;
        
        float moveRelativeToCam = camPosition.x * (1 - parallaxEffect);
        float dist = camPosition.x * parallaxEffect;

        var transformPosition = transform.position;
        
        transform.position = new Vector3(startpos + dist, transformPosition.y, transformPosition.z);

        if (moveRelativeToCam > startpos + length)
            startpos += length;

        if (moveRelativeToCam < startpos - length)
            startpos -= length;
    }
}
