using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LvlManager : MonoBehaviour
{
    public static LvlManager instanse;
    public Text WinText;

    private int elementCount = 0;
    public int ElementCount {
        get => elementCount;
        set { 
            elementCount = value; 
            if (elementCount == 0)
            {
                WinText.text = "Win";
            }
        }
    }

    private void Awake()
    {
        if (instanse == null)
            instanse = this;
        else
            Destroy(this);
    }
}
