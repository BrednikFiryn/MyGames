
using UnityEngine;

public class ScrollController : MonoBehaviour
{
    public float scrollSpeed;
    public float TileSize;

    private Transform CurrentObject;

    void Start()
    {
        CurrentObject = GetComponent<Transform>();
    }

    void Update()
    {
        ScrollMove();
    }

    private void ScrollMove()
    {
        CurrentObject.position = new Vector3(CurrentObject.position.x, CurrentObject.position.y, Mathf.Repeat(Time.time * scrollSpeed, TileSize));
    }
}
