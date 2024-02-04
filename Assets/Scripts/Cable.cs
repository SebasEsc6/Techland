using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class Cable : MonoBehaviour
{
    public SpriteRenderer finalCable;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        UpdateSize();
        UpdateRot();
    }
    public void UpdateRot()
    {
        Vector2 currentPos = transform.position;
        Vector2 originPoint = transform.parent.position;
        Vector2 direction = currentPos - originPoint;

        float angle = Vector2.SignedAngle(Vector2.right, direction);
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
    public void UpdateSize()
    {
        Vector2 currentPos = transform.position;
        Vector2 originPoint = transform.parent.position;

        float distance = Vector2.Distance(currentPos, originPoint);

        finalCable.size = new Vector2(distance, finalCable.size.y);
    }
}
