using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalKill : MonoBehaviour
{
    [SerializeField] public float CountToKill, countTOGet;
    public float timer;
    public GameObject player;
    public GameObject cam2;
    public GameObject player2;
    public Animator m_Animator;
    public GameObject FControl;
    public GameObject triggerWarning;
    public float AnimationTimer;
    public bool kill, PistolRoom, ToxicationRoom;
    public PostProccesScript postProcces;
    public CanvasGroup myUIgroep;
    public bool fadeOut;
    public float TimerScene;
    
    
    void Update()
    {

        if(CountToKill >= countTOGet)
        {
            FControl.SetActive(true);
            timer += Time.deltaTime;
            if (timer >= 1) {
                if (Input.GetKeyDown(KeyCode.F))
                {
                    triggerWarning.SetActive(false);
                    m_Animator.SetTrigger("shoot");
                    player.SetActive(false);
                    cam2.SetActive(true);
                    player2.SetActive(true);
                    FControl.SetActive(false);
                    kill = true;
                    
                    
                }
            }
            if(kill == true)
            {
                FControl.SetActive(false);
                AnimationTimer += Time.deltaTime;
                if(AnimationTimer > 10)
                {
                    if (ToxicationRoom == true)
                    {
                        SceneManager.LoadScene("ToxicationFinalRoom");
                    }

                    if (PistolRoom == true)
                    {
                        if (fadeOut == true)
                        {
                            TimerScene += Time.deltaTime;
                            myUIgroep.alpha += Time.deltaTime;
                            if (TimerScene > 3)
                            {
                                SceneManager.LoadScene("PistonFinalKill");
                            }
                            
                        }
                        
                    }

                    
                }
            }
            
            
        }
    }
}
