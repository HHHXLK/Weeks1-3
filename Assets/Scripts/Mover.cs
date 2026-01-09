using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speed = 0.02f;
    public float xMax = 10f;
    public float xMin = -10f;

    bool movingRight = true;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moverXPos = transform.position;
        if (movingRight)
        {
            moverXPos.x = moverXPos.x + speed;
            
            if (moverXPos.x > xMax) 
            {
                movingRight = false;
            }
        }
        else
        {
            {
                moverXPos.x = moverXPos.x - speed;
                
                if (moverXPos.x < xMin)
                {
                    movingRight = true;
                }
            }
        }
        transform.position = moverXPos;
    }
}
