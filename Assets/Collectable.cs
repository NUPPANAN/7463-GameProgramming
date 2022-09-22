using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectable : MonoBehaviour
{
    public Collectabletype collectableType;
    public PowerUp powerUp;
    private float Timer;

    [SerializeField] private SpriteRenderer playersr;
    [SerializeField] private SOScriptable collectableObject;
    
   
       
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            playercolor();

            Powerjump();

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

    public void Powerjump()
    {
        switch (powerUp)
        {
            case PowerUp.DoubleJump:
                Debug.Log("CanDoubleJump");
                break;
        }
    }

    
}