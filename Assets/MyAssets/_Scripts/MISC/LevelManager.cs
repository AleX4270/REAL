using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    private string sceneName;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            this.sceneName = SceneManager.GetActiveScene().name;

            if (this.sceneName == "FirstLevel")
            {
                SceneManager.LoadScene("SecondLevel");
            }
            else if (this.sceneName == "SecondLevel")
            {
                SceneManager.LoadScene("ThirdLevel");
            }
            else if (this.sceneName == "ThirdLevel")
            {
                SceneManager.LoadScene("EndScreen");
            }
        }
    }


}
