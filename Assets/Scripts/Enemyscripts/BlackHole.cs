using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//The most unique enemy type due to having a gravity system that sucks in other enemies and gain more health
public class BlackHole : Enemy
{
    public List<GameObject> Enemies; 
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        EnemyType = EnemyType.BlackHole;
        Enemies = new List<GameObject>();
        foreach(GameObject obj in GameObject.FindGameObjectsWithTag("Enemy"))
        {
            Enemies.Add(obj);
        }
    }

    protected override void FixedUpdate()
    {
        base.FixedUpdate();        
        foreach(GameObject enemy in Enemies)
        {
            Enemy e = enemy.GetComponent<Enemy>();
            
            if(e.EnemyType == EnemyType.Dead||enemy == null)
            {
                Enemies.Remove(enemy);
                Destroy(enemy);
            }
        }
        foreach(GameObject enemy in Enemies)
        {
            if(enemy != this)
            {
                Vaccum(enemy);
            }
        }

    }
    void OnEnable()
    {
        
    }//Follows the player but it has the slowest speed in the game
    protected override void Movement()
    {
        base.Movement();
        rb.transform.position += speed * (player.transform.position - rb.transform.position).normalized * Time.deltaTime;
    }
    //Apply force to the enemy objects towards the blackhole
    void Vaccum(GameObject enemy)
    {
        Rigidbody2D rb1 = enemy.GetComponent<Rigidbody2D>();

        Vector3 direction = rb.position - rb1.position;
        float distance = direction.magnitude;

        float forceMagnitude = rb.mass * rb1.mass / Mathf.Pow(distance, 2);
        Vector3 force = direction.normalized * forceMagnitude*2;

        rb1.AddRelativeForce(force);
    }
    protected override void OnCollisionEnter2D(Collision2D collision)
    {
        switch (collision.gameObject.tag)
        { 
            case "Player":
                ScoreSystem.Lives -= 1;
                PlayerControl.Dying();
                break;
            case "Bullet":
                health -= 1;
                break;
            case "Enemy":
                health += 1;
                break;
            default:
                break;
        }

    }
}
