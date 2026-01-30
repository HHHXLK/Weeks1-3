using UnityEngine;

public class Eyes : MonoBehaviour
{
    public Transform ladybug;


    public float reactdistance = 2.0f;

    
    public float smallSize = 1.0f;
    public float bigSize = 1.4f;


    public float Speed = 6f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 eyePos = transform.position;
        Vector3 bugPos = ladybug.position;

        
        float distance = Vector3.Distance(eyePos, bugPos);

 
        float ESize;

        if (distance <= reactdistance)
        {
            ESize = bigSize;
        }
        else
        {
            ESize = smallSize;
        }

        Vector3 currentScale = transform.localScale;

        float newSize = Mathf.Lerp(currentScale.x, ESize, Speed * Time.deltaTime);

        transform.localScale = new Vector3(newSize,newSize,currentScale.z);
    }
}
