using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementHandler : MonoBehaviour
{
    public InputHandler inputHandler;
    [SerializeField] private float ballspeed = 1f;

    private void Start()
    {
        if (inputHandler == null) Debug.LogError("input handler не назначен");
    }

    private void MoveBall()
    {
        if (inputHandler.IsThereTouchScreen())
        {
            Vector2 currDeltaPos = inputHandler.GetDeltaTouchPosition();
            Vector3 newGravityVector = new Vector3(currDeltaPos.y, Physics.gravity.y,-currDeltaPos.x);
            Physics.gravity = newGravityVector;
        }
    }

    private void Update()
    {
        MoveBall();
    }
}
