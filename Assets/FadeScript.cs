using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeScript : MonoBehaviour
{
    public CanvasGroup myUIgroep;
    public bool fadeOut;

    // Update is called once per frame
    void Update()
    {
        if (fadeOut == true)
        {
            myUIgroep.alpha += Time.deltaTime;
        }
        
    }
}
