using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyFall : MonoBehaviour
{
    public static float fallSpeed = 2;

    private float deletePos = -6;
    private GameObject player;

    void Start()
    {
        player = GameObject.Find("Player");
    }

    void Update()
    {
        transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime * fallSpeed);
        if (transform.position.y < deletePos)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject != player)
        {
            return;
        }
        Destroy(gameObject);
        DisplayMoney.moneyDisplayed += 10;
    }
}
