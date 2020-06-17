﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveMent : MonoBehaviour
{
    public float health = 10f;

    public void DecreaseHealth(float damage)
    {
        health -= damage;
        if (health<= 0)
        {
            Destroy(gameObject);
            return;
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
