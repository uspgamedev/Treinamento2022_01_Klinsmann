using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossHealth : MonoBehaviour
{
    public int bossMaxHealth = 15;
    int bossCurrentHealth;

    public Player_movement player_movement;
    void Start()
    {
        bossCurrentHealth = bossMaxHealth;
    }
    public void TakeDamage(int damage)
    {
        bossCurrentHealth -= damage;

        if (bossCurrentHealth <= 0)
        {
            Die();
            Destroy(gameObject);
            
            Time.timeScale = 0;
            player_movement.enabled = false;

            
            StartCoroutine(waiter());
        }
    }

    IEnumerator waiter()
    {
        FindObjectOfType<AudioManager>().Play("Fanfare");
        yield return new WaitForSeconds(11);
        SceneManager.LoadScene("MainMenu");

    }
    void Die()
    {
        Debug.Log("Morreu ;-;");
    }
}
