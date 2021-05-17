using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_first : Enemy
{

    // Update is called once per frame
    void Update()
    {

        if (enemyHealthValue <= 0)
        {
            Death();
            deathAudio = GetComponent<AudioSource>();
        }
    }
}
