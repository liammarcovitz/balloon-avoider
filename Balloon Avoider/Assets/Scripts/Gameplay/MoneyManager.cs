using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{

    public static int money;

    void Start()
    {
        money = PlayerPrefs.GetInt("money");
        money = round(money);
        PlayerPrefs.SetInt("money", money);
    }

    void Update()
    {
        PlayerPrefs.SetInt("money", money);
    }

    private int round(int n)
    {
        // Smaller multiple
        int a = (n / 10) * 10;

        // Larger multiple
        int b = a + 10;

        // Return of closest of two
        return (n - a > b - n) ? b : a;
    }
}
