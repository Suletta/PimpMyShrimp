using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawner : MonoBehaviour
{
    public float timer;
    public float maxTime;

    public Object[] powerUps;

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer>maxTime)
        {
            timer = 0;
            Instantiate(powerUps[Random.Range(0, 2)], new Vector3(Random.Range(-5.5f, 5.5f),5,0), Quaternion.identity);
        }
    }
}
