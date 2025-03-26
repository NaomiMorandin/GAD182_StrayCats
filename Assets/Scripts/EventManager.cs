using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public static EventManager instance;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public event Action<string> OnUpdateUI; //Output, attach an String to the action
    public void UpdateUI(string text) //Input, passing a string to anything listening
    {
        OnUpdateUI?.Invoke(text);
    }

    public event Action OnRandomiseColour;
    public void RandomiseColour()
    {
        OnRandomiseColour?.Invoke();
    }

    //Using the above event as an example, create an event that tells an enemy to destroy itself
}