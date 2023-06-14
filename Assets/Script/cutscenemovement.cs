using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutscenemovement : MonoBehaviour
{
    public Transform targer;
    public float speed;
    public bool canmove;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canmove ==  true)
        {
            float step = speed * Time.deltaTime;
        
            transform.position = Vector3.MoveTowards(transform.position, targer.position, step);
        }
        
    }
}
