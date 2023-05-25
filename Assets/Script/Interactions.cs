using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactions : MonoBehaviour
{
   [SerializeField] private bool _FirstTrigger;
   //[SerializeField] private bool _SecondTrigger;
   public GameObject object1;
    //public GameObject object2;

    public Gun gun;
   public float secondtrigger;
    void Update()
    {
        if (_FirstTrigger == true)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                trigger();
            }
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("trigger"))
        {
            _FirstTrigger = true;
            
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("trigger"))
        {
            _FirstTrigger = false;
        }
    }
    void trigger()
    {
        object1.SetActive(false);
        _FirstTrigger = false;
        gun.CountToKill += 1f;
    }
}
