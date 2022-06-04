using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_manager : MonoBehaviour
{
    public RandomSpawner[] rSpawner;

    private int a = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (a == 1)
        {
            foreach (RandomSpawner spawn in rSpawner)
            spawn.SpawnRandomEnemy();
            a = 0;
        }
    }
}
