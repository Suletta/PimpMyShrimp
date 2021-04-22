using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Player player;
    public Axolotl axolotl;

    void Update()
    {
        if (player.hp == 0)
        {
            SceneManager.LoadScene(2);
        }

        if (axolotl.hp == 0)
        {
            SceneManager.LoadScene(3);
        }
    }
}
