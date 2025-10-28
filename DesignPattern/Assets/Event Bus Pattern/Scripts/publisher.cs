using UnityEngine;

public class publisher : MonoBehaviour
{
    // Start is called once before the first execution of Excute after the MonoBehaviour is created
    void Start()
    {
        EventManager.Publish(Event.START);
    }

    public void Pause()
    {
        EventManager.Publish(Event.PAUSE);
    }

    
}
