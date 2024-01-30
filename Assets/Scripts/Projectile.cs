using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Projectile : MonoBehaviour
{
    [SerializeField] BulletClass Bullet;
    Rigidbody2D rb;
    float speed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        float speed = Bullet.Speed;
    }

    private void FixedUpdate()
    {
        //Vector2 direction = position de la souris 
        rb.velocity = Vector2.right * speed * Time.fixedDeltaTime;
    }
}
