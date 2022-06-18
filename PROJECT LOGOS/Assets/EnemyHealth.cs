using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int enemyMaxHealth = 3;
    int enemyCurrentHealth;
    void Start()
    {
        enemyCurrentHealth = enemyMaxHealth;
    }
    public void TakeDamage(int damage)
    {
        enemyCurrentHealth -= damage;

        if (enemyCurrentHealth <= 0)
        {
            Die();
            Destroy(gameObject);
            
        }
    }

    void Die()
    {
        Debug.Log("Morreu ;-;");
    }
}
