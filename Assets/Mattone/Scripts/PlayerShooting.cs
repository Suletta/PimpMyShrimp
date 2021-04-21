using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public float fireRate;
    public float timer;
    public Object playerBullet;
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Instantiate(playerBullet, this.gameObject.transform.position, Quaternion.identity);
        }
        if (Input.GetButton("Jump"))
        {
            timer += Time.deltaTime;
            if (timer >= fireRate)
            {
                timer = 0;
                Instantiate(playerBullet, this.gameObject.transform.position, Quaternion.identity);
            }
        }
        if (!Input.GetButton("Jump"))
        {
            timer = 0;
        }
    }
}
