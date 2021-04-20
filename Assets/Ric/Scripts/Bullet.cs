﻿using UnityEngine;

public class Bullet : MonoBehaviour
{
    //public Vector2 velocity;
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
        rb.velocity = transform.forward * speed*100 * Time.deltaTime;
        transform.localRotation = Quaternion.Euler(0, rotation, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Bullet"))
        {
            Destroy(gameObject);
            Debug.Log("destroy bullet");
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
        Debug.Log(name + " should be destroyed");
    }
}