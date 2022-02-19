using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wanderer : Enemy
{
    
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        EnemyType = EnemyType.Wanderer; 
    }

    protected override void FixedUpdate()
    {
        base.FixedUpdate();
    }
    protected override void Movement()
    {

        
    }
    protected override void OnCollisionEnter2D(Collision2D collision)
    {
        base.OnCollisionEnter2D(collision);
    }
}
