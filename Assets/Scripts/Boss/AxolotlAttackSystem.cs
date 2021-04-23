﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxolotlAttackSystem : MonoBehaviour
{
    [Tooltip("Bullet spawner animator")]
    public Animator animator;
    [Tooltip("String of boolean parameters of the animator")]
    public string[] attack;

    int a,i;
    float timer;
    float timerout = 1;
    void Start()
    {
        a = 99;
    }

    void Update()
    {
        timer += Time.deltaTime;
        if(timer>= timerout)
        {
            i = Random.Range(0, attack.Length - 1);
            animator.SetBool(attack[i], true);
            timer = 0;
            if(a!= 99 && a != i)
            {
                animator.SetBool(attack[a], false);
            }
            a = i;
        }
    }

    
}
