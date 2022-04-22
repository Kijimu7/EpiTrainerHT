using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
   //loading Main Scene
   public void StartBtn()
   {
      //Loading Training Scene
      SceneManager.LoadScene("Training");
   }
}
