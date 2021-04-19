using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    //private Rigidbody myRB;
    public float speed = 10f;

    //private float movementX;
    //private float movementY;

    //void Start()
    //{
    //    myRB = GetComponent<Rigidbody>();
    //}


    //void Update()
    //{

    //}

    //private void FixedUpdate()
    //{
    //    Vector3 movement = new Vector3(movementX, 0.0f, movementY);
    //    myRB.AddForce(movement * speed);
    //}

    //void OnMove(InputValue movementValue)
    //{
    //    Vector2 movementVector = movementValue.Get<Vector2>();

    //    movementX = movementVector.x;
    //    movementY = movementVector.y;
    //}


    PlayerControls controls;
    Vector2 move;

    private void Awake()
    {
        controls = new PlayerControls();
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }

}
