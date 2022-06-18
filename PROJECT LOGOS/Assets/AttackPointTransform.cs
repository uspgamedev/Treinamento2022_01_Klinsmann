using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPointTransform : MonoBehaviour
{
    public Transform attackPoint;
    Vector2 movement;
    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (movement.x > 0.1f)
            attackPoint.transform.position = new Vector2 (1.7f, 0f);
        if (movement.x < -0.1f) 
            attackPoint.transform.position = new Vector2 (-1.7f, 0f);
        if (movement.y < -0.1f)
            attackPoint.transform.position = new Vector2 (0f, -1.7f);
        if (movement.y > 0.1f)
            attackPoint.transform.position = new Vector2 (0f, 1.7f);
    }
}
