using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public static SceneController instance;

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
        if (Gamepad.current.buttonEast.wasPressedThisFrame && gameover)
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
        SceneManager.LoadScene(0);
    }



}
