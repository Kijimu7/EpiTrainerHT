using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    public GameObject ThighTooltip;
    public GameObject TipTooltip;
    void OnCollisionEnter(Collision collision)
    {
     

        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "Dummy")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            ThighTooltip.SetActive(true);
            Destroy(TipTooltip);
            
            
            
        }
    }

}
