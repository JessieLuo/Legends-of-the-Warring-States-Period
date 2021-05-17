using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    protected Animator Anim;
    protected AudioSource deathAudio;

    public int enemyHealthValue = 15;
    protected virtual void Start()
    {
        Anim = GetComponent<Animator>();        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void setHealthValue(int damage)
    {
        enemyHealthValue -= damage;
    }
    public void Death()
    {        
        Destroy(gameObject);              
    }
}
