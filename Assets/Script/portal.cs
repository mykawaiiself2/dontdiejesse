using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class portal : MonoBehaviour
{

    public bool Portal1, Portal2, portal3;
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("hello there");
        if (Portal1 == true)
        {
            SceneManager.LoadScene("Pistol_scene");
        }
    }
    
}
