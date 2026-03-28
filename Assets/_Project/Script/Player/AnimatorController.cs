using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    [SerializeField] private Animator _playerAnimator;

    private Rigidbody2D _rigidbody;
    private PlayerController _player;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _player = GetComponent<PlayerController>();
    }

    private void LateUpdate()
    {
        SetVelocity();
    }

    public void SetVelocity()
    {
        float velocity = _rigidbody.linearVelocity.x;
        float absVelocity = Mathf.Abs(velocity);
        _playerAnimator.SetFloat("magnitude", absVelocity);
    }
}