using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_Enemy1 : MonoBehaviour
{

    private float shootingCooldown2;

    public GameObject enemyProjectile2;

    public GameObject powerUp2;

    public virtual void Update()
    {
        shootingCooldown2 -= Time.deltaTime;
        ShootPlayer2();
    }

    void ShootPlayer2()
    {
        if (Controller_Player._Player != null)
        {
            if (shootingCooldown2 <= 0)
            {
                Instantiate(enemyProjectile2, transform.position, Quaternion.identity);
                shootingCooldown2 = UnityEngine.Random.Range(1, 10);
            }
        }
    }


    

    internal virtual void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
        {
            GeneratePowerUp2();
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
            Controller_Hud.points++;
        }
        if (collision.gameObject.CompareTag("Laser"))
        {
            GeneratePowerUp2();
            Destroy(this.gameObject);
            Controller_Hud.points++;
        }
    }

    private void GeneratePowerUp2()
    {
        int rnd = UnityEngine.Random.Range(0, 3);
        if (rnd == 2)
        {
            Instantiate(powerUp2, transform.position, Quaternion.identity);
        }
    }
}
