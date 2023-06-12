using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.PostProcessing;

public class PostProccesScript : MonoBehaviour
{
    private PostProcessVolume volume;
    private ColorGrading colorGradingLayer;

    // Start is called before the first frame update


    void Start()
    {




        volume = gameObject.GetComponent<PostProcessVolume>();
        volume.profile.TryGetSettings(out colorGradingLayer);

        colorGradingLayer.saturation.value = -100;
        //volume.profile.TryGet(out colorGrading);
    }

    public void ColorFullWorld()
    {
        colorGradingLayer.saturation.value = 0;
    }
}
