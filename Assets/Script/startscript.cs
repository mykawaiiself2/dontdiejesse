using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startscript : MonoBehaviour
{
    public void startgame()
    {
        SceneManager.LoadScene("Pistol_scene");
    }
}
