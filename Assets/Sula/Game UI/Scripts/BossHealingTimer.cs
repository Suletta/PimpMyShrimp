using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

public class BossHealingTimer : MonoBehaviour
{
    [Tooltip("Start/Pause timer")]
    [SerializeField]
    bool activateTimer = false; //POSSO USARLA PER PAUSARE IL TIMER

    [Header("Timer Lenght")]
    float currentTime;
    public int startSeconds;

    [Header("Text")]
    [Tooltip("Add text game obj")]
    public GameObject textObj;
    TextMeshProUGUI textTMP;

    private void Awake()
    {
        textTMP = textObj.GetComponent<TextMeshProUGUI>();
        currentTime = startSeconds;
    }

    private void Update()
    {
        ActivateCountdown();
    }

    //IL TIMER PARTE SOLO SE CHIAMO IL METODO CON LA BOOL ACTIVATE TIMER ATTIVA
    private void ActivateCountdown()
    {
        if (activateTimer)
        {
            textTMP.text = currentTime.ToString("F2") + " seconds";

            if (currentTime > 0)
            {
                currentTime -= Time.deltaTime;
            }
            else
            {
                activateTimer = false;
                currentTime = startSeconds;
            }
        
        }
    }
}
