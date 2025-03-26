using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGameScript : MonoBehaviour
{
    public void Start()
    {
        InputManager.instance.OnJump += Jump;
        InputManager.instance.OnRight += MoveRight;
        InputManager.instance.OnLeft += MoveLeft;
        InputManager.instance.OnDown += MoveDown;
        InputManager.instance.OnUp += MoveUp;
        InputManager.instance.OnFire += Fire;
        EventManager.instance.UpdateUI("9/10HP");
    }

    //Jump is Space
    protected virtual void Jump()
    {
        Debug.Log("Jump!");
    }

    //Move right is the D key
    protected virtual void MoveRight()
    {
        Debug.Log("Move Right!");
    }

    //Move left is the A key
    protected virtual void MoveLeft()
    {
        Debug.Log("Move Left!");
    }

    //Move up is the W key
    protected virtual void MoveUp()
    {
        Debug.Log("Move Up!");
    }

    //Move down is the S key
    protected virtual void MoveDown()
    {
        Debug.Log("Move Down!");
    }

    //Fire is left mouse 
    protected virtual void Fire()
    {
        Debug.Log("Fire!");
        //Here is where we should invoke the event to destroy an enemy
    }
}