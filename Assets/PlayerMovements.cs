using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovements : MonoBehaviour
{
    public Animator animator;
    bool isFacingRight=true;

    [SerializeField] private float moveSpeed=5f;
    private Rigidbody2D rb;
    private Vector2 moveInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity=moveInput*moveSpeed;
        Flip();
        animator.SetFloat("magnitude", rb.linearVelocity.magnitude);
        
    }

    public void Move(InputAction.CallbackContext context)
    {
        moveInput=context.ReadValue<Vector2>();
    }

    private void Flip()
    {
        if(isFacingRight && moveInput.x<0|| !isFacingRight && moveInput.x > 0)
        {
            isFacingRight=!isFacingRight;
            Vector3 ls= transform.localScale;
            ls.x *=-1f;
            transform.localScale= ls;
        }
    }
}
