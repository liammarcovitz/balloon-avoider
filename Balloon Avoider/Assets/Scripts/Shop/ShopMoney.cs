using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShopMoney : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;

    private int money;

    void Start()
    {
        money = PlayerPrefs.GetInt("money");
        text.text = "$" + money;
    }

    void Update()
    {
        money = PlayerPrefs.GetInt("money");
        text.text = "$" + money;
    }
}
