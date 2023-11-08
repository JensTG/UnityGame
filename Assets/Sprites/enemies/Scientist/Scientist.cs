using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Funcs;

public class Scientist : MonoBehaviour
{
    public float baseSpeed = 0.5f;
    public float acceleration = 2.0f;
    public Rigidbody2D sciBody;
    public Animator animator;

    Vector2 movement;
    float speed;
    float moveStart = 0;

    // Start is called before the first frame update
    void Start()
    {
        animator.keepAnimatorStateOnDisable = true;
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Speed", speed);
    }

    private void FixedUpdate()
    {
        if (movement.x != 0 || movement.y != 0)
        {
            speed = baseSpeed * (Time.fixedTime - moveStart) * acceleration + baseSpeed;
            sciBody.MovePosition(sciBody.position + movement.normalized * speed * Time.fixedDeltaTime);
            if (MathFuncs.Vec2Deg(movement) != -1) sciBody.MoveRotation(MathFuncs.Vec2Deg(movement));
        }
        else
        {
            moveStart = Time.fixedTime;
            speed = 0;
        }
    }
}
