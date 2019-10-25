using UnityEngine;
using UnityEngine.UI;

public class ButtonJump : MonoBehaviour
{
    Animator animator;

    

    private void Start()
    {
        animator = GetComponent<Animator>();


    }

    public void RuntoJump()
    {
        if (animator.GetBool("İsRunning") == true && animator.GetBool("İsJumping") == false && animator.GetBool("İsJumptoRun") == false)
        {
            animator.SetBool("İsRuntoJump", true);
            animator.SetBool("İsJumping", true);

        }
    }
    public void Walkbutton()
    {
        animator.SetBool("İsRunning", false);
        animator.SetBool("İsJumping", false);


    }
}