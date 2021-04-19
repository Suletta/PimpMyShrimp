using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public Bullet bullet;
    public float minRotation, maxRotation, rate, bulletSpeed;
    public int numberOfBullet;
    public Vector2 bulletVelocity;

    private float timer = 0;
    public float[] rotations ;

    private void Update()
    {
        SetRotations();
        if(timer >= rate)
        {
            SpawnBullet();
            timer = 0;
        }
        timer += Time.deltaTime;
    }

    private float[] SetRotations()
    {
        for (int i = 0; i < numberOfBullet; i++)
        {
            var fraction = (float)i / (float)numberOfBullet;
            var difference = maxRotation - minRotation;
            var fdd = fraction * difference;
            rotations[i] = fdd + minRotation;
        }
        return rotations;
    }


    private void SpawnBullet()
    {
        for (int i = 0; i < numberOfBullet; i++)
        {
            Bullet b = Instantiate(bullet,new Vector3(), new Quaternion() );
            b.speed = bulletSpeed;
            b.rotation = rotations[i];
            Destroy(b.gameObject, 10);
        }
    }
}
