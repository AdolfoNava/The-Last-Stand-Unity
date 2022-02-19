using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "BlackHole"|| collision.gameObject.tag == "WallX"|| collision.gameObject.tag == "WallY")
        {
            Destroy(this.gameObject);
        }
    }
}
