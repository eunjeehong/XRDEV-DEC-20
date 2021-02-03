using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRInput : MonoBehaviour
{
    public bool isLeftHand;   // If true, this is on the left hand, not , then right hand 

    public float triggerValue;
    public float gripValue;
    
    private string triggerAxis;
    private string gripAxis;



    // Start is called before the first frame update
    void Awake()
    {
        if (isLeftHand)
        {
            triggerAxis = "LeftTrigger";
            gripAxis = "LeftGrip";
        }
        else
        {
            triggerAxis = "RightTrigger";
            gripAxis = "RightGrip";
        }
    }

    // Update is called once per frame
    void Update()
    {
        triggerValue = Input.GetAxis(triggerAxis);
        gripValue = Input.GetAxis(gripAxis);
    }
}
