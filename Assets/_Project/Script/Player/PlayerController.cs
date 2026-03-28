using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(PlayerInputHandler))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private PlayerSettings _playerSettings;

    private Rigidbody2D _rb;
    private PlayerInputHandler _input;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _input = GetComponent<PlayerInputHandler>();
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
        _rb.linearVelocity = _input.MoveInput * _playerSettings.Speed;
        FlipSprite(_input.MoveInput.x);
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
