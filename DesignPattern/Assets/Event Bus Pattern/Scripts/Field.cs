using UnityEngine;

public class Field : MonoBehaviour
{
   [SerializeField] Animator animator;
    private void OnEnable()
    {
        EventManager.Subscribe(Event.START, Excute);
        EventManager.Subscribe(Event.PAUSE, Pause);
        EventManager.Subscribe(Event.EXIT, Destroy);
    }

    public void Excute()
    {
        animator.enabled = true;
    }

    public void Pause()
    {
       animator.enabled = false;
    }

    public void Destroy()
    {
        Destroy(gameObject);
    }

    private void OnDisable()
    {
        EventManager.Unsubscribe(Event.START, Excute);
        EventManager.Unsubscribe(Event.PAUSE, Pause);
        EventManager.Unsubscribe(Event.EXIT, Destroy);
    }
}
