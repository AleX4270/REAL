using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private PlayerController controller;

    internal float GetPlayerInputHorizontal()
    {
        return Input.GetAxisRaw("Horizontal");
    }

    internal bool GetPlayerInputJump()
    {
        return Input.GetButtonDown("Jump");
    }

    internal bool GetPlayerInputDimensionChange()
    {
        return Input.GetButtonDown("Fire1");
    }
}
