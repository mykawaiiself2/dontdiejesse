using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class portal : MonoBehaviour
{

    public bool Portal1, Portal2, Portal3;
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (Portal1 == true)
        {
            SceneManager.LoadScene("Pistol_scene");
        }
        if (Portal2 == true)
        {
            SceneManager.LoadScene("Toxication_scene");
        }
        if (Portal3 == true)
        {
            SceneManager.LoadScene("TreinStation_scene");
        }
    }
}
