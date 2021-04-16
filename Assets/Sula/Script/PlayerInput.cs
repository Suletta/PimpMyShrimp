﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerInput : MonoBehaviour
{
    public InputAction OpenMenu;
    // Start is called before the first frame update
    private void OnEnable()
    {
        OpenMenu.Enable();   
    }
    private void OnDisable()
    {
        OpenMenu.Disable();
    }
}
