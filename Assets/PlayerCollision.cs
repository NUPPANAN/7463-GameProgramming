using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour

{
    [SerializeField] private PlayerController playerController;
    [SerializeField] private GameManager _gameManager;

    private Collider2D _playerCollider;

    private void Start()
    {
        _playerCollider = GetComponent<Collider2D>();
    }
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (_playerCollider.IsTouchingLayers(LayerMask.GetMask("Hazard")))
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            _gameManager.RestartScene();
        }

    }
}
