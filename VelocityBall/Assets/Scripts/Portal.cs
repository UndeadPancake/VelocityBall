using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    
    Vector2 lookDirection;

    public GameObject bluePort;
    public GameObject orangePort;

    public LayerMask layerMask;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lookDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;

        if (Input.GetKeyDown(KeyCode.Q))
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, lookDirection, 10.0f, layerMask);
            if (hit.collider != null)
                bluePort.transform.position = hit.point;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, lookDirection, 10.0f, layerMask);
            if (hit.collider != null)
                orangePort.transform.position = hit.point + new Vector2(0.34f, 0);
        }
    }
}
