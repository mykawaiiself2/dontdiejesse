using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Interactions : MonoBehaviour
{
    [SerializeField] private bool _FirstTrigger;
    public Animator m_Animator;
    [SerializeField] private float stagecountergun;
    public GameObject FControl;
    public GameObject PickAbleObject;
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FControl.SetActive(true);
            if(stagecountergun == 0)
            {
                if (Input.GetKeyUp(KeyCode.F))
                {
                    m_Animator.SetTrigger("open");
                    stagecountergun = 1f;
                }
            }
            else if (stagecountergun == 1)
            {
                if (Input.GetKeyDown(KeyCode.F))
                {              
                    PickAbleObject.SetActive(false);
                }
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
