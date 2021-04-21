using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShooting : MonoBehaviour
{
    public float fireRate;
    public float timer;
    public Object playerBullet;
    public float gesu;
    void Update()
    {
        Shooting();
    }

    public void Shooting()
    {
        if (gesu > 0.99f)
        {
            timer += Time.deltaTime;
            if (timer >= fireRate)
            {
                timer = 0;
                Instantiate(playerBullet, this.gameObject.transform.position, Quaternion.identity);
            }
        }
        if (gesu < 0.99f)
        {
            timer = fireRate;
        }
    }

    public void Shoot(InputAction.CallbackContext context)
    {
        gesu = context.ReadValue<float>();
    }
}
