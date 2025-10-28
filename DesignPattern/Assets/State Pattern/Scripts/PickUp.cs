using UnityEngine;

public class PickUp : State
{
    public void Enter(Character character)
    {
       
        character.animator.SetTrigger("pickUp");
    }

    public void Excute(Character character)
    {
        AnimatorStateInfo animatorStateInfo = character.animator.GetCurrentAnimatorStateInfo(0);
        if (!animatorStateInfo.IsName("pickUp") && animatorStateInfo.normalizedTime < 1.0f)
        {
            character.Play(new Idle());
        }
    }

    public void Exit(Character character)
    {
        
    }

   
}
