using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public static float speed = 2;
    public GameObject[] fruitPrefabs;
    public GameObject spawnPoint;
    
    


    void Start()
    {
        InvokeRepeating( "Spawn" , 0f, 0.5f);
        InvokeRepeating("SpawnFruits", 3f, 3f);
    }

    void Spawn()
    {
        Vector3 spawnPos = this.transform.position;
        Instantiate(fruitPrefabs[0], spawnPos, fruitPrefabs[0].transform.rotation);
    }

    void SpawnFruits()
    {
        if (RandomFruits.finishGame == false)
        {
            int fruitNumber = Random.Range(1, 6);
            Vector3 spawn = spawnPoint.transform.position;
            Instantiate(fruitPrefabs[fruitNumber], spawn, fruitPrefabs[fruitNumber].transform.rotation);
        }
    }


    void Update()
    {
        //speed = (speed + 0.05f) * Time.deltaTime;
    }

    
}
