using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChangeText : MonoBehaviour
{
    private TextMeshProUGUI removeTxt;
    public TextMeshProUGUI ChgTxt;
   
    // Start is called before the first frame update
    void Start()
    {
       // removeTxt = GameObject.Find("TimerText").GetComponent<TextMeshProUGUI>();
       ChgTxt = GameObject.Find("Remove").GetComponent<TextMeshProUGUI>();
   
        
    }

    // Update is called once per frame
    void Update()
    {
        removeTxt.text = "Remove the Epipen";
    }
}
