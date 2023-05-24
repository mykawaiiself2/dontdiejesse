using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] float CountToKill;
    public GameObject player;
    public GameObject cam2;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            CountToKill += 1;
        }
        if(CountToKill >= 1)
        {
            player.SetActive(false);
            cam2.SetActive(true);
        }
    }
}
