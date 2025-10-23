using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public enum Event
{
    START, PAUSE, EXIT
}

public static class EventManager
{
    private static Dictionary<Event, Action> dictionary = new Dictionary<Event, Action>();

    public static void Subscribe(Event condition, Action action)
    {
        if (dictionary.ContainsKey(condition))
        {
            dictionary[condition] += action;
        }
        else
        {
            dictionary[condition] = action;
        }
    }

    public static void Unsubscribe(Event condition, Action action)
    {
        if (dictionary.ContainsKey(condition))
        {
            dictionary[condition] -= action;
        }
    }

    public static void Publish(Event condition)
    {
        if (dictionary.TryGetValue(condition, out var action))
        {
            action?.Invoke();
        }
    }
}


