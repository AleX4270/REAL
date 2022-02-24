using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    [SerializeField] internal PlayerController controller;

    private void Update()
    {
        playRunAnimation();
        playJumpAnimation();
    }

    private void playRunAnimation()
    {
        if(controller.state.GetCurrentState() == State.grounded)
        {
            controller.anim.SetFloat("Speed", Mathf.Abs(controller.rb2d.velocity.x));
        }
    }

    private void playJumpAnimation()
    {
        controller.anim.SetBool("isJumping",
            controller.state.GetCurrentState() == State.grounded ? false : true);
    }
}
