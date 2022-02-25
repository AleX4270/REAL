using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayManager : MonoBehaviour
{
    [SerializeField] private GameManager manager;

    internal void resetPlayer()
    {
        manager.playerController.movement.respawnPlayer();
    }
}
