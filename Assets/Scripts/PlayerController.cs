using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    float hor;
    float vert;
    float depth;
    public Rigidbody body;

    private void Update()
    {
        hor = Input.GetAxis("Horizontal");
        vert = Input.GetAxis("Vertical");
        depth = Input.GetAxis("Jump");
    }

    private void FixedUpdate()
    {
        body.velocity = (new Vector3(hor * speed, vert * speed, depth * speed));
    }
}
