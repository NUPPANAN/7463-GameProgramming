using UnityEngine;


public class FinishLine : MonoBehaviour
{
    [SerializeField] private GameManager _gameManager;

    private void Srart()
    {
        _gameManager = FindObjectOfType<GameManager>();
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (!col.CompareTag("Player")) return;

        _gameManager.LoadNextScene();

    }
}
