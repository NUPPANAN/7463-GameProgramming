using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private SpriteRenderer sr;
    [SerializeField] private float playermove;
    [SerializeField] private float playerjump;
    private float _playerMoveInput;


    private void FixedUpdate()
    {
        rb.velocity = new Vector2(_playerMoveInput * playermove, rb.velocity.y);
    }

    private void OnMove(InputValue value)
    {
        _playerMoveInput = value.Get<float>();
    }

    private void OnJump(InputValue value)
    {
        if (value.isPressed)
        {
            rb.AddForce(playerjump * transform.up, ForceMode2D.Impulse);
        }
    }

}
