using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UpdatePlayerStats : MonoBehaviour
{
    //STO SCRIPT POTREBBE ESSERE UNITO A QUELLO CHE AGGIORNA LA UI DEL NEMICO, 
    //PER ORA STA SULLA SIDEBAR RIGHT CHE è QUELLA DEL PLAYER

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
    Player playerStats;


    void Start()
    {
        GetUiElements();

        // Setto tutti i valori in start
        UpdateHearts(playerStats.hp);
        UpdateDamageValue(Mathf.RoundToInt(playerStats.bulletDamage));

        //le string servono a "taggare" il tipo di power-up per essere utilizzati come casi nello switch
        //è un po un meme ma vabbè, mi andava di usare quello
        UpdatePowerUps(playerStats.dmgpwrN, "damage");
        UpdatePowerUps(playerStats.frrtN, "firerate");
        UpdatePowerUps(playerStats.defenseN, "defence");

    }

    private void GetUiElements()
    {
        //piglio tutti i testi e elementi vari dai game object
        playerDamageText = playerDamage.GetComponent<TextMeshProUGUI>();

        //metto i testi degli oggetti nell'array dentro la mia lista
        foreach (var powerUp in playerPowerUp)
        {
            playerPowerUpText.Add(powerUp.GetComponent<TextMeshProUGUI>());
        }

        //prendo le 4 immagini
        foreach (var heart in playerHearts)
        {
            heartsList.Add(heart.GetComponent<Image>());
        }
    }

    //METODI DA CHIAMARE PER AGGIORNALE LA UI QUANDO CAMBIANO I VALORI DELLE PLAYER STATS :)

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
        //A seconda del tag del powerup aggiorno il testo con la quantità attuale del powerup
        switch (tag)
        {
            case "damage":
                playerPowerUpText[0].text = "X " + currentQuantity.ToString();
                break;
            case "firerate":
                playerPowerUpText[1].text = "X " + currentQuantity.ToString();
                break;
            case "defence":
                playerPowerUpText[2].text = "X " + currentQuantity.ToString();
                break;
            default:
                break;
        }
    }
}
