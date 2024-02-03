using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Items : MonoBehaviour
{
    [SerializeField]
    private Transform item;
    private Vector2 initialPosition;
    private float deltaX, deltaY;
    public static bool locked;
    private Collider2D itemCollider;
    [SerializeField]
    private HELP controller;
    private const float SNAP_RANGE = 0.5f;

    void Start()
    {
        locked = false;
        initialPosition = transform.position;
        itemCollider = GetComponent<Collider2D>();
    }

    void Update()
    {
        if (Input.touchCount > 0 && !locked)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    if (itemCollider == Physics2D.OverlapPoint(touchPos))
                    {
                        deltaX = touchPos.x - transform.position.x;
                        deltaY = touchPos.y - transform.position.y;
                    }
                    break;
                case TouchPhase.Moved:
                    if (itemCollider == Physics2D.OverlapPoint(touchPos))
                        transform.position = new Vector2(touchPos.x - deltaX, touchPos.y - deltaY);
                    break;
                case TouchPhase.Ended:
                    if (Vector2.Distance(transform.position, item.position) <= SNAP_RANGE)
                    {
                        transform.position = item.position;
                        locked = true;
                        controller.puntaje += 5;
                    }
                    else
                    {
                        transform.position = initialPosition;
                    }
                    break;
            }
        }
    }
}
