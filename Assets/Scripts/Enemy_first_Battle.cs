using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy_first_Battle : Enemy
{
    public Animator anim;
    // Update is called once per frame
    void Update()
    {

        if (enemyHealthValue <= 0)
        {
            Death();
            //deathAudio = GetComponent<AudioSource>();
            SceneManager.LoadScene("AttributionTest");
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            anim.SetBool("isHurt", true);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            anim.SetBool("isHurt", false);
        }
    }
}
