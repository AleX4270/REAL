using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GameManager : MonoBehaviour
{
    [SerializeField] internal DimensionsManager dimensionsManager;

    [SerializeField] internal PlayerController playerController;

    //[Header("Real Dimension")]
    //[SerializeField] internal Tilemap realDimension;

    [Header("Reversed Dimension")]
    [SerializeField] internal TilemapCollider2D reversedDimensionCollider;
    [SerializeField] internal TilemapRenderer reversedDimensionRenderer;
    [SerializeField] internal GameObject reversedDimensionObj;

    private void Update()
    {
        dimensionsManager.SwitchDimensions();
    }
}
