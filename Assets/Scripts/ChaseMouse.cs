using System.Net;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ChaseMouse : MonoBehaviour
{
    public Transform bugTarget;
    public float followSpeed = 5f;
    public float stopDistance = 0.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 current = transform.position;
        Vector3 target = bugTarget.position;
        float distance = Vector3.Distance(current, target);
        if (distance > stopDistance)
        {
            float t = followSpeed * Time.deltaTime;

            //Take a midpoint and have the frog gradually approach the insect.
            transform.position = Vector3.Lerp(current, target, t);
        }
    }
}
