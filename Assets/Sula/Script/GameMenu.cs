using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMenu : MonoBehaviour
{

    [SerializeField]
    GameObject gameMenu;

    void Start()
    {
        gameMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenMenu()
    {
        gameMenu.SetActive(false);
    }
}
