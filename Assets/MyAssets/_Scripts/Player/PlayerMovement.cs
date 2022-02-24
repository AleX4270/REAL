using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private PlayerController controller;

    private void FixedUpdate()
    {
        MovementLoop();
    }

    private void MovementLoop()
    {
        MovePlayer();
    }

    internal void MovePlayer()
    {
        controller.physics.Move(controller.input.GetPlayerInputHorizontal() * controller.data.speed);

        if (controller.input.GetPlayerInputJump())
        {
            controller.physics.Jump(controller.data.jumpForce);
        }
    }
}
