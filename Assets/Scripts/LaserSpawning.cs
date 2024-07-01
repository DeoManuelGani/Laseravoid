using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserSpawning : MonoBehaviour
{
    public GameObject LaserAvoid_Laser_VertSwing;
    public GameObject LaserAvoid_Laser_HorSwing;
    private float SpawnposXV = 0;
    private float SpawnposYH = 0;

    void Start()
    {
        Invoke("SpawnLaserV", Random.Range(2f, 4f));
        Invoke("SpawnLaserX", Random.Range(2f, 4f));
    }

    void SpawnLaserV()
    {
        float SpawnposYV = 0;
        float RandomTimeV = Random.Range(3f, 5f);
        float RandomizerV = Random.Range(-1f, 1f);
        if (RandomizerV <= 0f)
        {
            SpawnposYV = 6.4f;
        }
        else
        {
            SpawnposYV = -6.4f;
        }
        Instantiate(LaserAvoid_Laser_VertSwing, new Vector3(SpawnposXV, SpawnposYV, 0), transform.rotation);
        Invoke("SpawnLaserV", RandomTimeV);
    }

    void SpawnLaserX()
    {
        float SpawnposXH = 0;
        float RandomTimeH = Random.Range(3f, 5f);
        float RandomizerH = Random.Range(-1f, 1f);
        if (RandomizerH <= 0f)
        {
            SpawnposXH = 6.4f;
        }
        else
        {
            SpawnposXH = -6.4f;
        }
        Instantiate(LaserAvoid_Laser_HorSwing, new Vector3(SpawnposXH, SpawnposYH, 0), transform.rotation);
        Invoke("SpawnLaserX", RandomTimeH);
    }
}



