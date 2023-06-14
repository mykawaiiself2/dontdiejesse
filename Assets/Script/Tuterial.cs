using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuterial : MonoBehaviour
{
    public GameObject MovementTuterial, InteractiefTuterial;
    void Start()
    {
        MovementTuterial.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("interactiefstrigger"))
        {
            InteractiefTuterial.SetActive(true);
        }

        if (other.CompareTag("movementtrigger"))
        {
            MovementTuterial.SetActive(false);
        }
    }
}
