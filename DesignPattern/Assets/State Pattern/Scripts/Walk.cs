using UnityEngine;

public class Walk : State
{
    public void Enter(Character character)
    {
        int x = (int)Input.GetAxisRaw("Horizontal");
        character.animator.SetInteger("X", x);
    }

    public void Exit(Character character)
    {
        character.animator.SetInteger("X", 0);
    }

    public void Excute(Character character)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            character.Play(new PickUp());
        }

        if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) > 0)
        {
            character.Play(new Idle());
        }
        character.animator.SetInteger("X", 1);
    }

}
