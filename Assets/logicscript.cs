using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class logicscript : MonoBehaviour
{
    public int playerscore;
    public Text scoretext;
    public GameObject gameOverScreen;
    public soundeffectplayer sfx;
    [ContextMenu("Increase score")]
    public void addscore(int scoreToAdd)

    {
        playerscore = playerscore + scoreToAdd;
        scoretext.text = playerscore.ToString();
        sfx.button1();

    }
    public void restartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void gameOver()
    {
        gameOverScreen.SetActive(true);

    }
    public void quitscreen()
    {
    Application.Quit();
    }
}
