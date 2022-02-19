using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnemyType {Wanderer,Seeker,BlackHole,Chaser,Dead }
//Base enemy class for the game intended to have all child classes for each of the different enemies
public abstract class Enemy : MonoBehaviour
{
    //To Help with the scoring system of the game since killing different enemies gives you a different score
    public EnemyType EnemyType { get; set; }
    //Health for the enemy intended to be different based on the enemy
    [SerializeField] public int health = 1;
    //Speed of the enemy meant to be different based on the enemy type
    public float speed = 2f;
    //For following the player at varying speeds doesn't matter for the wanderer
    protected PlayerControl  player;
    //To help deal with moving the enemy around the scene and/or the player
    public Rigidbody2D rb { get; protected set; }
    //The particle effect identifier
    public GameObject ParticleDeathEffect;
    //To despawn the particle effect after a set amount of time
    public float ParticleDeathTimer;
    

    // Start is called before the first frame update
    protected virtual void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerControl>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    protected virtual void FixedUpdate()
    {
        //To deal with when the enemy dies or when the player dies
        if(health <= 0)
        {
            ScoreSystem.UpdateScore(EnemyType);            
            EnemyAudioManager.PlayDeathAudio(EnemyType.ToString());
            Destroy(Instantiate(ParticleDeathEffect, rb.position, Quaternion.identity) as GameObject, ParticleDeathTimer);
            EnemyType = EnemyType.Dead;
            Destroy(this.gameObject);

        }
        if (PlayerControl.Status == Status.Dead)
        {
            Destroy(Instantiate(ParticleDeathEffect, rb.position, Quaternion.identity) as GameObject, ParticleDeathTimer);
            Destroy(this.gameObject);
        }
        Movement();
    }

    //Special movement based on the enemy type
    protected virtual void Movement()
    {
        //meant to be different based on the enemy
    }
    //The base collision method for enemies with not special mechanics like BlackHole and Wanderer
    protected virtual void OnCollisionEnter2D(Collision2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Bullet":
                health -= 1;
                break;
            case "Player":
                ScoreSystem.Lives--;
                PlayerControl.Dying();
                break;
            case "BlackHole":
                health = 0;
                Destroy(Instantiate(ParticleDeathEffect, rb.position, Quaternion.identity) as GameObject, ParticleDeathTimer);
                Destroy(this.gameObject);
                break;
            default:
                break;
        }
    }
}
