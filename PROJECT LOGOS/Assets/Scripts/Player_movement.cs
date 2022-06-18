using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_movement : MonoBehaviour
{
    public float speed = 3f;
    public Rigidbody2D rb;
    public Animator animator;
    Vector2 movement; 
    public Transform rotateAtk;
    Vector3 rotate;

    void Start()
    {
        this.enabled = true;
        rotate = rotateAtk.rotation.eulerAngles;
    }
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude); 

    }
    void FixedUpdate() {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime); 

        if (movement.x > 0.1f)
        {
            rotate.z = 90f;
            rotateAtk.rotation = Quaternion.Euler(rotate);
        }
        if (movement.x < -0.1f)
        {
            rotate.z = -90f;
            rotateAtk.rotation = Quaternion.Euler(rotate);
        }
        if (movement.y > 0.1f)
        {
            rotate.z = 180f;
            rotateAtk.rotation = Quaternion.Euler(rotate);
        }
        if (movement.y < -0.1f || (movement.x == 0f && movement.y == 0f))
        {
            rotate.z = 0f;
            rotateAtk.rotation = Quaternion.Euler(rotate);
        }
    } 
}
