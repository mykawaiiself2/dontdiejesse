using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSceenInteractiefs : MonoBehaviour
{
     void Update()
     {
         if (Input.GetKeyDown(KeyCode.Q))
         {
             SceneManager.LoadScene("Main_Room"); 
         }
         
     }
}
