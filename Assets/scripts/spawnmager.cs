using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;
using TMPro;

public class spawnmager : MonoBehaviour
{
    
    

    public GameObject[] obstacles;
    public GameObject Player;
    public float spawnrangeX = 25;
    public float spawnposZ = -1018;
    public float spawny = 18;
    
    public Vector3 infront_spawn = new Vector3(0, 3, 20);
    public Vector3 spawner = new Vector3(35, 14, -1018);
    public float start_delay = 2;
    public float spawn_delay = 2;
    void Start()
    {
        InvokeRepeating("SpawnRandomOBBY", start_delay, spawn_delay);

        
        
    }
    
    

    
    void Update()
    {
        
    }
    void SpawnRandomOBBY()
    {
        
        Vector3 spawnPos = transform.position = Player.transform.position + infront_spawn;
        int index = Random.Range(0, obstacles.Length);
        int obstacle_index = Random.Range(0, obstacles.Length);
        Instantiate(obstacles[index], spawnPos, obstacles[index].transform.rotation);


    }
}
