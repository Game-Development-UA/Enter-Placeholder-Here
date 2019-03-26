using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    float hor;
    float vert;
    public Rigidbody body;

    private void Update()
    {
        hor = Input.GetAxis("Horizontal");
        vert = Input.GetAxis("Vertical");
        body.velocity = (new Vector2(hor * speed, vert * speed));
    }
}
