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
    public bool HasGun;
    public FinalKill kill;
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

            if (HasGun == true)
            {
                if (stagecountergun == 1)
                {
                    if (Input.GetKeyDown(KeyCode.F))
                    {
                        PickAbleObject.SetActive(false);
                        FControl.SetActive(false);
                        kill.CountToKill += 1; 
                    }
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
