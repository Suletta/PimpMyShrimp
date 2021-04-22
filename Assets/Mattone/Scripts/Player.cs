using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int startHp;
    public int hp;
    public PlayerShooting shoot;
    public float bulletDamage;
    public float bulletCooldown;
    public float bulletTimer;
    public float dmgUpgrade;
    public float rateUpgrade;
    public float invincibilityTime;
    public bool invincibilty = false;

    void Start()
    {
        hp = startHp;
    }

    void Update()
    {
        bulletTimer -= Time.deltaTime;
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Bullet" && bulletTimer <= 0 && invincibilty==false)
        {
            hp -= 1;
            print(hp);
            bulletTimer = bulletCooldown;
        }

        if (collision.CompareTag("DmgUp"))
        {
            DmgUP();
            Destroy(collision.gameObject);
            Debug.Log("DmgUp");
        }

        if (collision.CompareTag("RateUp"))
        {
            RateUP();
            Destroy(collision.gameObject);
            Debug.Log("RateUp");
        }

        if (collision.CompareTag("Armor"))
        {
            Armor();
            Destroy(collision.gameObject);
            Debug.Log("Armor");
        }
    }

    private void DmgUP()
    {
        bulletDamage += dmgUpgrade;
    }

    private void RateUP()
    {
        shoot.fireRate += rateUpgrade;
    }

    private void Armor()
    {
        StartCoroutine(Invincibility());
    }

    private IEnumerator Invincibility()
    {
        invincibilty = true;
        yield return new WaitForSeconds(invincibilityTime);
        invincibilty = false;
    }
}
