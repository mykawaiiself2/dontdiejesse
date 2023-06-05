using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class mouselook : MonoBehaviour
{
    // varibles for looking with camera
    public float mouseSensitivity = 200f;
    public Transform playerBody;
    float xRotation = 0f;

    // varibles for interactions
    public GameObject interactionUI;
    public TMP_Text interactionUIText;
    public float playerActivatedDistance; // the length of the interaction ray
    


    // Start is called before the first frame update
    void Start()
    {
        // locks the cursors in place
        //Cursor.lockState = CursorLockMode.Locked;

    }

    // Update is called once per frame
    void Update()
    {
        // is responsible for looking around with the camera
        LookingWithCamera();
        InteractWithObject();
    }

    private void LookingWithCamera()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }

    private void InteractWithObject()
    {
        // make a cursor for the player so that they can see when they are looking at it.
        RaycastHit hitInfo;
        bool didItHit = Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hitInfo, playerActivatedDistance);
        if (didItHit)
        {
            GameObject hitGameObject = hitInfo.collider.gameObject;
            if (hitGameObject.CompareTag("Closet"))
            {
                interactionUI.SetActive(true);
                interactionUIText.text = "Open Closet";
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hitInfo.distance, Color.yellow);
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hitGameObject.GetComponent<ClosetInteraction>().OpenCloset();
                    //code here for if you want to disable this after opening up the closet
                }
                Debug.Log("Did Hit");
                
            }
            else if (hitGameObject.CompareTag("Bullet"))
            {
                interactionUI.SetActive(true);
                interactionUIText.text = "Pick Up Bullet";
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hitGameObject.GetComponent<Bullet_PickUp>().BulletToInv();
                }
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hitInfo.distance, Color.yellow);
            }
            else if (hitGameObject.CompareTag("Gun"))
            {
              interactionUI.SetActive(true);
               interactionUIText.text = "Pick Up Gun";
                if (Input.GetKeyDown(KeyCode.E))
                {
                   hitGameObject.GetComponent<Gun_PickUp>().GunToInv();
                }
            }
            else
            {
                if (interactionUI.activeSelf == true)
                {
                    interactionUI.SetActive(false);
                }
                //Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward), Color.black);
                //Debug.Log("Did not Hit");
            }
        }
        else
        {
            if (interactionUI.activeSelf == true)
            {
              interactionUI.SetActive(false);
            }
        }
    }
}