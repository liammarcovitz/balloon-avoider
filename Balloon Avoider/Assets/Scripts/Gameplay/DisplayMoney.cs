using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayMoney : MonoBehaviour
{
    public static int moneyDisplayed;

    [SerializeField] private TextMeshProUGUI textObject;
    private string text;

    void Start()
    {
        
    }

    void Update()
    {
        text = "$" + moneyDisplayed.ToString();
        textObject.text = text;
    }
}
