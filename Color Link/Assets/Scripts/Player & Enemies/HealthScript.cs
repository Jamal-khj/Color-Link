using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour
{
    public float health = 200;

    public int damageOutput = 25;

    // Update is called once per frame
    void Update()
    {
        Death();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            health -= damageOutput;
        }
    }

    public void Death()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
