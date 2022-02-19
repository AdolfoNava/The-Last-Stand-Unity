using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum EnemyType {Wanderer,Seeker,BlackHole,Chaser }
public abstract class Enemy : MonoBehaviour
{
    public EnemyType EnemyType { get; set; }
    [SerializeField] public int health = 1;
    public float speed = 2f;
    protected Rigidbody2D player;
    protected Rigidbody2D rb;

    // Start is called before the first frame update
    protected virtual void Start()
    {
        player = GameObject.Find("Player").GetComponent<Rigidbody2D>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    protected virtual void FixedUpdate()
    {
        if(health < 0)
        {
            Destroy(this.gameObject);
            ScoreSystem.UpdateScore(EnemyType);
        }
        Movement();
    }

    protected virtual void Movement()
    {
        //meant to be different based on the enemy;
    }
    protected virtual void OnCollisionEnter2D(Collision2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Bullet":
                health -= 1;
                break;
            case "Player":
                Destroy(collision.gameObject);
                break;
            case "BlackHole":
                Destroy(this.gameObject);
                break;
            default:
                break;
        }
    }
}
