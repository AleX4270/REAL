using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AudioManager : MonoBehaviour
{
    private AudioSource m_AudioSource;


    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        m_AudioSource = GetComponent<AudioSource>();
    }

    internal void AdjustVolume(TMP_Text txt)
    {
        if(txt.text.Contains("0%"))
        {
            AdjustVolumeText(m_AudioSource.volume * 100, txt);
        }

        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            m_AudioSource.volume += 0.05f;
            if (m_AudioSource.volume > 1)
            {
                AdjustVolumeText(100f, txt);
            }
            else
            {
                AdjustVolumeText(m_AudioSource.volume * 100, txt);
            }
        }

        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            m_AudioSource.volume -= 0.05f;
            if(m_AudioSource.volume < 0)
            {
                AdjustVolumeText(0f, txt);
            }
            else
            {
                AdjustVolumeText(m_AudioSource.volume * 100, txt);
            }
        }
    }

    internal void AdjustVolumeText(float newVolume, TMP_Text txt)
    {
        txt.text = "<color=#EFFF00>Volume</color>: " + (Mathf.Round(newVolume)).ToString() 
            + "%";
    }
}
