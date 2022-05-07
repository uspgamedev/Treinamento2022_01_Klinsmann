using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyGFX : MonoBehaviour
{
    public AIPath aipath;
    public Animator animator;
    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        
        movement.x = aipath.desiredVelocity.x;
        movement.y = aipath.desiredVelocity.y;

        animator.SetFloat("X", movement.x);
        animator.SetFloat("Y", movement.y);
        animator.SetFloat("enemy_speed", movement.sqrMagnitude);
    }
}
