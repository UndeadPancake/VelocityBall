using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeBehaviour : MonoBehaviour
{
    bool click = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
        }
        if (Input.GetMouseButton(0))
            click = true;
        else
            click = false;
    }

    void FindPositions()
    {

    }
}
