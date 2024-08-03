using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool isWalking = Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W);
        bool isBacking = Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S);

        // Walk
        if (isWalking)
        {
            animator.SetBool("Walk", true);
            animator.SetBool("Back", false);
            transform.position += transform.forward * 0.01f;
        }
        // Back
        else if (isBacking)
        {
            animator.SetBool("Walk", false);
            animator.SetBool("Back", true);
            transform.position -= transform.forward * 0.01f;
        }
        // State
        else
        {
            animator.SetBool("Walk", false);
            animator.SetBool("Back", false);
        }

        // Rotation
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0.0f, 1.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0.0f, -1.0f, 0.0f);
        }
    }
}
