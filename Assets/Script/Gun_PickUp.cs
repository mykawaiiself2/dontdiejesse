using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun_PickUp : MonoBehaviour
{
    public PlayerInventory playerInventoryForGun;
    

    public void GunToInv()
    {
        playerInventoryForGun.AddGun();
        gameObject.SetActive(false);
    }
}
