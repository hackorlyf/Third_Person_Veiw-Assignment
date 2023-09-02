using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Running : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        // Check for input or some condition to determine if the character is walking.
        // You can replace this condition with your own logic.
        bool isWalking = Input.GetKey(KeyCode.W);

        // Set the "IsWalking" parameter based on the condition.
        animator.SetBool("IsWalking", isWalking);
    }
}
