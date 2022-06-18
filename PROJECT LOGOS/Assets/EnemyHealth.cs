using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum enemyType{COMMON, BOSS}
public class EnemyHealth : MonoBehaviour
{
    public int enemyMaxHealth = 3;
    public int enemyCurrentHealth;
    public enemyType type;
    public GameManager gameManager;
    void Start()
    {
        enemyCurrentHealth = enemyMaxHealth;
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }
    public void TakeDamage(int damage)
    {
        enemyCurrentHealth -= damage;

        if (enemyCurrentHealth <= 0)
        {
            Die();
            Destroy(gameObject);
            
            if (type == enemyType.BOSS)
            {
                gameManager.gameWin.Win();
            }
        }
    }

    void Die()
    {
        Debug.Log("Morreu ;-;");
    }
}
