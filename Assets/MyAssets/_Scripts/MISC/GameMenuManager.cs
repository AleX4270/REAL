using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenuManager : MonoBehaviour
{
    public bool isStartScene;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return) && isStartScene)
        {
            SceneManager.LoadScene("FirstLevel");
        }

        if(Input.GetKeyDown(KeyCode.Return) && !isStartScene)
        {
            SceneManager.LoadScene("StartScreen");
        }
    }
}
