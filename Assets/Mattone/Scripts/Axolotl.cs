using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Axolotl : MonoBehaviour
{
    public float hp;
    public float startHp;

    public float timer;
    public float rechargeTime;
    public Player player;
    public HealthBar healthBar;
    public TMP_Text bossTimer;

    void Start()
    {
        hp = startHp;
        healthBar.SetMaxHealth(Mathf.RoundToInt(startHp));
        timer = rechargeTime;
        bossTimer.text = timer.ToString("F2");
    }

    void Update()
    {
        timer -= Time.deltaTime;
        bossTimer.text = timer.ToString("F2");
        if (timer < 0)
        {
            hp = startHp;
            timer = rechargeTime;
            healthBar.UpdateHealth(Mathf.RoundToInt(hp));
            bossTimer.text = timer.ToString("F2");
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        TakeDamage(collision);
    }

    void TakeDamage(Collider collision)
    {

        if (collision.tag == "ShrimpBullet")
        {
            hp -= player.bulletDamage;
            Debug.Log("prendo danno");
            Destroy(collision.gameObject);
            healthBar.UpdateHealth(Mathf.RoundToInt(hp));
            if (hp <= 0)
            {
                SceneManager.LoadScene(3);
            }
        }
    }
}
