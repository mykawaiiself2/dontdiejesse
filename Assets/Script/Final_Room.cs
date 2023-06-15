using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Final_Room : MonoBehaviour
{
    public float ani_timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ani_timer += Time.deltaTime;
        if(ani_timer > 7f)
        {
            SceneManager.LoadScene(0);
        }
    }
}
