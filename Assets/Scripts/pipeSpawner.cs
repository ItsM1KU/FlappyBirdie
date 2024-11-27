using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeSpawner : MonoBehaviour
{
    [SerializeField] private float maxTime = 1.5f;
    [SerializeField] private float maxHeight = 0.45f;
    [SerializeField] GameObject pipePrefab;

    private float timer;


    private void Start()
    {
        spawner();
    }

    private void Update()
    {
        if(timer > maxTime)
        {
            spawner();
            timer = 0;
        }

        timer += Time.deltaTime;
    }
    void spawner()
    {
        Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(-maxHeight, maxHeight));
        GameObject pipe = Instantiate(pipePrefab, spawnPos, Quaternion.identity);

        Destroy(pipe, 15f);
    }
}
