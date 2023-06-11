using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public AudioSource _AudioSource1;
    public AudioSource _AudioSource2;

    void Start()
    {

        _AudioSource1.Play();

    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.S))
        {

            if (_AudioSource1.isPlaying)
            {

                _AudioSource1.Stop();

                _AudioSource2.Play();

            }

            else
            {

                _AudioSource2.Stop();

                _AudioSource1.Play();

            }

        }

    }

}

