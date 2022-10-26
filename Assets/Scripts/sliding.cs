using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class sliding : MonoBehaviour
{

    private Animator animator;
    [SerializeField]
    private float offsetY = 0.25f;
    [SerializeField]
    private float sizeY = 0.45f;

    private bool isSliding = false;

    private Vector2 startOfsetY;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        //animator.GetBool
    }

    // Update is called once per frame
    void Update()
    {
        bool canSlide  = animator.GetBool("IsJumping") == false;
        if(canSlide)
        {
            if (isSliding)
            {
                bool isKeyUp = Input.GetKeyUp(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.DownArrow);
                if (isKeyUp)
                {
                    isSliding = false;
                    animator.SetBool("IsDead", isSliding);
                }
            }
            else
            {
                bool isKeyDown = Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.DownArrow);
                if (isKeyDown)
                {
                    isSliding = true;
                    animator.SetBool("IsDead", isSliding);
                }
            }
           
            
        }
    }
}
