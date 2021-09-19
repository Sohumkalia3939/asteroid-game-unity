using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    //  public TMP_Text Score;
    //  public Controller controller;
    public GameObject GameOver;
    public TMP_Text Score;
    public Transform Player;
    // Start is called before the first frame update
    public void gameover()
    {
        GameOver.SetActive(true);
        Score.text = "Score: " + Player.position.y.ToString("0");
        return;

    }

    public void Restart()
    {
        SceneManager.LoadScene(0);

    }

}

