using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneySpawner : MonoBehaviour
{
    [SerializeField] private GameObject moneyPrefab;

    [SerializeField] public static int moneyToSpawn = 1;

    private float startTime = 5;
    private float repeatTime = 10;

    void Start()
    {
        InvokeRepeating("spawnSpike", startTime, repeatTime);
    }

    void Update()
    {

    }

    private void spawnSpike()
    {
        for (int i = 1; i <= moneyToSpawn; i++)
        {
            StartCoroutine(ExecuteAfterTime(Random.Range(5, 10)));
        }
    }

    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);

        Vector3 pos = new Vector3(Random.Range(-PlayerMovement.xLimit, PlayerMovement.xLimit), 6, 0);
        Instantiate(moneyPrefab, pos, moneyPrefab.transform.rotation);
    }
}
