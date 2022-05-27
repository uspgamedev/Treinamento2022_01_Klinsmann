using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public float radius = 1;
    public GameObject enemyPrefab;

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) SpawnRandomEnemy();   
    }

    void SpawnRandomEnemy()
    {
        Vector2 randomPos = Random.insideUnitCircle * radius;

        Instantiate(enemyPrefab, randomPos, Quaternion.identity);
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;

        Gizmos.DrawWireSphere(this.transform.position, radius);
    }
    
}
