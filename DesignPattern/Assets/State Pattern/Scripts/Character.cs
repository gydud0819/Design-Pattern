using UnityEditor;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] private int x;
    [SerializeField] private float dirY;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PickUp();
        }
   
            Walk();
        
    
    }

    void PickUp()
    {
        //animator.GetCurrentAnimatorStateInfo(0).IsName("pickUp");
        //AnimatorStateInfo animatorStateInfo = animator.GetCurrentAnimatorStateInfo(0);

        // 애니메이터 상태 전환 여부 

        if (animator.GetCurrentAnimatorStateInfo(0).IsName("pickUp") || animator.IsInTransition(0)/* || animator.GetCurrentAnimatorStateInfo(0).normalizedTime <= 1.0f*/)
        {
            return;
        }
            animator.SetTrigger("pickUp"); 

    }       

    void Walk()
    {
        x = (int)Input.GetAxisRaw("Horizontal");
        animator.SetInteger("X", x);
    }
}
