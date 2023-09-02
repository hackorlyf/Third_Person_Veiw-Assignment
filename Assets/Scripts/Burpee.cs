using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burpee : MonoBehaviour
{
    private Animator animator;
    //private bool isBurpeeInProgress = false;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B) )
        {
            //isBurpeeInProgress = true;
            animator.SetTrigger("BurpeeTrigger"); // Trigger the burpee animation
        }
    }
}
