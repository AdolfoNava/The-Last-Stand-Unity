using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wanderer : Enemy
{
    public Vector2 direction;
    
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        EnemyType = EnemyType.Wanderer;
        //To randomize the direction and speed of the wanderer by making a rng factor
        direction = new Vector3(Random.Range(-100, 100),Random.Range(-100, 100));
       
    }

    protected override void FixedUpdate()
    {
        base.FixedUpdate();
    }
    protected override void Movement()
    {
        rb.MovePosition(rb.position + direction/100f * speed * Time.fixedDeltaTime);
    }
    //Special method version since it will never track and follow the player
    protected override void OnCollisionEnter2D(Collision2D collision)
    {

        switch (collision.transform.tag)
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
                Destroy(this.gameObject);
                break;
            case "WallX":
                direction.x = direction.x * -1f;
                break;
            case "WallY":
                direction.y = direction.y * -1f;
                break;
            default:
                break;
        }
    }
}
