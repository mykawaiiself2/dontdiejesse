using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainSceenInteractiefs : MonoBehaviour
{
     public GameObject ContralButton;
     public GameObject text1, text2, text3, text4;
    public float count;
    private bool inRange;

     void Update()
    {
        if (inRange)
        {
            if (Input.GetKeyUp(KeyCode.F))
            {
                count += 1f;
            }
            ContralButton.SetActive(true);
        }

         if (count == 1)
         {
              text4.SetActive(false);
              text1.SetActive(true);
         }
        else if (count == 2)
         {
              text1.SetActive(false);
              text2.SetActive(true);
         }
         else if (count == 3)
         {
              text2.SetActive(false);
              text3.SetActive(true);
         } 
         else if (count == 4)
         {
              text3.SetActive(false);
              text4.SetActive(true);
         }


         if (count >= 5)
         {
              count = 1f;
         }
              
         
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inRange = true;
        }
    }

     private void OnTriggerExit(Collider other)
     {
          if (other.CompareTag("Player"))
          { 
               ContralButton.SetActive(false);
               inRange = false;
        }
     }
}
