using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] CharacterClass chara;
    Rigidbody2D rb;
    float speed;
    float fireRate;
    GameObject projectile;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        speed = chara.Speed;
        projectile = chara.Bullet.Prefab;
        fireRate = chara.FireRate;
    }

    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector2 direction = new Vector2(x, y);
        rb.velocity = direction * speed * Time.fixedDeltaTime;
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(projectile, transform.position, transform.rotation);
    }
}
