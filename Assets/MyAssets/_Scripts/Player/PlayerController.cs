using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] internal PlayerMovement movement;
    [SerializeField] internal PlayerData data;
    [SerializeField] internal PlayerPhysics physics;
    [SerializeField] internal PlayerInput input;

    [SerializeField] internal PlayerState state = new PlayerState();

    [SerializeField] internal Transform groundCheck;
    [SerializeField] internal LayerMask groundLayer;
    [SerializeField] internal Animator anim;

    [Header("Fancy Options")]
    [SerializeField] internal float coyoteTime;

    internal Rigidbody2D rb2d;

    private void Start()
    {
        this.state.playerStateChanged += DebugLogPlayerState;
        rb2d = GetComponent<Rigidbody2D>();
    }

    //Debug
    private void DebugLogPlayerState(object sender, State state)
    {
        Debug.Log("Player State has been changed: " + state);
    }

    private void OnDestroy()
    {
        this.state.playerStateChanged -= DebugLogPlayerState;
    }
}
