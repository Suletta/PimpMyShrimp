﻿using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(SpriteRenderer))]
public class AxolotlBullet : MonoBehaviour
{
    public float speed;
    [HideInInspector]public float rotation;
    Rigidbody rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        transform.rotation = Quaternion.Euler(0, rotation, 0);
    }

    void Update()
    {
        rb.velocity = transform.forward * speed*100 * Time.deltaTime;    // move
        transform.localRotation = Quaternion.Euler(0, rotation, 0);
    }


    // destroy on colllision
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Bullet"))
        {
            Destroy(gameObject);
            Debug.Log("destroy bullet");
        }
    }


    // destroy on exit of camera
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
        Debug.Log(name + " should be destroyed");
    }
}