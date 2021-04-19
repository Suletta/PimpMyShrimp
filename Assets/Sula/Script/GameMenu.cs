using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameMenu : MonoBehaviour
{

    [SerializeField]
    GameObject gameMenu;

    public InputAction OpenMenu;
    public InputAction HideMenu;


    private void OnEnable()
    {
        OpenMenu.Enable();
        HideMenu.Enable();

        
    }
    private void OnDisable()
    {
        OpenMenu.Disable();
        HideMenu.Disable();
    }

    void Start()
    {
        //gameMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        //OpenGameMenu();
        //HideGameMenu();


    }

    public void OpenGameMenu()
    {
        if (OpenMenu.triggered)
        {

        //pause game
        //activate menu
        gameMenu.SetActive(true);
        }
    }

    public void HideGameMenu()
    {
        //if (HideMenu.triggered)
        //{
        Debug.Log("nascondo");
        gameMenu.SetActive(false);
        //}
    }

    public void QuitGame()
    {
        Application.Quit();
    }


}
