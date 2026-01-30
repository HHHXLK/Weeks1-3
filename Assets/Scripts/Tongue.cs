using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Tonw : MonoBehaviour
{
    public AnimationCurve lickCurve;
    public Transform head;
    public Transform ladybug;

    public float lickStartDistance = 1.2f;  
    public float retractDistance = 0.1f;    
    public float duration = 0.25f;  
    public float retractSpeed = 2f;

    private bool licking = false;
    private bool retracting = true;          // Initially in the default retracted state
    private float lickTimer = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 tonguePos = transform.position;
        Vector3 headPos = head.position;
        Vector3 bugPos = ladybug.position;

        float distToBug = Vector3.Distance(tonguePos, bugPos);
        float distToHead = Vector3.Distance(tonguePos, headPos);

        if (licking)
        {
            lickTimer += Time.deltaTime;

            float t01 = lickTimer / duration;
            if (t01 < 0f) t01 = 0f;
            if (t01 > 1f) t01 = 1f;

            float curvedT = lickCurve.Evaluate(t01);
            transform.position = Vector3.Lerp(tonguePos, bugPos, curvedT);

            if (lickTimer >= duration)
            {
                licking = false;
                retracting = true;
                lickTimer = 0f;
            }

        }

        //If retracting: Lerp tongue to track head
        if (retracting)
        {
            transform.position = Vector3.Lerp(tonguePos, headPos, retractSpeed * Time.deltaTime);

            if (distToHead <= retractDistance)
            {
                retracting = false;
            }
        }


        if (distToBug <= lickStartDistance)
        {
            licking = true;
            retracting = false;
            lickTimer = 0f;
            return;
        }

        // By default, the tongue remains pressed against the upper lip.
        transform.position = headPos;
    }
}
