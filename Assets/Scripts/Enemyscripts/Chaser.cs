using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Simple enemy intended to be the most basic and least scary to deal with
public class Chaser : Enemy
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        EnemyType = EnemyType.Chaser;
    }

    protected override void FixedUpdate()
    {
        base.FixedUpdate();
    }
    //Just follows the player very slowly
    protected override void Movement()
    {
        base.Movement();
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed);
        //rb.position += speed * (player.position - rb.position).normalized * Time.deltaTime;
    }
    protected override void OnCollisionEnter2D(Collision2D collision)
    {
        base.OnCollisionEnter2D(collision);
    }
}
