using UnityEngine;
using UnityEngine.UI;

public class AnimatorButtonController : MonoBehaviour
{
    Animator animator;

    Button button;
    
    private void Start()
    {
        animator = GetComponent<Animator>();
       

    }

    public void Jumpbutton()
    {

        animator.SetBool("İsJumping", true);
       
        
     


    }
    public void Runbutton()
    {
        animator.SetBool("İsRunning", true);

       

     

    }

    public void Walkbutton()
    {
        animator.SetBool("Idle", true);
        animator.SetBool("İsJumping", false);
        animator.SetBool("İsRunning", false);
        
       


    }
    public void RuntoJump()
    {
        if (animator.GetBool())
        animator.SetTrigger("İsRuntoJump");
        animator.SetBool("İsJumping", false);
        animator.SetBool("Idle", false);
    }

    public void JumptoRun()
    {
        
        animator.SetTrigger("İsJumptoRun");
        animator.SetBool("İsRunning", false);
        animator.SetBool("Idle", false);

    }



    /*  private void FixedUpdate()
      {

          if (Input.GetKeyDown(KeyCode.UpArrow))
          { animator.SetBool("İsJumping", true); }


          if (Input.GetKeyDown(KeyCode.RightArrow))

          { animator.SetBool("İsRunning", true); }



          if (Input.GetKeyDown(KeyCode.LeftArrow))

          {
              animator.SetBool("İsRunning", false);
              animator.SetBool("İsJumping", false);
              animator.SetBool("İsRuntoJump", false);
              animator.SetBool("İsJumptoRun",false);
          }


          if (animator.GetBool("İsRunning")==true)
          {
             if (Input.GetKeyDown(KeyCode.UpArrow))
                  {



                  animator.SetBool("İsJumptoRun", false);
                  animator.SetBool("İsRuntoJump", true);

              }

          }

          if (animator.GetBool("İsJumping") == true)
          {
              if (Input.GetKeyDown(KeyCode.RightArrow))
              {

                  animator.SetBool("İsRuntoJump", false);
                  animator.SetBool("İsJumptoRun", true);


              }

          }

          /*   if (animator.GetBool("İsJumping") == true)
             {
                 if (Input.GetKeyDown(KeyCode.RightArrow))
                 {
                     animator.SetBool("İsJumping", false);
                     animator.SetBool("İsJumping", false);
                     animator.SetBool("İsJumptoRun", true);

                 }

             }*/










}







