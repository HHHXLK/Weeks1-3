using UnityEngine;

public class ClockMinuteHand : MonoBehaviour
{
    public float Speed = 60f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotation = transform.rotation.eulerAngles;
        rotation.z -= Speed * Time.deltaTime;
        transform.eulerAngles = rotation;
    }
}
