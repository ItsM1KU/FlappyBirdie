using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MSceneController : MonoBehaviour
{
    public static MSceneController instance;

    [SerializeField] GameObject gameoverCanvas;

    private bool gameover;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        Time.timeScale = 1.0f;
    }

    private void Update()
    {
        if ( isTouchInputDetected() && gameover)
        {
            RestartGame();
            gameover = false;
        }
    }

    public void GameOver()
    {
        gameoverCanvas.SetActive(true);
        Time.timeScale = 0f;
        gameover = true;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Mobile");
    }
    private bool isTouchInputDetected()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            return true;
        }
        return false;
    }

}
