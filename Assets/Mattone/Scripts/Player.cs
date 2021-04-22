using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int startHp;
    public int hp=4;
    public PlayerShooting shoot;
    public float bulletDamage;
    public float bulletCooldown;
    public float bulletTimer;
    public float dmgUpgrade;
    public float rateUpgrade;
    public float invincibilityTime;
    public bool invincibilty = false;
    public GameObject shell;
    
    public int dmgpwrN=0;
    public int frrtN=0;
    public int defenseN=0;

    public UpdatePlayerStats updateStats;

    void Start()
    {
        hp = startHp;
    }

    void Update()
    {
        bulletTimer -= Time.deltaTime;
        if (invincibilty == true)
        {
            shell.gameObject.SetActive(true);
        }
        else
        {
            shell.gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Bullet" && bulletTimer <= 0 && invincibilty==false)
        {
            hp -= 1;
            print(hp);
            bulletTimer = bulletCooldown;
            updateStats.UpdateHearts(hp);
        }

        if (collision.CompareTag("DmgUp"))
        {
            DmgUP();
            Destroy(collision.gameObject);
            Debug.Log("DmgUp");
            updateStats.UpdateDamageValue(Mathf.RoundToInt(bulletDamage));
            dmgpwrN++;
            updateStats.UpdatePowerUps(dmgpwrN, "damage");
        }

        if (collision.CompareTag("RateUp"))
        {
            RateUP();
            Destroy(collision.gameObject);
            Debug.Log("RateUp");
            frrtN++;
            updateStats.UpdatePowerUps(frrtN, "firerate");
        }

        if (collision.CompareTag("Armor"))
        {
            Armor();
            Destroy(collision.gameObject);
            Debug.Log("Armor");
            defenseN++;
            updateStats.UpdatePowerUps(defenseN, "defence");
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
        hp++;
        StopCoroutine(Invincibility());
        StartCoroutine(Invincibility());
    }

    private IEnumerator Invincibility()
    {
        invincibilty = true;
        yield return new WaitForSeconds(invincibilityTime);
        invincibilty = false;
        defenseN--;
        updateStats.UpdatePowerUps(defenseN, "defence");
    }
}
