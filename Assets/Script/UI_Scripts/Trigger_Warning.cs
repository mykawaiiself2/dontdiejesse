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
}