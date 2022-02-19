using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seeker : Enemy
{
    //special cooldown for the enemy to not move faster when the player moves away from the seeker
    int cooldown = 0;
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        EnemyType = EnemyType.Seeker;
    }
    protected override void FixedUpdate()
    {
        base.FixedUpdate();
    }
    //Follows the player at generally faster speeds but slows down when it gets close enough to the player
    protected override void Movement()
    {
        base.Movement();
        Vector3 direction = player.transform.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
        if (Vector2.Distance(transform.position, player.transform.position) > 2 && cooldown == 0)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed);
        }
        else
        {
            cooldown++;
            if (cooldown > 45)
            {
                cooldown = 0;
            }
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed/1.5f);
        }
    }
    protected override void OnCollisionEnter2D(Collision2D collision)
    {
        base.OnCollisionEnter2D(collision);
    }
}
