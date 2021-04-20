using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BossStatsTest : MonoBehaviour
{
    [SerializeField]
    int maxHealth;
    public int currentHealth;

    //REF alla barra per aggiornare la vita
    [SerializeField]
    HealthBar healthBar;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    public void TakeDamage(int damageInflicted)
    {
        currentHealth -= damageInflicted;
        healthBar.UpdateHealth(currentHealth);
    }
}
