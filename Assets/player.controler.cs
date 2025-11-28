using UnityEngine;

public class PlayerController : MonoBehaviour
{
    SpriteRenderer sprite;
    [SerializeField] float speed = 5f;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();

        // Asegúrate de que el Rigidbody2D tenga Gravity Scale = 0
    }

    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        // Volteo del sprite
        if (horizontalInput > 0) sprite.flipX = false;
        if (horizontalInput < 0) sprite.flipX = true;

        // Movimiento en ambos ejes con física
        rb.linearVelocity = new Vector2(horizontalInput, verticalInput).normalized * speed;
    }
}