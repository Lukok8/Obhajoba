using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScriptController : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool running = animator.GetBool("Running");
        bool Walking = animator.GetBool("Walking");
        bool forwardActive = Input.GetKey("w");
        bool runActive = Input.GetKey("left shift");

        //W key is pressed
        if (!Walking && forwardActive)
        {
            //Start walking
            animator.SetBool("Walking", true);
        }
        //W key is let go
        if (Walking && !forwardActive)
        {
            //Stop walking
            animator.SetBool("Walking", false);
        }

        //Character is walking and not running and shift is pressed
        if (!running && (forwardActive && runActive))
        {
            animator.SetBool("Running", true);
        }

        //Character is running and stops running or walking
        if (running && (!forwardActive || !runActive))
        {
            animator.SetBool("Running", false);
        }


    }
}
