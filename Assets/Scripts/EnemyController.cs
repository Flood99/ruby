using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed;
    public bool vertical;
    public float changeTime = 3.0f;

    bool broken = true;
    
    Animator animator;
    Rigidbody2D rigidbody2D;
    float timer;
    int direction = 1;
    public ParticleSystem smokeEffect;
    
    // Start is called before the first frame update
    void Start()
    {
        //set timer
        timer = changeTime;
        //Get components
        rigidbody2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if(!broken)
        {
            return;
        }
        //count the timer dowm
        timer -= Time.deltaTime;
        //rest timer and change direction
        if (timer < 0)
        {
            
            direction = -direction;
            timer = changeTime;
        }
    }
    
    void FixedUpdate()
    {
        if(!broken)
        {
            return;
        }
        Vector2 position = rigidbody2D.position;
        
        if (vertical)
        {
            //move up and down
            animator.SetFloat("Movex",0);
            animator.SetFloat("Movey",direction);
            position.y = position.y + Time.deltaTime * speed * direction;;
        }
        else
        {
            //move left and right
            animator.SetFloat("Movex",direction);
            animator.SetFloat("Movey",0);
            position.x = position.x + Time.deltaTime * speed * direction;;
        }
        
        rigidbody2D.MovePosition(position);
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        RubyController player = other.gameObject.GetComponent<RubyController >();

        if (player != null)
        {
            player.ChangeHealth(-1);
        }
    }

    public void fix()
    {
        smokeEffect.Stop();
        broken = false;
        rigidbody2D.simulated = false;
        animator.SetTrigger("Fixed");

    }

}   
