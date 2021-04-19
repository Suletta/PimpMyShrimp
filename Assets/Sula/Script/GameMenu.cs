using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{

    [SerializeField]
    GameObject gameMenu;
    Canvas canvas;

    void Start()
    {
        canvas = gameMenu.GetComponent<Canvas>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OpenGameMenu()
    {
        if (canvas.enabled == false)
        {

        //pause game
        //activate menu
        //gameMenu.SetActive(true);
        canvas.enabled = true;
        Debug.Log("mostro");
        }

    }

    public void HideGameMenu()
    {
        if (canvas.enabled)
        {
            //togli pausa
        canvas.enabled = false;
        Debug.Log("nascondo");
        }

    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }


}
