using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHole : Enemy
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        EnemyType = EnemyType.BlackHole;
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
        switch (collision.gameObject.tag)
        { 
            case "Player":
                ScoreSystem.Lives -= 1;
                collision.gameObject.SetActive(false);
                break;
            case "Bullet":
                health -= 1;
                break;
            case "Enemy":
                Destroy(collision.gameObject);
                health += 1;
                break;
            default:
                break;
        }

    }
}
