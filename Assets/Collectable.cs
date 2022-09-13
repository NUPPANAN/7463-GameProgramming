using UnityEngine;

public class Collectable : MonoBehaviour
{
    public Collectabletype collectableType;

    [SerializeField] private SpriteRenderer playersr;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            playercolor();

            Destroy(gameObject);
        }
    }

    public void playercolor()
    {
        switch (collectableType)
        {
            case Collectabletype.Blue:
                playersr.color = Color.blue;
                break;
            case Collectabletype.Green:
                playersr.color = Color.green;
                break;
            case Collectabletype.Red:
                playersr.color = Color.red;
                break;
            case Collectabletype.Yellow:
                playersr.color = Color.yellow;
                break;
        }
    }
}