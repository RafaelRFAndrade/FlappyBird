using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesSpawner : MonoBehaviour
{
    public GameObject pipe;

    private float timeBtwSpawn;
    public float StartTimeBtwSpawn;
    private Vector3 SpawnPos;
    float yPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        yPos = Random.Range(3.18f, -1.26f);
        SpawnPos = new Vector3(transform.position.x, yPos, transform.position.z);
        if (timeBtwSpawn <= 0)
        {
            Instantiate(pipe, SpawnPos, transform.rotation);
            timeBtwSpawn = StartTimeBtwSpawn;
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}
