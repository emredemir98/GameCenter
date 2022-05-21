using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("TempScene");
    }
    public void PlayGame2()
    {
        SceneManager.LoadScene("TempScene");
        SceneManager.LoadScene("Game2");
    }
    public void Quit()
    {
        Application.Quit();
    }
    
}
