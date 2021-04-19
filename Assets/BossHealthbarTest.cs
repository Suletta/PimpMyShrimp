using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BossHealthbarTest : MonoBehaviour
{
    [SerializeField]
    int maxHealth;
    public int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.isPressed)
        {
            TakeDamage(10);
            Debug
        }
    }

    public void TakeDamage(int damageInflicted)
    {
        currentHealth -= damageInflicted;
    }
}
