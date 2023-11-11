using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Funcs;

public class Scientist : MonoBehaviour
{
    public float walkSpeed;
    public float runSpeed;
    public float deceleration;
    public Rigidbody2D sciBody;
    public Animator animator;

    Vector2 movement;
    Vector2 lastMove;
    float movementStopTime;

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

        animator.SetFloat("Speed", movement.normalized.magnitude * walkSpeed);
    }

    private void FixedUpdate()
    {
        if (movement.x != 0 || movement.y != 0)
        {
            sciBody.MovePosition(sciBody.position + movement.normalized * walkSpeed * Time.fixedDeltaTime);
            if (MathFuncs.Vec2Deg(movement) != -1) sciBody.MoveRotation(MathFuncs.Vec2Deg(movement));
            movementStopTime = Time.fixedTime;
            lastMove = movement;
        }
        else
        {
            Vector2 deltaMove = MoveFuncs.DecelDelta(movementStopTime, deceleration, lastMove);
            if (deltaMove.magnitude != 0) sciBody.MovePosition(sciBody.position + deltaMove);
        }
    }
}
