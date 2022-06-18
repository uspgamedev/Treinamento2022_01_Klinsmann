using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{   
    public GameObject gameOverMenu;
    public Player_movement player_movement;
    public GameWin gameWin;

    void Start ()
    {
        Time.timeScale = 1;
    }
    public void GameOver()
    {
        gameOverMenu.SetActive(true);
        Time.timeScale = 0;
        player_movement.enabled = false;
    }
    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public void Quit()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
