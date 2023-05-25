using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] public float CountToKill;
    public GameObject player;
    public GameObject cam2;
    void Update()
    {
        if(CountToKill >= 1)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                player.SetActive(false);
                cam2.SetActive(true);
            }
            
        }
    }
}
