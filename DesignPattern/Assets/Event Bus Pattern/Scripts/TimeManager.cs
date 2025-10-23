using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    [SerializeField] Text timeText;

    // 00 : 00 : 00 

    [SerializeField] float time;
    [SerializeField] int min;
    [SerializeField] int sec;
    [SerializeField] int mill;

    [SerializeField] bool state = true;

    private void OnEnable()
    {
        EventManager.Subscribe(Event.START, Excute);
        EventManager.Subscribe(Event.PAUSE, Pause);
        EventManager.Subscribe(Event.EXIT, Exit);
    }

    public void Excute()
    {
        StartCoroutine(Measure());
    }

    public void Pause()
    {
        state = false;
    }

    public void Exit()
    {
        timeText.text = "Game Over";
    }

    public IEnumerator Measure()
    {
        while(state)
        {
            if(time<=0)
            {
                EventManager.Publish(Event.EXIT);
                yield break;
            }
            time -= Time.deltaTime;

            min = (int)time / 60;
            sec = (int)time % 60;
            mill = (int)(time * 100) % 100;

            timeText.text = string.Format("{0:D2} : {1:D2} : {2:D2}", min, sec, mill);

            

            yield return null;
        }
       
    }

    public void OnDisable()
    {
        EventManager.Unsubscribe(Event.START, Excute);
        EventManager.Unsubscribe(Event.PAUSE, Pause);
        EventManager.Unsubscribe(Event.EXIT, Exit);

    }
}
