﻿using UnityEngine;

public class Obstacle : MonoBehaviour
{
Rigidbody2D rb;
[SerializeField] private float moveSpeed;

private void Awake()
{
    rb = GetComponent<Rigidbody2D>();
}

void Update()
{
    if(transform.position.x < -15f)
    {
        Destroy(gameObject);
}
    if (transform.position.x > 15f)
    {
        Destroy(gameObject);
    }

    }



private void FixedUpdate()
{

    rb.velocity = Vector2.left * moveSpeed;

}
}
