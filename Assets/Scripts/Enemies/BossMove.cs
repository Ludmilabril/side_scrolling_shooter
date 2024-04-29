using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMove : Controller_Enemy
{
    private Rigidbody rb;

    // Velocidad de movimiento en el eje Y
    public float verticalSpeed = 2.0f;

    // Dirección de movimiento en el eje X
    private Vector3 horizontalDirection = Vector3.left;
    private Vector3 direction;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public override void Update()
    {
        // Mantiene la dirección de movimiento en el eje X
        direction = horizontalDirection.normalized;

        base.Update();
    }

    void FixedUpdate()
    {
        // Aplica la fuerza de movimiento en el eje X
        rb.velocity = direction * enemySpeed;

        // Aplica la velocidad de movimiento en el eje Y
        float verticalVelocity = Mathf.Sin(Time.time) * verticalSpeed;
        rb.velocity = new Vector3(rb.velocity.x, verticalVelocity, 0);
    }
}