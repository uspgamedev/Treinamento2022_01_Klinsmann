using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public float radius = 1;
    public GameObject enemyPrefab;

    

    public void SpawnRandomEnemy()
    {
        Vector3 randomPos = Random.insideUnitCircle * radius;

        Instantiate(enemyPrefab, this.transform.position + randomPos, Quaternion.identity);
        Debug.Log("Randompos: " + randomPos);
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;

        Gizmos.DrawWireSphere(this.transform.position, radius);
    }
    
}
