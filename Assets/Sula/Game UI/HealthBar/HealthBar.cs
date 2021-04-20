using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;

    //SETTA LA VALUE DELLA BARRA IN MODO CHE CORRISPONDA ALLA VITA ATTUALE 
    //DA CHIAMARE QUANDO IL BOSS PRENDE DANNO
    public void UpdateHealth(int currentHealth)
    {
        slider.value = currentHealth;
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }

    //PRENDE LA VITA MASSIMA IMPOSTATA E LA ASSEGNA ALLO SLIDER (ROBA DA FARE APPENA PARTE TUTTO)
    public void SetMaxHealth(int maxHealth)
    {
        slider.maxValue = maxHealth;
        slider.value = maxHealth;
        fill.color = gradient.Evaluate(1f);
    }

    //refill graduale WIP fare courutine
    public void RefillHealth(int fullHealth)
    {
        float t = 0 + Time.deltaTime;

        float currentHealth = slider.value;
        slider.value = Mathf.Lerp(currentHealth, fullHealth, t);
    }
}
