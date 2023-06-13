using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSceenInteractiefs : MonoBehaviour
{
     public GameObject ContralButton;
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
