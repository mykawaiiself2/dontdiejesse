using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_PickUp : MonoBehaviour
{
    string detectionTag = "Player";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(detectionTag))
        {
            other.gameObject.GetComponent<PlayerInventory>().AddBullet();
            gameObject.SetActive(false);
        }
    }
}
