using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPhysics : MonoBehaviour
{
    [SerializeField] PlayerController controller;
    private Vector2 movementSpeed;
    private float coyoteTimeCounter;
    private Vector3 playerScale;
    private bool facingRight;

    private void Start()
    {
        this.coyoteTimeCounter = controller.coyoteTime;
        this.facingRight = true;
    }

    private void FixedUpdate()
    {
        PhysicsLoop();
    }

    private void PhysicsLoop()
    {
        IsGrounded();
    }

    //Clear Physics
    private void IsGrounded()
    {
        if(Physics2D.OverlapCircle(controller.groundCheck.position, 0.2f, controller.groundLayer))
        {
            controller.state.SetCurrentState(State.grounded);
            this.coyoteTimeCounter = controller.coyoteTime;
        }
        else
        {
            this.coyoteTimeCounter -= Time.fixedDeltaTime;
            if(this.coyoteTimeCounter < 0)
            {
                controller.state.SetCurrentState(State.airborne);
                this.coyoteTimeCounter = controller.coyoteTime;
            }
        }
    }

    //Movement
    internal void Move(float force)
    {
        this.movementSpeed.x = force * Time.fixedDeltaTime;
        this.movementSpeed.y = controller.rb2d.velocity.y;

        controller.rb2d.velocity = this.movementSpeed;

        if(force < 0 && this.facingRight)
        {
            Flip();
        }
        else if(force > 0 && !this.facingRight)
        {
            Flip();
        }
    }

    internal void Jump(float force)
    {
        if (controller.state.GetCurrentState() == State.airborne) return;

        controller.rb2d.velocity = new Vector2(controller.rb2d.velocity.x, 
            force * Time.fixedDeltaTime);
        this.coyoteTimeCounter = 0;
    }

    private void Flip()
    {
        this.facingRight = !this.facingRight;

        this.playerScale = this.transform.localScale;
        this.playerScale.x *= -1;
        this.transform.localScale = this.playerScale;
    }
}
