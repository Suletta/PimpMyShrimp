using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UpdatePlayerStats : MonoBehaviour
{
    [SerializeField]
    GameObject[] playerHearts;
    List<Image> heartsList = new List<Image>();

    [SerializeField]
    GameObject playerDamage;
    TextMeshProUGUI playerDamageText;

    [SerializeField]
    GameObject[] playerPowerUp;

    List<TextMeshProUGUI> playerPowerUpText = new List<TextMeshProUGUI>();

    //PRENDERE REF DELLO SCRIPT DEL PLAYER CON TUTTE LE STATS
    [SerializeField]
    TestPlayerStats playerStats;


    void Start()
    {
        //piglio tutti i testi e elementi vari dai game object
        playerDamageText = playerDamage.GetComponent<TextMeshProUGUI>();



        //    //metto i testi degli oggetti nell'array dentro la mia lista
        //    foreach (var powerUp in playerPowerUp)
        //    {
        //        playerPowerUpText.Add(powerUp.GetComponent<TextMeshProUGUI>());            
        //    }

        //prendo le 4 immagini
        foreach (var heart in playerHearts)
        {
            heartsList.Add(heart.GetComponent<Image>());
        }

        
        // Setto tutti i valori in start
        UpdateHearts(playerStats.playerLives);
        UpdateDamageValue(playerStats.playerDamage);

        //    UpdatePowerUps(playerStats.damagePU, "damage");
        //    UpdatePowerUps(playerStats.fireratePU, "firerate");
        //    UpdatePowerUps(playerStats.defencePU, "defence");

    }

   public void UpdateHearts(int playerLives)
    {
        switch (playerLives)
        {
            case 4:
                foreach (var heart in heartsList)
                {
                    heart.enabled = true;                    
                }
                break;
        
            case 3:
                heartsList[3].enabled = false;               
                break;

            case 2:
                heartsList[3].enabled = false;
                heartsList[2].enabled = false;
                break;

            case 1:
                heartsList[3].enabled = false;
                heartsList[2].enabled = false;
                heartsList[1].enabled = false;
                break;

            case 0:               
                foreach (var heart in heartsList)
                {
                    heart.enabled = false;
                }
                break;

            default:
                break;
        }
    }

    public void UpdateDamageValue(int damageValue)
    {
        playerDamageText.text = damageValue.ToString();
    }

    public void UpdatePowerUps(int currentQuantity, string tag)
    {
        //if (tag == "damage")
        //{
        //    playerPowerUpText[1].text = currentQuantity.ToString();
        //}
        //if (tag == "firerate")
        //{
        //    playerPowerUpText[2].text = currentQuantity.ToString();
        //}
        //if (tag == "defence")
        //{
        //    playerPowerUpText[3].text = currentQuantity.ToString();
        //}
        

        //A seconda del tag del powerup aggiorno il testo con la quantità attuale del powerup
        switch (tag)
        {
            case "damage":
                playerPowerUpText[1].text = "X " + currentQuantity.ToString();
                break;
            case "firerate":
                playerPowerUpText[2].text = "X " + currentQuantity.ToString();
                break;
            case "defence":
                playerPowerUpText[3].text = "X " + currentQuantity.ToString();
                break;
            default:
                break;
        }
    }
}
