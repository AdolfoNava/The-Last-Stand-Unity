using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seeker : Enemy
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        EnemyType = EnemyType.Seeker;
    }
    protected override void FixedUpdate()
    {
        base.FixedUpdate();
        Movement();
    }
    protected override void Movement()
    {
        base.Movement();
        //rb.velocity = Vector2.MoveTowards(rb.position, player.position, .001f);
        rb.position += speed * (player.position - rb.position).normalized * Time.deltaTime; 

    }
    protected override void OnCollisionEnter2D(Collision2D collision)
    {
        base.OnCollisionEnter2D(collision);
    }
}
