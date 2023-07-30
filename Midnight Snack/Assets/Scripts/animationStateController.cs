using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStateController : MonoBehaviour
{
    Animator animator;
    int isWalkingHash; // for optimization, faster to compare to integers than two strings
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash(isWalkingHash);
    }

    // Update is called once per frame
    void Update()
    {
        bool isWalking = animator.GetBool(isWalkingHash);
        bool forwardPressed = Input.GetKey("w");
        //if player presses W key
        if (!isWalking && forwardPressed)
        {
            // sets the isWalking boolean to be true
            animator.SetBool(isWalkingHash, true);
        }

        //if a player is not pressing the w key
        if (isWalking && !forwardPressed)
        {
            //set the isWalking boolean to be false
            animator.SetBool(isWalkingHash, false);
        }
    }
}
