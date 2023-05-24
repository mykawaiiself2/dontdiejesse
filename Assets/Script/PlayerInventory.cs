using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    private bool gotGun = false;
    private bool gotBullet = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gotGun && gotBullet)
        {
            Debug.Log("you can unalive yourself. YEAH!!!!");
            // show button prompt for suicide
            // if done play gun shoot animation with flag
            // then go to main end animation
            // teleport player to start
        }
    }

    public void AddGun()
    {
        gotGun = true;
        Debug.Log("got gun");
        // cross out something on the check list
    }

    public void AddBullet()
    {
        gotBullet = true;
        Debug.Log("got bullet");
        // cross out something on the check list
    }
}
