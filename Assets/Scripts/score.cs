using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class score : MonoBehaviour
{
    public static score instance;

    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private TMP_Text bestText;

    private int scoree;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        scoreText.text = scoree.ToString();

        bestText.text = PlayerPrefs.GetInt("bestscore", 0).ToString();
    }

    private void updateHighScore()
    {
        if(scoree > PlayerPrefs.GetInt("bestscore"))
        {
            PlayerPrefs.SetInt("bestscore", scoree);
            bestText.text = scoree.ToString() ;
        }
    }

    public void updateCurrentScore()
    {
        scoree++;
        scoreText.text = scoree.ToString();
        updateHighScore();
    }

}
