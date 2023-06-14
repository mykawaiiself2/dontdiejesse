using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

public class treinkill : MonoBehaviour
{
    public GameObject cam1, cam2;
    public float timer;
    public cutscenemovement cutscenemovement;
    public bool timerON;
    public GameObject player1, player2;

    void Update()
    {
        if (timerON == true)
        {
            timer += Time.deltaTime;
        }
        if (timer > 4)
        {
            print("hello");
            SceneManager.LoadScene("Main_Room");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            cam1.SetActive(false);
            cam2.SetActive(true);
            cutscenemovement.canmove = true;
            player1.SetActive(false);
            player2.SetActive(true);
            timerON = true;
            
        }
    }
}
