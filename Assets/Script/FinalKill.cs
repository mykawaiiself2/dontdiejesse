using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalKill : MonoBehaviour
{
    [SerializeField] public float CountToKill;
    public float timer;
    public GameObject player;
    public GameObject cam2;
    public GameObject player2;
    public Animator m_Animator;
    public GameObject FControl;
    void Update()
    {

        if(CountToKill >= 2)
        {
            FControl.SetActive(true);
            timer += Time.deltaTime;
            if (timer >= 1) {
                if (Input.GetKeyDown(KeyCode.F))
                {
                    m_Animator.SetTrigger("shoot");
                    player.SetActive(false);
                    cam2.SetActive(true);
                    player2.SetActive(true);
                    FControl.SetActive(false);

                }
            }
            
            
        }
    }
}
