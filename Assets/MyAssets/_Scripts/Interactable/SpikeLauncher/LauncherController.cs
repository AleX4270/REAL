using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauncherController : MonoBehaviour
{
    [SerializeField] private GameObject boltsPrefab;
    [SerializeField] private Transform boltsSpawn;

    private void Start()
    {
        InitializeBolts();
    }

    private void InitializeBolts()
    {
        Instantiate(boltsPrefab, boltsSpawn.position, Quaternion.identity);
    }
}
