using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pillpickup : MonoBehaviour
{
    [SerializeField] private bool _FirstTrigger, buttonActive;
    public GameObject FControl;
    public GameObject PickAbleObject;
    public FinalKill kill;
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (buttonActive == true)
            {
                FControl.SetActive(true);
            }
            
            if (Input.GetKeyDown(KeyCode.F)) 
            {
                PickAbleObject.SetActive(false);
                buttonActive = false;
                kill.CountToKill += 1;
            }
        }
    }
            
        
    
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FControl.SetActive(false);
        }
    }
}    


