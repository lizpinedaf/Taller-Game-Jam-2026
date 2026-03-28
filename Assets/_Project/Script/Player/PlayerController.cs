using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(PlayerInputHandler))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private PlayerSettings playerSettings;

    private Rigidbody2D rb;
    private PlayerInputHandler input;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        input = GetComponent<PlayerInputHandler>();
    }

    void Update()
    {
        
    }

    void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        rb.linearVelocity = input.MoveInput * playerSettings.Speed;
        FlipSprite(input.MoveInput.x);
    }

    public void FlipSprite(float directionX)
    {
        Vector3 scale = transform.localScale;

        if (directionX < 0 && scale.x > 0)
        {
            scale.x = -1f;
            transform.localScale = scale;
        }
        else if (directionX > 0 && scale.x < 0)
        {
            scale.x = 1f;
            transform.localScale = scale;
        }
    }
}
