using JetBrains.Annotations;
using UnityEngine;

public class BouncingBall : MonoBehaviour
{
    public float Xspeed = 0.02f;
    public float Yspeed = 0.02f;
    public Camera gameCamera;
    public float xMax;
    public float xMin;
    public float yMax;
    public float yMin;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        Vector3 BallPos = transform.position;
        BallPos.x += Xspeed * Time.deltaTime;
        BallPos.y += Yspeed * Time.deltaTime;

        transform.position = BallPos;

        Vector3 screenTransformPosition = gameCamera.WorldToScreenPoint(transform.position);
        xMax = Screen.width;
        xMin = 0;
        yMax = Screen.height;
        yMin = 0;


        if (xMax < screenTransformPosition.x)
        {
            Xspeed *= -1;
        }

        if (xMin > screenTransformPosition.x)
        {
            Xspeed *= -1;
        }

        if (yMax < screenTransformPosition.y)
        {
            Yspeed *= -1;
        }

        if (yMin > screenTransformPosition.y)
        {
            Yspeed *= -1;
        }

    }
}
