using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeSpawner : MonoBehaviour
{
    [SerializeField] public GameObject[] spawnThings;

    [SerializeField] public static int spikesToSpawn = 1;

    private float startTime = 0;
    private float repeatTime = 2f;

    void Start()
    {
        InvokeRepeating("spawnSpike", startTime, repeatTime);
    }

    void Update()
    {
        
    }

    private void spawnSpike()
    {
        for (int i = 1; i <= spikesToSpawn; i++)
        {
            StartCoroutine(ExecuteAfterTime(Random.Range(1f, 3f)));
        }
    }

    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);

        int i = Random.Range(0, spawnThings.Length);

        Vector3 pos = new Vector3(Random.Range(-PlayerMovement.xLimit, PlayerMovement.xLimit), 6, 0);
        Instantiate(spawnThings[i], pos, spawnThings[i].transform.rotation);
    }
}
