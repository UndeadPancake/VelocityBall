using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeBehaviour : MonoBehaviour
{
    public LayerMask ropeLayerMask;

    public float distance = 10.0f;

    LineRenderer line;
    DistanceJoint2D rope;

    Vector2 lookDirection;

    bool checker = true;

    void Start()
    {
        rope = GetComponent<DistanceJoint2D>();
        line = GetComponent<LineRenderer>();

        rope.enabled = false;
        line.enabled = false;
    }

    void Update()
    {
        line.SetPosition(0, transform.position);

        lookDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;

        if (Input.GetMouseButtonDown(0) && checker == true)
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, lookDirection, distance, ropeLayerMask);

            if (hit.collider != null)
            {
                checker = false;
                SetRope(hit);
            }
        }
        else if (Input.GetMouseButtonDown(0) && checker == false)
        {
            checker = true;
            DestroyRope();
        }
    }

    void SetRope(RaycastHit2D hit)
    {
        rope.enabled = true;
        rope.connectedAnchor = hit.point;

        line.enabled = true;
        line.SetPosition(1, hit.point);
    }

    void DestroyRope()
    {
        rope.enabled = false;
        line.enabled = false;
    }
}
