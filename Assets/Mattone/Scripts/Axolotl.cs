using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Axolotl : MonoBehaviour
{
    public float hp;
    public float startHp;

    public float timer;
    public float rechargeTime;
    public Player player;

    void Start()
    {
        hp = startHp;
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > rechargeTime)
        {
            hp = startHp;
            timer = 0;
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "ShrimpBullet")
        {
            hp -= player.bulletDamage;
            Destroy(collision.gameObject);
        }
    }
}
