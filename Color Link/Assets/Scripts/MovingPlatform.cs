using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public int speed;
    public Transform PosA;
    public Transform PosB;
    Vector2 targetPos;

    void Start()
    {
        targetPos = PosA.position;
    }

    void Update()
    {
        if(Vector2.Distance(transform.position, PosA.position) < 0.1f) targetPos = PosB.position;

        if(Vector2.Distance(transform.position, PosB.position) < 0.1f) targetPos = PosA.position;

        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.SetParent(this.transform);
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.SetParent(null);
        }
    }
}