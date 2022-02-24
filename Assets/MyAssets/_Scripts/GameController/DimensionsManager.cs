using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DimensionsManager : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;

    internal void SwitchDimensions()
    {
        if(gameManager.playerController.input.GetPlayerInputDimensionChange())
        {
            gameManager.reversedDimensionCollider.enabled = 
                !gameManager.reversedDimensionCollider.enabled;

            gameManager.reversedDimensionRenderer.enabled =
                !gameManager.reversedDimensionRenderer.enabled;

            gameManager.reversedDimensionObj
                .SetActive(!gameManager.reversedDimensionObj.activeInHierarchy);
        }
    }
}
