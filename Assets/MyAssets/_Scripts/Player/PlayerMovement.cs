using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private PlayerController controller;
    private float doubleJumpTime;

    private void Start()
    {
        this.doubleJumpTime = 1f;
    }

    private void Update()
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

    internal void respawnPlayer()
    {
        this.transform.position = controller.spawnPoint.position;
    }
}
