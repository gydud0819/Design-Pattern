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
    
}
