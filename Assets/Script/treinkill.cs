using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class treinkill : MonoBehaviour
{
    public GameObject cam1, cam2;
    public float timer;

    void Update()
    {
        timer += Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            cam1.SetActive(false);
            cam2.SetActive(true);
            if (timer > 4)
            {
                SceneManager.LoadScene("Main_Room");
            }
        }
    }
}
