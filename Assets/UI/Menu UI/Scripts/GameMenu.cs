using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{

    public void QuitGame()
    {
        Application.Quit();
    }

    //SE SERVE CAMBIARE L'INDEX DEL MAIN MENU FARò LE MODIFICHE CHE SERVONO
    //DI BASE SARà SEMPRE LA PRIMA SCENA
    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }

    //PAUSA
    public static bool isPaused = false;
    [SerializeField]
    GameObject Background;

    public void OpenGameMenu()
    {
        if (isPaused)
        {
            Unpause();
        }
        else
        {
            Pause();
        }
    }

    void Pause()
    {
        Background.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void Unpause()
    {
        Background.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
}
