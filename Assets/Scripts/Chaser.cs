using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    protected override void Movement()
    {
        base.Movement();
    }
    protected override void OnCollisionEnter2D(Collision2D collision)
    {
        base.OnCollisionEnter2D(collision);
    }
}
