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
    public GameObject PickAbleObject, Fade;
    public bool HasGun, CountUp, buttonActive, inRange;
    public FinalKill kill;
    void Update()
    {
        if (inRange)
        {
            FControl.SetActive(true);
            if (stagecountergun == 0)
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
                        buttonActive = false;
                        if (CountUp == true)
                        {
                            kill.CountToKill += 1;
                            CountUp = false;
                            Fade.SetActive(true);
                        }

                    }
                }
            }

            if (buttonActive == false)
            {
                FControl.SetActive(false);
            }
            {
                
            }
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
            FControl.SetActive(false);
            inRange = false;
        }
    }
    
}
