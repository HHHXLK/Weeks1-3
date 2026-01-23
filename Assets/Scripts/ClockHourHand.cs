using UnityEngine;

public class ClockHourHand : MonoBehaviour
{
    public float HourHandSpeed = 60f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotation = transform.rotation.eulerAngles;
        rotation.z -= HourHandSpeed * Time.deltaTime;
        transform.eulerAngles = rotation;
    }
}
