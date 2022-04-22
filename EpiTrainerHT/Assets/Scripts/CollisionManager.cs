using System.Collections;
using System.Collections.Generic;
using System.DirectoryServices.Protocols;
using TMPro;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    public GameObject ThighTooltip;
    public GameObject TipTooltip;
    private AudioSource audioSource;
    private AudioClip ButtonUp;
    public CountDownTimer contDownTimer; //getting reference from CountDownTimer class
    private TextMeshProUGUI removeTxt;
    public ChangeText changeTxt; //getting reference from ChangeText class
    public TextMeshProUGUI ChgTxt;
    private GameObject tempObject;
    
    

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
       
         tempObject = GameObject.Find("Canvas");
        contDownTimer = tempObject.GetComponent<CountDownTimer>();
       changeTxt = tempObject.GetComponent<ChangeText>();
        
        
        
        // changeTxt = tempObject.GetComponent<ChangeText>();


    }
    void OnCollisionEnter(Collision collision)
    {
        
        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "Dummy")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            ThighTooltip.SetActive(true);
            Destroy(TipTooltip);

            Rigidbody tipRidgidbody = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 forceDirection = collision.gameObject.transform.position;
             tipRidgidbody.AddForce(forceDirection * 10, ForceMode.Force);
             
             audioSource.Play();
             contDownTimer.enabled = true;
             




        }
        
    }

}
