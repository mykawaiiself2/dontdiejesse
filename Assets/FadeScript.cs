using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeScript : MonoBehaviour
{
    public CanvasGroup myUIgroep;
    public bool fadeOut;
    public GameObject text;
    public float timer;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        myUIgroep.alpha += Time.deltaTime;
        if(timer > 2)
        {
            fadeOut = true;
            myUIgroep.alpha -= Time.deltaTime;
            
            if(timer > 4)
            {
                text.SetActive(false);
            }
        }
        if(fadeOut == false)
        {
            myUIgroep.alpha += Time.deltaTime;
        }

    }
}
