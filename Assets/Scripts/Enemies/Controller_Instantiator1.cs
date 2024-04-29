using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_Instantiator1 : MonoBehaviour
{
    public float timer = 7;

    public  GameObject enemy;

    public GameObject instantiatePos;

    private float time = 0;

    private int multiplier = 20;

    void Start()
    {
        
    }

    void Update()
    {
        timer -= Time.deltaTime;
        SpawnEnemy1();
        ChangeVelocity1();
    }

    private void ChangeVelocity1()
    {
        time += Time.deltaTime;
        if (time > multiplier)
        {
            multiplier *= 2;
            //Increase velocity
        }
    }

    private void SpawnEnemy1()
    {
        if (timer <= 0)
        {
            float offsetX = instantiatePos.transform.position.x;
            for (int i = 0; i < 1; i++)
            {
                offsetX = offsetX + 4;
                Vector3 transform = new Vector3(offsetX, instantiatePos.transform.position.y, instantiatePos.transform.position.z);
                Instantiate(enemy, transform,Quaternion.identity);
            }
            timer = 7;
        }
    }
}
