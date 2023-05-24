using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun_PickUp : MonoBehaviour
{
    string detectionTag = "Player";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(detectionTag))
        {
            other.gameObject.GetComponent<PlayerInventory>().AddGun();
            gameObject.SetActive(false);

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
