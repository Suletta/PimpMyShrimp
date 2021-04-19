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

    void Update()
    {
        //bool isSpacePressed = false;
        //if (Keyboard.current.spaceKey.isPressed && isSpacePressed == false)
        //{
        //    TakeDamage(10);
        //    Debug.Log("danneggiato");
        //    isSpacePressed = true;
        //}
        //else
        //{
        //    isSpacePressed = false;
        //}
    }

    public void TakeDamage(int damageInflicted)
    {
        currentHealth -= damageInflicted;
    }
}
