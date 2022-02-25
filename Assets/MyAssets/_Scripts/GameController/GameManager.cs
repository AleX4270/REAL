using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    public static GameManager Instance { get { return instance; } }

    private void Awake()
    {
        if(instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }
    }

    [Header("Managers")]
    [SerializeField] internal DimensionsManager dimensionsManager;
    [SerializeField] internal PlayerController playerController;
    [SerializeField] internal GameplayManager gameplayManager;
    [SerializeField] internal UIManager uiManager;

    [Header("Reversed Dimension")]
    [SerializeField] internal TilemapCollider2D reversedDimensionCollider;
    [SerializeField] internal TilemapRenderer reversedDimensionRenderer;
    [SerializeField] internal GameObject reversedDimensionObj;


    private void Update()
    {
        dimensionsManager.SwitchDimensions();
    }
}
