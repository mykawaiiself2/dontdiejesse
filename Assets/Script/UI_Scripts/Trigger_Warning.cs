using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trigger_Warning : MonoBehaviour
{
    [SerializeField] private float _timer;
    [SerializeField] private float _maxTime = 5;
    [SerializeField] private bool _warningActive;
    [SerializeField] private bool _mouseIsMoving = false;
    private bool a_bool = true;
    private bool s_bool = true;
    private bool w_bool = true;
    private bool d_bool = true;
    public GameObject Tutorail, w_visaul, a_visaul, s_visaul, d_visaul;
    public GameObject warningElement;
    public Button mybutton;


    // Start is called before the first frame update
    void Start()
    {
        mybutton.onClick.AddListener(Resume);
    }


    // Update is called once per frame
    void Update()
    {
        MouseCheck();
        Tutorial();
    }

    private void FixedUpdate()
    {
        if (_timer >= _maxTime)
        {
            warningElement.SetActive(true);
            Time.timeScale = 0;
            _timer = 0;
            _warningActive = true;
            Cursor.lockState = CursorLockMode.None;
        }

        InputCheck();
    }

    private void Resume()
    {
        _warningActive = false;
        warningElement.SetActive(false);
        Time.timeScale = 1;
        // set tutorial stuff to true
        ActiveVisaulButtonPrompt();
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void InputCheck()
    {
        if (_warningActive)
        {
            return;
        }
        if (_mouseIsMoving)
        {
            _timer = 0;
            return;
        }
        if (!Input.anyKey)
        {
            _timer += Time.deltaTime;
        }
        else
        {
            _timer = 0;
        }
    }

    private void MouseCheck()
    {
        if (Input.GetAxis("Mouse X") != 0 && Input.GetAxis("Mouse Y") != 0)
        {
            _mouseIsMoving = true;
        }
        else
        {
            _mouseIsMoving = false;
        }
    }

    private void Tutorial()
    {
        if (Input.GetKeyDown("a") && a_bool)
        {
            a_visaul.SetActive(false);
            a_bool = false;
        }
        if(Input.GetKeyDown("d") && d_bool)
        {
            d_visaul.SetActive(false);
            d_bool = false;
        }
        if (Input.GetKeyDown("s") && s_bool)
        {
            s_visaul.SetActive(false);
            s_bool = false;
        }
        if (Input.GetKeyDown("w") && w_bool)
        {
            w_visaul.SetActive(false);
            w_bool = false;
        }
    }

    private void ActiveVisaulButtonPrompt()
    {
        a_bool = true;
        a_visaul.SetActive(true);
        d_bool = true;
        d_visaul.SetActive(true);
        s_bool = true;
        s_visaul.SetActive(true);
        w_bool = true;
        w_visaul.SetActive(true);
    }
}