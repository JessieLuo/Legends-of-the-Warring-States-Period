using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Battle : MonoBehaviour
{
    public float movingSteps;
    public float Speed = 5f;
    public Transform character;
    private Rigidbody2D rb;
    public Animator anim;    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        move();
    }
    //player movement. The movement is just use for programmer testing.
    void move()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");
        float horizontalFaceDirection = Input.GetAxisRaw("Horizontal");
        if (horizontalFaceDirection != 0)
        {
            transform.localScale = new Vector3(horizontalFaceDirection, 1, 1);
        }
        Vector2 position = transform.position;
        position.x = position.x + 3.0f * horizontalMove * Time.deltaTime;
        position.y = position.y + 3.0f * verticalMove * Time.deltaTime;
        transform.position = position;
        //anim.SetFloat("moving", Mathf.Abs(horizontalFaceDirection));
    }   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Enemy enemy = collision.gameObject.GetComponent<Enemy>();
        CharacterSkill characterSkill = new CharacterSkill();
        //attack enemy 
        if (collision.gameObject.tag == "Enemy")
        {
            enemy.setHealthValue(characterSkill.baseAttack());
            anim.SetBool("encounter", true);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            anim.SetBool("encounter", false);
        }
    }
}

class CharacterSkill
{
    //Character attribute
    private int healthValue = 15;
    private int attackDistance = 1;
    private int attackValue = 1;

    public CharacterSkill()
    {
    }

    public CharacterSkill(int healthValue, int attackDistance, int attackValue)
    {
        this.healthValue = healthValue;
        this.attackValue = attackValue;
        this.attackDistance = attackDistance;
    }

    public int baseAttack()
    {
        return attackValue;
    }

}
