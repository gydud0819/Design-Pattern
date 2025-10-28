using System;
using UnityEngine;

public class Idle : State
{
    public void Enter(Character character)
    {
        character.animator.SetInteger("X", 0);
    }

    public void Exit(Character character)
    {
        
    }

    public void Excute(Character character)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

        }

        if(Mathf.Abs(Input.GetAxisRaw("Horizontal")) > 0)
        {
            character.Play(new Walk());
        }
        
    }
}
