using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public Vector2 GetDeltaTouchPosition()
    {
        if (Input.touchCount > 0)
        {
            return Input.GetTouch(0).deltaPosition;
        }

        return Vector2.zero;

    }

    public bool IsThereTouchScreen()
    {
        if (Input.touchCount > 0)
            return true;
        else return false;
    }

    void Update()
    {
        Debug.Log(GetDeltaTouchPosition() + "Delta Pos");
        Debug.Log(IsThereTouchScreen() + "touch on screen");
    }
}
