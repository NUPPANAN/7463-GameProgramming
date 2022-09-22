using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimatorController : MonoBehaviour
{
    [SerializeField] private Animator animator;
    // Start is called before the first frame update
    public void SetAnimatorPaarametor(Vector2 playerVelocity)
    {
        animator.SetFloat("Speed", playerVelocity.x);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
