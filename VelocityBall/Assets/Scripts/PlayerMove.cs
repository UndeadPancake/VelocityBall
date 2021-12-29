using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    Rigidbody2D rigidbody;
    const string right = "RIGHT";
    const string left = "LEFT";
    string buttonpressed;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            buttonpressed = right;
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            buttonpressed = left;
        else
            buttonpressed = null;
    }
    private void FixedUpdate()
    {
        if (buttonpressed == right)
            rigidbody.AddForce(new Vector2(speed, 0));
        else if (buttonpressed == left)
            rigidbody.AddForce(new Vector2(-speed, 0));
    }
}
