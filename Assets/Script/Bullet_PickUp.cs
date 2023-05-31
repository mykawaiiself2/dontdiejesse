using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_PickUp : MonoBehaviour
{
    public PlayerInventory playerInventoryForBullet;


    public void BulletToInv()
    {
        playerInventoryForBullet.AddBullet();
        gameObject.SetActive(false);
    }
}
