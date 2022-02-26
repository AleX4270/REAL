using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIVolManager : MonoBehaviour
{
    private AudioManager audioManager;
    [SerializeField] internal TMP_Text volumeInfo;

    private void Start()
    {
        audioManager = FindObjectOfType<AudioManager>();
    }

    private void Update()
    {
        audioManager.AdjustVolume(volumeInfo);
    }
}
