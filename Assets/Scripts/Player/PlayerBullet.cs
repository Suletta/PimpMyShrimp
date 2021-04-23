using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public float bulletSSpeed;
    public float lifetime;
    void Start()
    {
        Destroy(gameObject, lifetime);
    }

    void Update()
    {
        transform.position += new Vector3(0, 1, 0) * bulletSSpeed * Time.deltaTime;
    }
}