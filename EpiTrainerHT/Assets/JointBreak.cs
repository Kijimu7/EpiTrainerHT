using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JointBreak : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void onCollisionEnter(Collision collision)
    {
        OnJointBreak(0.1f);
    }
    void OnJointBreak(float breakForce)
    {
        Debug.Log("Joint broke" + breakForce);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
