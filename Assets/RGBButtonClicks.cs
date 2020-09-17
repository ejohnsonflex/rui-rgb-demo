using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RGBButtonClicks : MonoBehaviour
{
    [SerializeField] Text statusText;
  
    public void RedButton ()
    {
        statusText.color = Color.red;
        statusText.text = ("Red button click captured");
    }

    public void BlueButton()
    {
        statusText.color = Color.blue;
        statusText.text = "Blue button click captured";
    }

    public void GreenButton()
    {
        statusText.color = Color.green;
        statusText.text = "Green button click captured";
    }

    public void OnApplicationQuit()
    {
        Debug.Log("Thank you, exiting in 5 seconds...");
        Application.Quit();
    }
}
