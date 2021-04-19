using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

public class BossHealingTimer : MonoBehaviour
{
    //[SerializeField]
    //GameObject timerObj;
    //TextMeshPro timerText;

    //float timerDuration = 10f; //10 sec di timer
    //bool countingDown = false;


    //void Start()
    //{
    //    timerText = timerObj.GetComponent<TextMeshPro>();
    //    timerObj.GetComponent<TextMeshPro>().text = timerDuration + " seconds";
    //}

    //void Update()
    //{
    //    if (countingDown == false && timerDuration > 0)
    //    {
    //        StartCoroutine("Countdown");
    //    }

    //}

    //public IEnumerator Countdown()
    //{
    //    Debug.Log("parte il timer");
    //    countingDown = true;

    //    yield return new WaitForSeconds(1);

    //    timerDuration -= 1;

    //    timerText.text = timerDuration + " seconds";
    //}


    [SerializeField]
    bool activateTimer = false;

    float currentTime;
    public int startSeconds;

    //text stuff
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
