using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameWin : MonoBehaviour
{
    EnemyHealth enemyHealth;
    public GameObject boss;

    public void Win ()
    {
        FindObjectOfType<AudioManager>().Play("Fanfare");
        StartCoroutine(WinWait());
    }
    IEnumerator WinWait ()
    {
        yield return new WaitForSeconds(11f);
        SceneManager.LoadScene("MainMenu");
    }
}
