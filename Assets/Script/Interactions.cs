using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Interactions : MonoBehaviour
{
    [SerializeField] private bool _FirstTrigger;
    public Animator m_Animator;
    [SerializeField] private float stagecountergun, gunpickuptimer;
    public GameObject FControl;
    public GameObject PickAbleObject, Fade;
    public bool HasGun, CountUp, buttonActive, inRange;
    public FinalKill kill;
    public AudioSource OpeningLocked;
    void Update()
    {
        gunpickuptimer += Time.deltaTime;
        if (inRange)
        {
            FControl.SetActive(true);
            if (stagecountergun == 0)
            {
                if (Input.GetKeyUp(KeyCode.F))
                {
                    m_Animator.SetTrigger("open");
                    stagecountergun = 1f;
                    gunpickuptimer = 0f;
                    OpeningLocked.Play();
                }
            }

            if (HasGun == true)
            {
                if (stagecountergun == 1)
                {
                    if(gunpickuptimer >= 2)
                    {
                        if (Input.GetKeyDown(KeyCode.F))
                        {
                            OpeningLocked.Play();
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
