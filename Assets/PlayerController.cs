using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private SpriteRenderer sr;
    [SerializeField] private float playermove;

    
    [SerializeField] private float playerjump;
    [SerializeField] private Transform groundPoint;
    [SerializeField] private bool isOnGround;
    [SerializeField] private LayerMask whatIsGround;
    [SerializeField] private Animator anim;
    [SerializeField] private bool canJump;
    [SerializeField] private Transform playerTransform;
    private float _playerMoveInput;

    private void Update()
    {
        Flip();

        GroundCheck();
        CheckCanJump();
        Animation();
    }
    private void FixedUpdate()
    {
        Move();
    }

    private void OnMove(InputValue value)
    {
        _playerMoveInput = value.Get<float>();
    }

    private void OnJump(InputValue value)
    {   if (canJump)
        {
            if (value.isPressed)
            {
                rb.AddForce(playerjump * transform.up, ForceMode2D.Impulse);
            }
        }

    }
    private void Move()
    {
        rb.velocity = new Vector2(_playerMoveInput * playermove, rb.velocity.y);
    }
    private void Flip()
    {
        if (_playerMoveInput == -1)
        {
            playerTransform.transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        else if (_playerMoveInput == 1)
        {
            playerTransform.transform.localScale = Vector3.one;
        }
    }
    private void GroundCheck()
    {
        isOnGround = Physics2D.OverlapCircle(groundPoint.position, .2f, whatIsGround);
    }

    private void CheckCanJump()
    {
        if(isOnGround)
        {
            canJump = true;
        }
        else
        {
            canJump = false;
        }
    }

    private void Animation()
    {
        anim.SetBool("IsOnGround", isOnGround);
        anim.SetFloat("Speed", Mathf.Abs(rb.velocity.x));
    }

}
