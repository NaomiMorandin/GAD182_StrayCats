using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGameScript2D : PlayerGameScript
{
    protected override void Jump()
    {
        base.Jump();
        Debug.Log("Wahoo!");
    }

    protected override void MoveUp()
    {
        Debug.Log("Look up!");
    }

    protected override void MoveDown()
    {
        Debug.Log("Look Down!");
    }
}
