using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyIncreaser : MonoBehaviour
{

    private bool canContinueFallSpeed = true;
    private bool canContinueSpikeNum = true;

    void Start()
    {
        
    }

    void Update()
    {
        if (ScoreTracker.score % 50 == 0 && ScoreTracker.score != 0 && canContinueFallSpeed)
        {
            SpikeFall.fallSpeed += 0.1f;

            StartCoroutine(ExecuteAfterTimeFallSpeed(0.2f));
            canContinueFallSpeed = false;
        }

        if (ScoreTracker.score % 1000 == 0 && ScoreTracker.score != 0 && canContinueSpikeNum)
        {
            SpikeSpawner.spikesToSpawn += 1;

            StartCoroutine(ExecuteAfterTimeSpikeNum(0.2f));
            canContinueSpikeNum = false;
        }
    }

    IEnumerator ExecuteAfterTimeFallSpeed(float time)
    {
        yield return new WaitForSeconds(time);

        canContinueFallSpeed = true;
    }

    IEnumerator ExecuteAfterTimeSpikeNum(float time)
    {
        yield return new WaitForSeconds(time);

        canContinueSpikeNum = true;
    }
}
