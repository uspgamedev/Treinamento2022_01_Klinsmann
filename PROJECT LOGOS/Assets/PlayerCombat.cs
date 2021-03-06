using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Animator animator;
    public Transform attackPoint;
    public LayerMask enemyLayers;
    public float attackRange = 0.5f;
    public int attackDamage = 1;
    

    
    public float attackRate = 0.5f;
    float nextAttackTime = 0;
    void Update()
    {
        if (Time.time >= nextAttackTime)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Attack();
                nextAttackTime = Time.time + 1f/attackRate;
            }   
        }
        

    }

    void Attack()
    {
        // animação de ataque
        animator.SetTrigger("Attack");

        //detecção de inimigos no alcance de ataque
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        //causar dano
        foreach(Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<EnemyHealth>().TakeDamage(attackDamage);
            FindObjectOfType<AudioManager>().Play("sword_sfx");

        }
    }

    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
        return;
         
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
