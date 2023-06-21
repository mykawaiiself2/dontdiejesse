using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerWarning : MonoBehaviour
{
    [SerializeField] private float _timer;
    [SerializeField] private float _maxTime = 15;
    [SerializeField] private bool _mouseIsMoving = false;
    public GameObject warningElement;
    [SerializeField] private bool _warningActive;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;
        MouseCheck();
        if (_timer >= _maxTime)
        {
            warningElement.SetActive(true);
            Time.timeScale = 0;
            _timer = 0;
            _warningActive = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
    
    private void MouseCheck()
    {
        if (Input.GetAxis("Mouse X") != 0 && Input.GetAxis("Mouse Y") != 0)
        {
            _mouseIsMoving = true;
            _timer = 0f;
        }
        else
        {
            _mouseIsMoving = false;
        }
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

    public void button()
    {
        _warningActive = false;
        warningElement.SetActive(false);
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
    }
    
}
