using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crouch : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        // Check for input or some condition to determine if the character should crouch.
        // You can replace this condition with your own logic.
        bool isCrouching = Input.GetKey(KeyCode.C);

        // Set the "IsCrouching" parameter based on the condition.
        animator.SetBool("IsCrouching", isCrouching);
    }
}
