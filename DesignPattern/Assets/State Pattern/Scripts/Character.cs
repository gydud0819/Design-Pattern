using System.Resources;
using UnityEditor;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] public Animator animator;
    [SerializeField] private int x;
    [SerializeField] private float dirY;

    private State state;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        Play(new Idle());
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Play(new PickUp());
            return;
        }

        Play(new Walk());
    }

    public void Play(State _state)
    {
        state?.Exit(this);
        state = _state;
        state.Enter(this);
    }


    //void PickUp()
    //{

    //    AnimatorStateInfo animatorStateInfo = animator.GetCurrentAnimatorStateInfo(0);

    //    // 애니메이터 상태 전환 여부 

    //    if (animatorStateInfo.IsName("pickUp") || animator.IsInTransition(0))
    //    {
    //        return;
    //    }
    //        animator.SetTrigger("pickUp"); 

    //}       

    //void Walk()
    //{
    //    x = (int)Input.GetAxisRaw("Horizontal");
    //    animator.SetInteger("X", x);
    //}
}
