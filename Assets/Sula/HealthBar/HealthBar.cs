using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;

    public void SetHealth(int currentHealth)
    {
        slider.value = currentHealth;
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }

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
