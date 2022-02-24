using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public enum State
{
    grounded,
    airborne
}

public class PlayerState
{
    private State actualState;
    internal event EventHandler<State> playerStateChanged;

    internal void SetCurrentState(State newState)
    {
        if (newState != this.actualState)
        {
            this.OnPlayerStateChanged(newState);
        }

        this.actualState = newState; 
    }

    internal State GetCurrentState()
    {
        return this.actualState;
    }

    //Debug
    public virtual void OnPlayerStateChanged(State state)
    {
        playerStateChanged?.Invoke(this, state);
    }
}
