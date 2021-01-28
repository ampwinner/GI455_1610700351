using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputText : MonoBehaviour
{
    public string theName;
    public GameObject inputField;
    public GameObject textDisplay;
    private string[] storeName = new string[5] { "Text", "Unity", "Come", "Under", "Pull" };

    public void StoreName()
    {
        theName = inputField.GetComponent<Text>().text;
        if (theName == storeName[0])
        {
            textDisplay.GetComponent<Text>().text = "[ " + theName + " ]" + " is found";
        }
        if (theName == storeName[1])
        {
            textDisplay.GetComponent<Text>().text = "[ " + theName + " ]" + " is found";
        }
        if (theName == storeName[2])
        {
            textDisplay.GetComponent<Text>().text = "[ " + theName + " ]" + " is found";
        }
        if (theName == storeName[3])
        {
            textDisplay.GetComponent<Text>().text = "[ " + theName + " ]" + " is found";
        }
        if (theName == storeName[4])
        {
            textDisplay.GetComponent<Text>().text = "[ " + theName + " ]" + " is found";
        }
        else
        {
            textDisplay.GetComponent<Text>().text = "[ " + theName + " ]" + " is not found";
        }


    }
}
