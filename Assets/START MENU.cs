using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class STARTMENU : MonoBehaviour
{ 
    public void onPlayButton()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void onQuitButton()
    {
        Application.Quit();
    }
}
