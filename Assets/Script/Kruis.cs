using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Kruis : MonoBehaviour
{
    public GameObject kruis;
    public TMP_Text KruisUITMPText1,KruisUITMPText2,KruisUITMPText3;
    public float number1, number2, number3;
    public float finalnumber1, finalnumber2, finalnumber3;
    public bool correct1, correct2, correct3;
    void Update()
    {
        KruisUITMPText1.text = number1.ToString();
        KruisUITMPText2.text = number2.ToString();
        KruisUITMPText3.text = number3.ToString();

        if (number1 == finalnumber1)
        {
            correct1 = true;
            
        }
        if (number2 == finalnumber2)
        {
            correct2 = true;
            
        }
        if (number3 == finalnumber3)
        {
            correct3 = true;
            
        }
        if (number1 <= finalnumber1 || number1 >= finalnumber1)
        {
            correct1 = false;
            
        }
        if (number2 <= finalnumber2)
        {
            correct2 = true;
            
        }
        if (number3 == finalnumber3)
        {
            correct3 = true;
            
        }

        if (number1 <= 0)
        {
            number1 = 0;
            
        }
        if (number2 <= 0)
        {
            number2 = 0;
            
        }
        if (number3 <= 0)
        {
            number3 = 0;
            
        }
        if (number1 >= 9)
        {
            number1 = 9;
            
        }
        if (number2 >= 9)
        {
            number2 = 9;
            
        }
        if (number3 >= 9)
        {
            number3 = 9;
            
        }

        if (correct1 == true && correct2 == true && correct3 == true)
        {
            //animatie play
        }
    }

    public void uperbutton1()
    {
        number1 += 1f;
    }
    public void uperbutton2()
    {
        number2 += 1f;
    }
    public void uperbutton3()
    {
        number3 += 1f;
    }
    public void lowerbutton1()
    {
        number1 -= 1f;
    }
    public void lowerbutton2()
    {
        number2 -= 1f;
    }
    public void lowerbutton3()
    {
        number3 -= 1f;
    }
}
