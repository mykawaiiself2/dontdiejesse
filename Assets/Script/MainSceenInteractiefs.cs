using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSceenInteractiefs : MonoBehaviour
{
     public GameObject ContralButton;
     public GameObject text1, text2, text3, text4;
    public int count;

     private void OnTriggerStay(Collider other)
     {
          if (other.CompareTag("Player"))
          {
              
              ContralButton.SetActive(true);
          }
     }
     private void OnTriggerExit(Collider other)
     {
          if (other.CompareTag("Player"))
          { 
               ContralButton.SetActive(false);
          }
     }
}
