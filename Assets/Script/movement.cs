using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Animator playerAnim;
    public CharacterController controller;

    public float speed = 12f;
    public float gravity = -20f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    public AudioSource WalkingSound;


    Vector3 velocity;
    
    

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
        playerAnim.SetFloat("speed", 0);

        if (Input.GetKeyDown(KeyCode.W))
        { 
            playerAnim.SetFloat("speed", 1);
            WalkingSound.Play();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            playerAnim.SetFloat("speed", -1);
            WalkingSound.Play();
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            WalkingSound.Stop();
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            WalkingSound.Stop();
        }

    }
    
}