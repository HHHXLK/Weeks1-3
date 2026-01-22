using UnityEngine;

public class Teleport : MonoBehaviour
{
    public float teleportTime = 3f;
    public float timer = 0f;

    public float xMin = -7f;
    public float xMax = 7f;
    public float yMin = -3.5f;
    public float yMax = 3.5f;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        timer += 0.1f;

        if (timer >= teleportTime)
        {
            float x = Random.Range(xMin, xMax);
            float y = Random.Range(yMin, yMax);

            transform.position = new Vector3(x, y, transform.position.z);
            timer = 0f;
        }
    }
}
